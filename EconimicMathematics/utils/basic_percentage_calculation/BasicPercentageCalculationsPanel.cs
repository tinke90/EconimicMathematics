using EconimicMathematics.utils.basic_percentage_calculation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EconimicMathematics.utils
{
    class BasicPercentageCalculationsPanel
    {
        private string inputField_1 = "";
        private string inputField_2 = "";
        private string resultField = "";

        private double storedValue = 0;

        private Panel pnl_taxRate;
        private Button bt_calculate;
        private Label lb_equals_1;
        private TextBox tf_1_result_1;
        private Label lb_algoritmType;
        private TextBox tf_1_number_1;
        private TextBox tf_1_percentage_1;
        private ComboBox cb_mathAlgorithmType;
        private Panel pnl_explanationPanel;
        private RichTextBox rtb_explanation;

        ToolTip tooltip;

        public BasicPercentageCalculationsPanel(ToolTip _tooltip)
        {
            tooltip = _tooltip;
        }

        public void InitializeComponents()
        {
            LoadComboBoxItems();
            loadToolTipDelay();
            bt_calculateTaxRate();
            cb_loadMathAlgorithm_ClickListener();
            tf_fields_ClickListener();
        }
     
        #region Panel Layout code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        public Panel LoadPanel()
        {
            // PANEL...
            this.pnl_taxRate = new Panel();
            this.lb_equals_1 = new Label();
            this.tf_1_result_1 = new TextBox();
            this.lb_algoritmType = new Label();
            this.tf_1_number_1 = new TextBox();
            this.tf_1_percentage_1 = new TextBox();
            this.cb_mathAlgorithmType = new ComboBox();
            this.bt_calculate = new Button();
            this.pnl_explanationPanel = new Panel();
            this.rtb_explanation = new RichTextBox();
            // 
            // pnl_taxRate
            // 
            this.pnl_taxRate.BorderStyle = BorderStyle.FixedSingle;
            this.pnl_taxRate.Controls.Add(this.cb_mathAlgorithmType);
            this.pnl_taxRate.Controls.Add(this.lb_equals_1);
            this.pnl_taxRate.Controls.Add(this.tf_1_result_1);
            this.pnl_taxRate.Controls.Add(this.lb_algoritmType);
            this.pnl_taxRate.Controls.Add(this.tf_1_number_1);
            this.pnl_taxRate.Controls.Add(this.tf_1_percentage_1);
            this.pnl_taxRate.Controls.Add(this.bt_calculate);
            this.pnl_taxRate.Controls.Add(this.pnl_explanationPanel);
            this.pnl_taxRate.ForeColor = System.Drawing.Color.Black;
            this.pnl_taxRate.Location = new System.Drawing.Point(12, 105);
            this.pnl_taxRate.Name = "pnl_taxRate";
            this.pnl_taxRate.Size = new System.Drawing.Size(868, 420);
            this.pnl_taxRate.TabIndex = 8;
            // 
            // pnl_taxTable
            // 
            this.pnl_explanationPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.pnl_explanationPanel.Controls.Add(this.rtb_explanation);
            this.pnl_explanationPanel.Location = new System.Drawing.Point(464, 12);
            this.pnl_explanationPanel.Name = "pnl_explanationPanel";
            this.pnl_explanationPanel.Size = new System.Drawing.Size(391, 396);
            this.pnl_explanationPanel.TabIndex = 65;
            // 
            // tf_explanation
            // 
            this.rtb_explanation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.rtb_explanation.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rtb_explanation.ForeColor = System.Drawing.Color.White;
            this.rtb_explanation.Location = new System.Drawing.Point(12, 12);
            this.rtb_explanation.Name = "tf_1_number_1";
            this.rtb_explanation.Size = new System.Drawing.Size(367, 372);
            this.rtb_explanation.Font = new System.Drawing.Font("Arial", 12);
            this.rtb_explanation.TabIndex = 47;
            this.rtb_explanation.Text = "Selite sille kuinka tiettyä kaavaa\n" +
                "käytetään ja missä tapauksissa.";
            this.rtb_explanation.BorderStyle = BorderStyle.None;
            this.rtb_explanation.ReadOnly = true;
            // 
            // lb_equals_1
            // 
            this.lb_equals_1.BackColor = System.Drawing.Color.Transparent;
            this.lb_equals_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_equals_1.ForeColor = System.Drawing.Color.White;
            this.lb_equals_1.Location = new System.Drawing.Point(250, 72);
            this.lb_equals_1.Name = "lb_equals_1";
            this.lb_equals_1.Size = new System.Drawing.Size(25, 20);
            this.lb_equals_1.TabIndex = 50;
            this.lb_equals_1.Text = "=";
            this.lb_equals_1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tf_1_result_1
            // 
            this.tf_1_result_1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tf_1_result_1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tf_1_result_1.ForeColor = System.Drawing.Color.White;
            this.tf_1_result_1.Location = new System.Drawing.Point(275, 72);
            this.tf_1_result_1.Name = "tf_1_result_1";
            this.tf_1_result_1.ReadOnly = true;
            this.tf_1_result_1.Size = new System.Drawing.Size(100, 20);
            this.tf_1_result_1.TabIndex = 49;
            this.tf_1_result_1.Text = "0";
            this.tf_1_result_1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lb_algoritmType
            // 
            this.lb_algoritmType.AutoSize = true;
            this.lb_algoritmType.BackColor = System.Drawing.Color.Transparent;
            this.lb_algoritmType.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_algoritmType.ForeColor = System.Drawing.Color.White;
            this.lb_algoritmType.Location = new System.Drawing.Point(22, 52);
            this.lb_algoritmType.Name = "lb_algoritmType";
            this.lb_algoritmType.Size = new System.Drawing.Size(177, 17);
            this.lb_algoritmType.TabIndex = 48;
            this.lb_algoritmType.Text = "Laske prosentit luvusta";
            // 
            // tf_1_number_1
            // 
            this.tf_1_number_1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tf_1_number_1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tf_1_number_1.ForeColor = System.Drawing.Color.White;
            this.tf_1_number_1.Location = new System.Drawing.Point(150, 72);
            this.tf_1_number_1.Name = "tf_1_number_1";
            this.tf_1_number_1.Size = new System.Drawing.Size(100, 20);
            this.tf_1_number_1.TabIndex = 47;
            this.tf_1_number_1.Text = "0";
            this.tf_1_number_1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tf_1_percentage_1
            // 
            this.tf_1_percentage_1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tf_1_percentage_1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tf_1_percentage_1.ForeColor = System.Drawing.Color.White;
            this.tf_1_percentage_1.Location = new System.Drawing.Point(25, 72);
            this.tf_1_percentage_1.Name = "tf_1_percentage_1";
            this.tf_1_percentage_1.Size = new System.Drawing.Size(100, 20);
            this.tf_1_percentage_1.TabIndex = 46;
            this.tf_1_percentage_1.Text = "0";
            this.tf_1_percentage_1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // bt_calculate
            // 
            this.bt_calculate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_calculate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_calculate.ForeColor = System.Drawing.Color.White;
            this.bt_calculate.Location = new System.Drawing.Point(25, 370);
            this.bt_calculate.Name = "bt_calculate";
            this.bt_calculate.Size = new System.Drawing.Size(124, 23);
            this.bt_calculate.TabIndex = 9;
            this.bt_calculate.Text = "LASKE";
            this.bt_calculate.UseVisualStyleBackColor = true;
            // 
            // cb_mathAlgorithmType
            // 
            this.cb_mathAlgorithmType.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.cb_mathAlgorithmType.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cb_mathAlgorithmType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cb_mathAlgorithmType.ForeColor = System.Drawing.Color.White;
            this.cb_mathAlgorithmType.FormattingEnabled = true;
            this.cb_mathAlgorithmType.Location = new System.Drawing.Point(25, 12);
            this.cb_mathAlgorithmType.Name = "cb_mathAlgorithmType";
            this.cb_mathAlgorithmType.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cb_mathAlgorithmType.Size = new System.Drawing.Size(194, 21);
            this.cb_mathAlgorithmType.TabIndex = 56;
            this.cb_mathAlgorithmType.Text = "Laskukaavat";
            
            this.pnl_taxRate.ResumeLayout(false);
            this.pnl_taxRate.PerformLayout();

            return pnl_taxRate;
        }

        #endregion

        #region Panel Visibility Control
        public bool Visible
        {
            set => pnl_taxRate.Visible = value;
        }
        #endregion

        private void LoadComboBoxItems()
        {
            cb_mathAlgorithmType.Items.Add("Laske prosentit luvusta");
            cb_mathAlgorithmType.Items.Add("Kuinka monta prosenttia X on Y:stä");
            cb_mathAlgorithmType.Items.Add("Alkuperäisen arvon laskeminen");
            cb_mathAlgorithmType.Items.Add("Laske alennus");
            cb_mathAlgorithmType.Items.Add("Korotuksen laskeminen");
            cb_mathAlgorithmType.Items.Add("Sovellusten laskeminen");
            cb_mathAlgorithmType.Items.Add("Peräkkäisten muutosten laskeminen");
            cb_mathAlgorithmType.Items.Add("Muutosprosentin laskeminen");
            cb_mathAlgorithmType.Items.Add("Vertailuprosentin laskeminen");
            cb_mathAlgorithmType.Items.Add("Palkan laskeminen");
            cb_mathAlgorithmType.Items.Add("Laske veroprosentti");

            cb_mathAlgorithmType.Items.Add("Sovellus - Hinnan korotus");
            cb_mathAlgorithmType.Items.Add("Sovellus - Hinnan alennus");
            cb_mathAlgorithmType.Items.Add("Sovellus - Vuokran nousu");
        }

        private void loadToolTipDelay()
        {
            // Tooltip displaying time...
            tooltip.AutoPopDelay = 20000;
        }

        private void reloadDescriptionToolTip(string value)
        {
            tooltip.SetToolTip(lb_algoritmType, value);
        }

        private void reloadInputFieldToolTips(string value1, string value2, string value3)
        {
            tooltip.SetToolTip(tf_1_percentage_1, value1);
            tooltip.SetToolTip(tf_1_number_1, value2);
            tooltip.SetToolTip(tf_1_result_1, value3);
        }

        private void bt_calculateTaxRate()
        {
            bt_calculate.Click += (sender, e) =>
            {
                Calculate();
            };
        }

        private void SetCurrentFieldValues(string _algoritmType,
            string _inputField_1, string _inputField_2, string _resultField)
        {
            lb_algoritmType.Text = _algoritmType;

            inputField_1 = _inputField_1;
            inputField_2 = _inputField_2;
            resultField = _resultField;

            tf_1_percentage_1.Text = inputField_1;
            tf_1_number_1.Text = inputField_2;
            tf_1_result_1.Text = resultField;
        }

        private void cb_loadMathAlgorithm_ClickListener()
        {
            cb_mathAlgorithmType.SelectedIndexChanged += (sender, e) => 
            {
                if(cb_mathAlgorithmType.SelectedIndex == 0)
                {
                    SetCurrentFieldValues("Laske prosentit luvusta", "0%", "0", "0.00%");
                    reloadDescriptionToolTip("Esimerkki. Laske kuusi prosenttia luvusta 118.");

                    reloadInputFieldToolTips(
                        "Syötä prosentti X",
                        "Syötä luku Y",
                        "Prosenttia luvusta Y");

                    rtb_explanation.Text = Explanations.GetExplanation(0);
                }
                else if(cb_mathAlgorithmType.SelectedIndex == 1)
                {
                    SetCurrentFieldValues("Kuinka monta prosenttia X on Y:stä", "0", "0", "0.00%");
                    reloadDescriptionToolTip("Esimerkki. Montako prosenttia 2400 on 5100.");
                    
                    reloadInputFieldToolTips(
                        "Syötä luku X, pienempi kuin luku Y",
                        "Syötä luku Y, suurempi kuin luku X",
                        "Luku X on prosenttia luvusta Y");

                    rtb_explanation.Text = Explanations.GetExplanation(1);
                }
                else if(cb_mathAlgorithmType.SelectedIndex == 2)
                {
                    SetCurrentFieldValues("Alkuperäisen arvon laskeminen", "0", "0%", "0.00€");
                    reloadDescriptionToolTip("Esimerkki. Mistä määrästä 35,65 euroa on 82,3 prosenttia");

                    reloadInputFieldToolTips(
                        "Syötä luku X",
                        "Syötä prosentti Y",
                        "Y on prosenttia luvusta X");

                    rtb_explanation.Text = Explanations.GetExplanation(2);
                }
                else if(cb_mathAlgorithmType.SelectedIndex == 3)
                {
                    SetCurrentFieldValues("Alennuksen laskeminen", "0", "0%", "0.00€");
                    reloadDescriptionToolTip("Esimerkki. Tuotteen hinta on 35,50 € ja siitä saa alennusta 15 %.\n" +
                        "Laske alennuksen määrä euroina.");

                    reloadInputFieldToolTips(
                        "Syötä tuotteen hinta",
                        "Syötä alennus prosentti",
                        "Alennuksen määrä");

                    rtb_explanation.Text = Explanations.GetExplanation(3);
                }
                else if(cb_mathAlgorithmType.SelectedIndex == 4)
                {
                    SetCurrentFieldValues("Korotuksen laskeminen", "0", "0%", "0.00€");
                    reloadDescriptionToolTip("Esimerkki. Tuotteen hintaa korotetaan 5 %.\n" +
                        "Laske uusi hinta, kun alkuperäinen hinta on 62,35 €.");

                    reloadInputFieldToolTips(
                        "Syötä alkuperäinen luku",
                        "Syötä korotus",
                        "Uusi hinta");

                    rtb_explanation.Text = Explanations.GetExplanation(4);
                }
                else if(cb_mathAlgorithmType.SelectedIndex == 5)
                {
                    SetCurrentFieldValues("Sovellusten laskeminen", "0%", "0", "0.00€");
                    reloadDescriptionToolTip("Esimerkki. Kalevi ostaa tv:n alennusmyynnistä 15 prosentin\n" +
                        "alennuksella ja maksaa siitä 768,92 €. Mikä on tv:n alkuperäinen hinta");

                    reloadInputFieldToolTips(
                        "Syötä prosentti luku",
                        "Syötä alennettu hinta",
                        "Alkuperäinen hinta");

                    rtb_explanation.Text = Explanations.GetExplanation(5);
                }
                else if(cb_mathAlgorithmType.SelectedIndex == 6)
                {
                    SetCurrentFieldValues("Peräkkäisten muutosten laskeminen", "0", "0%", "0.00€");
                    reloadDescriptionToolTip("Esimerkki. Kauppias alentaa tuotteiden hintaan ensin 15 % ja sitten vielä 40 %.\n" +
                        "Paljonko maksaa alennusten jälkeen tuote, jonka alkuperäinen hinta on 522,50 €");

                    reloadInputFieldToolTips(
                        "Syötä alkuperäinen hinta\n" +
                        "*Tuotteen hinta päivittyy tähän laskun jälkeen jotta*\n" +
                        "*Lasku voidaan suorittaa useamman kerran            *",
                        "Syötä prosentti luku",
                        "Tuotteen hinta alennuksen jälkeen");

                    rtb_explanation.Text = Explanations.GetExplanation(6);
                }
                else if(cb_mathAlgorithmType.SelectedIndex == 7)
                {
                    SetCurrentFieldValues("Muutosprosentin laskeminen", "0", "0", "0.00%");
                    reloadDescriptionToolTip("Esimerkki. Yrityksen asiakasmäärä kasvoi 1 735 hengestä 1 945 henkeen.\n" +
                        "Montako prosenttia asiakasmäärä kasvoi");

                    reloadInputFieldToolTips(
                        "Syötä asiakasmäärä X pienempi kuin asiakasmäärä Y",
                        "Syötä asiakasmäärä Y suurempi kuin asiakasmäärä X",
                        "Asiakasmäärän ero prosentteina");

                    rtb_explanation.Text = Explanations.GetExplanation(7);
                }
                else if(cb_mathAlgorithmType.SelectedIndex == 8)
                {
                    SetCurrentFieldValues("Vertailuprosentin laskeminen", "0", "0", "0.00%");
                    reloadDescriptionToolTip("Esimerkki. Joonalla on 35,60 € ja Riikalla 103,50 €.\n" +
                        "Montako prosenttia vähemmän Joonalla on rahaa");

                    reloadInputFieldToolTips(
                        "Syötä summa X pienempi kuin summa Y",
                        "Syötä summa Y suurempi kuin summa X",
                        "Summan prosentuaalinen ero prosentteina");

                    rtb_explanation.Text = Explanations.GetExplanation(8);
                }
                else if(cb_mathAlgorithmType.SelectedIndex == 9)
                {
                    SetCurrentFieldValues("Nettopalkan laskeminen", "0", "0%", "0.00€");
                    reloadDescriptionToolTip("Esimerkki. Henkilön bruttopalkka on 2 964,31 €/kk ja veroprosentti 22,6.\n" +
                        "Laske henkilön nettopalkka.");

                    reloadInputFieldToolTips(
                        "Syötä bruttopalkka",
                        "Syötä veroprosentti",
                        "Nettopalkan suuruus euroina");

                    rtb_explanation.Text = Explanations.GetExplanation(9);
                }
                else if(cb_mathAlgorithmType.SelectedIndex == 10)
                {
                    SetCurrentFieldValues("Laske henkilön veroprosentti", "0", "0", "0.00%");
                    reloadDescriptionToolTip("Esimerkki. Henkilön bruttopalkka on 3104,84 €/kk ja\n" +
                        "nettopalkka 2198,33 €/kk. Laske henkilön veroprosentti.");

                    reloadInputFieldToolTips(
                        "Syötä bruttopalkka X suurempi kuin nettopalkka Y",
                        "Syötä nettopalkka Y pienempi kuin bruttopalkka X",
                        "Veroprosentti");

                    rtb_explanation.Text = Explanations.GetExplanation(9);
                }
                else if(cb_mathAlgorithmType.SelectedIndex == 11)
                {
                    SetCurrentFieldValues("Sovellus - Hinnan korotus", "0%", "0", "0.00€");
                    reloadDescriptionToolTip("Tuotteen hinta on noussut 32,6 % ja on nyt 13,60 €.\n" +
                        "Montako euroa tuotteen hintaan on tullut korotusta\n" +
                        "*Voidaan käyttää myös useiden muutosten tarkasteluun*\n" +
                        "Esimerkki 2. Vuokra on noussut ensin 2 % ja sitten vielä 7 %.\n" +
                        "Montako euroa vuokra kokonaisuudessaan nousi, kun lopullinen vuokra oli 835,30 €");

                    reloadInputFieldToolTips(
                        "Syötä prosentti luku",
                        "Syötä hinta",
                        "Hintaan lisätty korotus");

                    rtb_explanation.Text = Explanations.GetExplanation(11);
                }
                else if(cb_mathAlgorithmType.SelectedIndex == 12)
                {
                    SetCurrentFieldValues("Sovellus - Hinnan alennus", "0%", "0", "0.00€");
                    reloadDescriptionToolTip(" Alennusmyynnissä tuotteen hintaa alennetaan ensin 20 % ja sitten vielä 25 %.\n" +
                        "Laske tuotteen lopullinen hinta, kun se ennen alennuksia on 129,55 €." +
                        "Esimerkki 2. Vuokra on noussut ensin 2 % ja sitten vielä 7 %. Montako euroa vuokra kokonaisuudessaan nousi,\n" +
                        "kun lopullinen vuokra oli 835,30 €");

                    reloadInputFieldToolTips(
                        "Syötä prosentti luku",
                        "Syötä hinta",
                        "Tuotteen lopullinen hinta");

                    rtb_explanation.Text = Explanations.GetExplanation(12);
                }

                tf_reloadFields_ClickListener();
            };
        }

        private void Calculate()
        {


            // Calculate percentage of the number...
            if(!ContainsChars.Contains(tf_1_percentage_1.Text) &&
                !ContainSymbols.Contains(tf_1_percentage_1.Text) &&
                !ContainsChars.Contains(tf_1_number_1.Text) &&
                !ContainSymbols.Contains(tf_1_number_1.Text))
            {
                
                // 0 Laske prosentit luvusta
                if(cb_mathAlgorithmType.SelectedIndex == 0)
                {
                    CalculatePercentage calculate = new CalculatePercentage();
                    tf_1_result_1.Text = calculate.CalculatePercentageOfNumber(
                    Convert.ToDouble(DecimalPointer.Convert(tf_1_percentage_1.Text)),
                    Convert.ToDouble(DecimalPointer.Convert(tf_1_number_1.Text))).ToString("0.00") + "%";
                }
                
                // 1 Kuinka monta prosenttia X on Y:stä
                else if(cb_mathAlgorithmType.SelectedIndex == 1)
                {
                    CalculatePercentage calculate = new CalculatePercentage();
                    tf_1_result_1.Text = calculate.CalculateHowManyPercent(
                    Convert.ToDouble(DecimalPointer.Convert(tf_1_percentage_1.Text)),
                    Convert.ToDouble(DecimalPointer.Convert(tf_1_number_1.Text))).ToString("0.00") + "%";
                }
                
                // 2 Alkuperäisen arvon laskeminen
                else if(cb_mathAlgorithmType.SelectedIndex == 2)
                {
                    CalculatePercentage calculate = new CalculatePercentage();
                    tf_1_result_1.Text = calculate.CalculateOriginalValue(
                    Convert.ToDouble(DecimalPointer.Convert(tf_1_number_1.Text)),
                    Convert.ToDouble(DecimalPointer.Convert(tf_1_percentage_1.Text))).ToString("0.00") + "€";
                }
                
                // 3 Alennuksen laskeminen
                else if(cb_mathAlgorithmType.SelectedIndex == 3)
                {
                    CalculatePercentage calculate = new CalculatePercentage();
                    tf_1_result_1.Text = calculate.CalculateDiscountPrice(
                    Convert.ToDouble(DecimalPointer.Convert(tf_1_percentage_1.Text)),
                    Convert.ToDouble(DecimalPointer.Convert(tf_1_number_1.Text))).ToString("0.00") + "€";
                }
                
                // 4 Korotuksen laskeminen
                else if(cb_mathAlgorithmType.SelectedIndex == 4)
                {
                    CalculatePercentage calculate = new CalculatePercentage();
                    tf_1_result_1.Text = calculate.CalculatingOfTheIncrease(
                    Convert.ToDouble(DecimalPointer.Convert(tf_1_number_1.Text)),
                    Convert.ToDouble(DecimalPointer.Convert(tf_1_percentage_1.Text))).ToString("0.00") + "€";
                }
                
                // 5 Sovellusten laskeminen
                else if(cb_mathAlgorithmType.SelectedIndex == 5)
                {
                    CalculatePercentage calculate = new CalculatePercentage();
                    tf_1_result_1.Text = calculate.ComputingApplications(
                    Convert.ToDouble(DecimalPointer.Convert(tf_1_percentage_1.Text)),
                    Convert.ToDouble(DecimalPointer.Convert(tf_1_number_1.Text))).ToString("0.00") + "€";
                }
                
                // 6 Peräkkäisten muutosten laskeminen
                else if(cb_mathAlgorithmType.SelectedIndex == 6)
                {
                    CalculatePercentage calculate = new CalculatePercentage();
                    string result = calculate.CalculatingSuccessiveChanges(
                    Convert.ToDouble(DecimalPointer.Convert(tf_1_number_1.Text)),
                    Convert.ToDouble(DecimalPointer.Convert(tf_1_percentage_1.Text))).ToString("0.00");

                    tf_1_result_1.Text = result + "€";
                    tf_1_percentage_1.Text = result;
                }
                
                // 7 Muutosprosentin laskeminen
                else if(cb_mathAlgorithmType.SelectedIndex == 7)
                {
                    CalculatePercentage calculate = new CalculatePercentage();
                    string result = calculate.CalculatingPercentageChanges(
                    Convert.ToDouble(DecimalPointer.Convert(tf_1_percentage_1.Text)),
                    Convert.ToDouble(DecimalPointer.Convert(tf_1_number_1.Text))).ToString("0.00");

                    tf_1_result_1.Text = result + "%";
                }
                
                // 8 Vertailuprosentin laskeminen
                else if(cb_mathAlgorithmType.SelectedIndex == 8)
                {
                    CalculatePercentage calculate = new CalculatePercentage();
                    string result = calculate.CalculatingReferencePercentage(
                    Convert.ToDouble(DecimalPointer.Convert(tf_1_percentage_1.Text)),
                    Convert.ToDouble(DecimalPointer.Convert(tf_1_number_1.Text))).ToString("0.00");

                    tf_1_result_1.Text = result + "%";
                }
                
                // 9 Nettopalkan laskeminen
                else if(cb_mathAlgorithmType.SelectedIndex == 9)
                {
                    CalculatePercentage calculate = new CalculatePercentage();
                    string result = calculate.SalaryCalculation(
                    Convert.ToDouble(DecimalPointer.Convert(tf_1_number_1.Text)),
                    Convert.ToDouble(DecimalPointer.Convert(tf_1_percentage_1.Text))).ToString("0.00");

                    tf_1_result_1.Text = result + "€";
                }
                
                // 10 Laske henkilön veroprosentti
                else if(cb_mathAlgorithmType.SelectedIndex == 10)
                {
                    CalculatePercentage calculate = new CalculatePercentage();
                    string result = calculate.CalculateTaxRate(
                    Convert.ToDouble(DecimalPointer.Convert(tf_1_number_1.Text)),
                    Convert.ToDouble(DecimalPointer.Convert(tf_1_percentage_1.Text))).ToString("0.00");

                    tf_1_result_1.Text = result + "%";
                }
                
                // 11 Sovellus - Hinnan korotus
                else if(cb_mathAlgorithmType.SelectedIndex == 11)
                {
                    CalculatePercentage calculate = new CalculatePercentage();
                    double result = calculate.PriceIncrease(
                    Convert.ToDouble(DecimalPointer.Convert(tf_1_number_1.Text)),
                    Convert.ToDouble(DecimalPointer.Convert(tf_1_percentage_1.Text)));

                    tf_1_result_1.Text = result.ToString("0.00") + "€";
                }

                // 12 Sovellus - Hinnan alennus
                else if(cb_mathAlgorithmType.SelectedIndex == 12)
                {
                    CalculatePercentage calculate = new CalculatePercentage();
                    string result = calculate.PriceReduction(
                    Convert.ToDouble(DecimalPointer.Convert(tf_1_number_1.Text)),
                    Convert.ToDouble(DecimalPointer.Convert(tf_1_percentage_1.Text))).ToString("0.00");

                    tf_1_result_1.Text = result + "€";
                }

            }

        }

        private void tf_reloadFields_ClickListener()
        {
            Textfield.LoadClearClickListener(tf_1_percentage_1);
            Textfield.LoadClearClickListener(tf_1_number_1);

            Textfield.LoadDoubleTabClearClickListener(tf_1_percentage_1, inputField_1);
            Textfield.LoadDoubleTabClearClickListener(tf_1_number_1, inputField_2);
        }

        private void tf_fields_ClickListener()
        {
            Textfield.LoadClearClickListener(tf_1_percentage_1);
            Textfield.LoadClearClickListener(tf_1_number_1);

            Textfield.LoadDoubleTabClearClickListener(tf_1_percentage_1, inputField_1);
            Textfield.LoadDoubleTabClearClickListener(tf_1_number_1, inputField_2);
        }
    }
}
