using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EconimicMathematics.utils
{
    class InvestmentCalculation
    {
        private int nextYear = 0;

        private string inputField_1 = "";
        private string inputField_2 = "";
        private string resultField = "";


        public InvestmentCalculation(ToolTip _tooltip)
        {
            tooltip = _tooltip;
        }

        public void InitializeComponents()
        {
            tf_reloadFields_ClickListener();
            tf_fields_ClickListener();
            LoadComboBoxItems();
            cb_loadMathAlgorithm_ClickListener();
            loadToolTips();
            bt_calculateTaxRate();

            LoadTaxableFields(false);
            LoadTimelineFields(false);
            LoadYearlyInterestRateFields(false);
        }

        private Panel pnl_investment; //
        private Label lb_algoritmType; //
        private TextBox tf_result; //
        private TextBox tf_withdraw; //
        private Button bt_calculate;
        private Label lb_equals_1; //
        private ComboBox cb_mathAlgorithmType; // 
        private Label lb_annualInterestRate; //
        private TextBox tf_annualInterestRate; //
        private Label lb_withholdingTax; //
        private TextBox tf_withholdingTax; //
        private Label lb_timeline; //
        private TextBox tf_timeline; //
        private Label lb_nextYear; //
        private Label lb_year; //
        private Label lb_taxableInterest; //
        private TextBox tf_taxableInterest; //
        private TextBox tf_ofYear;
        private ToolTip tooltip;

        #region Panel Layout code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        public Panel LoadPanel()
        {
            // PANEL...
            this.pnl_investment = new Panel();
            this.lb_nextYear = new Label();
            this.lb_year = new Label();
            this.lb_timeline = new Label();
            this.tf_timeline = new TextBox();
            this.lb_withholdingTax = new Label();
            this.tf_withholdingTax = new TextBox();
            this.lb_annualInterestRate = new Label();
            this.tf_annualInterestRate = new TextBox();
            this.lb_equals_1 = new Label();
            this.lb_algoritmType = new Label();
            this.tf_result = new TextBox();
            this.tf_withdraw = new TextBox();
            this.bt_calculate = new Button();
            this.cb_mathAlgorithmType = new ComboBox();
            this.lb_taxableInterest = new Label();
            this.tf_taxableInterest = new TextBox();
            this.tf_ofYear = new TextBox();
            // 
            // pnl_investment
            // 
            this.pnl_investment.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl_investment.Controls.Add(this.lb_taxableInterest);
            this.pnl_investment.Controls.Add(this.tf_taxableInterest);
            this.pnl_investment.Controls.Add(this.lb_nextYear);
            this.pnl_investment.Controls.Add(this.lb_year);
            this.pnl_investment.Controls.Add(this.lb_timeline);
            this.pnl_investment.Controls.Add(this.tf_timeline);
            this.pnl_investment.Controls.Add(this.lb_withholdingTax);
            this.pnl_investment.Controls.Add(this.tf_withholdingTax);
            this.pnl_investment.Controls.Add(this.lb_annualInterestRate);
            this.pnl_investment.Controls.Add(this.tf_annualInterestRate);
            this.pnl_investment.Controls.Add(this.lb_equals_1);
            this.pnl_investment.Controls.Add(this.lb_algoritmType);
            this.pnl_investment.Controls.Add(this.tf_result);
            this.pnl_investment.Controls.Add(this.tf_withdraw);
            this.pnl_investment.Controls.Add(this.bt_calculate);
            this.pnl_investment.Controls.Add(this.cb_mathAlgorithmType);
            this.pnl_investment.Controls.Add(this.tf_ofYear);
            this.pnl_investment.ForeColor = System.Drawing.Color.Black;
            this.pnl_investment.Location = new System.Drawing.Point(12, 105);
            this.pnl_investment.Name = "pnl_investment";
            this.pnl_investment.Size = new System.Drawing.Size(868, 420);
            this.pnl_investment.TabIndex = 8;
            // 
            // lb_nextYear
            // 
            this.lb_nextYear.AutoSize = true;
            this.lb_nextYear.BackColor = System.Drawing.Color.Transparent;
            this.lb_nextYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_nextYear.ForeColor = System.Drawing.Color.White;
            this.lb_nextYear.Location = new System.Drawing.Point(206, 183);
            this.lb_nextYear.Name = "lb_nextYear";
            this.lb_nextYear.Size = new System.Drawing.Size(16, 17);
            this.lb_nextYear.TabIndex = 78;
            this.lb_nextYear.Text = "0";
            // 
            // lb_year
            // 
            this.lb_year.AutoSize = true;
            this.lb_year.BackColor = System.Drawing.Color.Transparent;
            this.lb_year.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_year.ForeColor = System.Drawing.Color.White;
            this.lb_year.Location = new System.Drawing.Point(147, 183);
            this.lb_year.Name = "lb_year";
            this.lb_year.Size = new System.Drawing.Size(53, 17);
            this.lb_year.TabIndex = 77;
            this.lb_year.Text = "Vuosi:";
            // 
            // lb_timeline
            // 
            this.lb_timeline.AutoSize = true;
            this.lb_timeline.BackColor = System.Drawing.Color.Transparent;
            this.lb_timeline.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_timeline.ForeColor = System.Drawing.Color.White;
            this.lb_timeline.Location = new System.Drawing.Point(22, 212);
            this.lb_timeline.Name = "lb_timeline";
            this.lb_timeline.Size = new System.Drawing.Size(65, 13);
            this.lb_timeline.TabIndex = 76;
            this.lb_timeline.Text = "Aikaväli - kk";
            // 
            // tf_timeline
            // 
            this.tf_timeline.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tf_timeline.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tf_timeline.ForeColor = System.Drawing.Color.White;
            this.tf_timeline.Location = new System.Drawing.Point(25, 232);
            this.tf_timeline.Name = "tf_timeline";
            this.tf_timeline.Size = new System.Drawing.Size(100, 20);
            this.tf_timeline.TabIndex = 75;
            this.tf_timeline.Text = "12kk";
            this.tf_timeline.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lb_withholdingTax
            // 
            this.lb_withholdingTax.AutoSize = true;
            this.lb_withholdingTax.BackColor = System.Drawing.Color.Transparent;
            this.lb_withholdingTax.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_withholdingTax.ForeColor = System.Drawing.Color.White;
            this.lb_withholdingTax.Location = new System.Drawing.Point(22, 160);
            this.lb_withholdingTax.Name = "lb_withholdingTax";
            this.lb_withholdingTax.Size = new System.Drawing.Size(58, 13);
            this.lb_withholdingTax.TabIndex = 74;
            this.lb_withholdingTax.Text = "Lähdevero";
            // 
            // tf_withholdingTax
            // 
            this.tf_withholdingTax.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tf_withholdingTax.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tf_withholdingTax.ForeColor = System.Drawing.Color.White;
            this.tf_withholdingTax.Location = new System.Drawing.Point(25, 180);
            this.tf_withholdingTax.Name = "tf_withholdingTax";
            this.tf_withholdingTax.Size = new System.Drawing.Size(100, 20);
            this.tf_withholdingTax.TabIndex = 73;
            this.tf_withholdingTax.Text = "0%";
            this.tf_withholdingTax.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lb_annualInterestRate
            // 
            this.lb_annualInterestRate.AutoSize = true;
            this.lb_annualInterestRate.BackColor = System.Drawing.Color.Transparent;
            this.lb_annualInterestRate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_annualInterestRate.ForeColor = System.Drawing.Color.White;
            this.lb_annualInterestRate.Location = new System.Drawing.Point(22, 108);
            this.lb_annualInterestRate.Name = "lb_annualInterestRate";
            this.lb_annualInterestRate.Size = new System.Drawing.Size(60, 13);
            this.lb_annualInterestRate.TabIndex = 72;
            this.lb_annualInterestRate.Text = "Vuosikorko";
            // 
            // tf_ofYear
            // 
            this.tf_ofYear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tf_ofYear.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tf_ofYear.ForeColor = System.Drawing.Color.White;
            this.tf_ofYear.Location = new System.Drawing.Point(270, 73);
            this.tf_ofYear.Name = "tf_result";
            this.tf_ofYear.ReadOnly = true;
            this.tf_ofYear.Size = new System.Drawing.Size(100, 20);
            this.tf_ofYear.TabIndex = 47;
            this.tf_ofYear.Text = "0,00€";
            this.tf_ofYear.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tf_annualInterestRate
            // 
            this.tf_annualInterestRate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tf_annualInterestRate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tf_annualInterestRate.ForeColor = System.Drawing.Color.White;
            this.tf_annualInterestRate.Location = new System.Drawing.Point(25, 128);
            this.tf_annualInterestRate.Name = "tf_annualInterestRate";
            this.tf_annualInterestRate.Size = new System.Drawing.Size(100, 20);
            this.tf_annualInterestRate.TabIndex = 71;
            this.tf_annualInterestRate.Text = "0%";
            this.tf_annualInterestRate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lb_equals_1
            // 
            this.lb_equals_1.BackColor = System.Drawing.Color.Transparent;
            this.lb_equals_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_equals_1.ForeColor = System.Drawing.Color.White;
            this.lb_equals_1.Location = new System.Drawing.Point(125, 73);
            this.lb_equals_1.Name = "lb_equals_1";
            this.lb_equals_1.Size = new System.Drawing.Size(25, 20);
            this.lb_equals_1.TabIndex = 50;
            this.lb_equals_1.Text = "=";
            this.lb_equals_1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_algoritmType
            // 
            this.lb_algoritmType.AutoSize = true;
            this.lb_algoritmType.BackColor = System.Drawing.Color.Transparent;
            this.lb_algoritmType.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_algoritmType.ForeColor = System.Drawing.Color.White;
            this.lb_algoritmType.Location = new System.Drawing.Point(22, 53);
            this.lb_algoritmType.Name = "lb_algoritmType";
            this.lb_algoritmType.Size = new System.Drawing.Size(171, 17);
            this.lb_algoritmType.TabIndex = 48;
            this.lb_algoritmType.Text = "Laske verotettu määrä";
            // 
            // tf_result
            // 
            this.tf_result.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tf_result.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tf_result.ForeColor = System.Drawing.Color.White;
            this.tf_result.Location = new System.Drawing.Point(150, 73);
            this.tf_result.Name = "tf_result";
            this.tf_result.ReadOnly = true;
            this.tf_result.Size = new System.Drawing.Size(100, 20);
            this.tf_result.TabIndex = 47;
            this.tf_result.Text = "0,00€";
            this.tf_result.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tf_withdraw
            // 
            this.tf_withdraw.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tf_withdraw.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tf_withdraw.ForeColor = System.Drawing.Color.White;
            this.tf_withdraw.Location = new System.Drawing.Point(25, 73);
            this.tf_withdraw.Name = "tf_withdraw";
            this.tf_withdraw.Size = new System.Drawing.Size(100, 20);
            this.tf_withdraw.TabIndex = 46;
            this.tf_withdraw.Text = "0";
            this.tf_withdraw.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
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
            // 
            // lb_taxableInterest
            // 
            this.lb_taxableInterest.AutoSize = true;
            this.lb_taxableInterest.BackColor = System.Drawing.Color.Transparent;
            this.lb_taxableInterest.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_taxableInterest.ForeColor = System.Drawing.Color.White;
            this.lb_taxableInterest.Location = new System.Drawing.Point(147, 108);
            this.lb_taxableInterest.Name = "lb_taxableInterest";
            this.lb_taxableInterest.Size = new System.Drawing.Size(83, 13);
            this.lb_taxableInterest.TabIndex = 80;
            this.lb_taxableInterest.Text = "Verollinen korko";
            // 
            // tf_taxableInterest
            // 
            this.tf_taxableInterest.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tf_taxableInterest.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tf_taxableInterest.ForeColor = System.Drawing.Color.White;
            this.tf_taxableInterest.Location = new System.Drawing.Point(150, 128);
            this.tf_taxableInterest.Name = "tf_taxableInterest";
            this.tf_taxableInterest.ReadOnly = true;
            this.tf_taxableInterest.Size = new System.Drawing.Size(100, 20);
            this.tf_taxableInterest.TabIndex = 79;
            this.tf_taxableInterest.Text = "0,00€";
            this.tf_taxableInterest.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            
            this.pnl_investment.ResumeLayout(false);
            this.pnl_investment.PerformLayout();
            

            return this.pnl_investment;
        }
        #endregion

        #region Panel Visibility Control
        public bool Visible
        {
            set => pnl_investment.Visible = value;
        }
        #endregion

        private void LoadComboBoxItems()
        {
            cb_mathAlgorithmType.Items.Add("Laske korko ajalta");
            cb_mathAlgorithmType.Items.Add("Laske pääoma korkoineen");
            cb_mathAlgorithmType.Items.Add("Laske kuukausittainen korko");
        }

        private void LoadTimelineFields(bool visible)
        {
            tf_timeline.Visible = visible;
            lb_timeline.Visible = visible;
        }

        private void LoadOfYearField(bool visible)
        {
            tf_ofYear.Visible = visible;
        }

        private void LoadTaxableFields(bool visible)
        {
            tf_taxableInterest.Visible = visible;
            lb_taxableInterest.Visible = visible;
        }

        private void LoadYearlyInterestRateFields(bool visible)
        {
            lb_year.Visible = visible;
            lb_nextYear.Visible = visible;
        }


        private void cb_loadMathAlgorithm_ClickListener()
        {
            cb_mathAlgorithmType.SelectedIndexChanged += (sender, e) =>
            {
                LoadTaxableFields(false);
                LoadTimelineFields(false);
                LoadYearlyInterestRateFields(false);
                LoadOfYearField(false);

                if(cb_mathAlgorithmType.SelectedIndex == 0)
                {
                    SetCurrentFieldValues("Paljonko henkilö saa pääomalleen verotonta korkoa", "0 €", "0 %", "0.00€");
                    reloadDescriptionToolTip("Esimerkki 1. Henkilöllä on tilillään puolen vuoden ajan 17 000 €. Tilin vuosikorko on 0,25 %." +
                        "Paljonko henkilö saa pääomalleen verotonta korkoa? Lähdevero on 30 %..");

                    LoadOfYearField(true);

                    string[] tips = { "Syötä sijoitettava summa", "Korko puolelta vuodelta.", "Korko kokonaiselta vuodelta"};

                    setTextfieldTooltips(tips);
                }
                else if(cb_mathAlgorithmType.SelectedIndex == 1)
                {
                    SetCurrentFieldValues("Tilin pääoma 2 vuoden kuluttua", "0", "0", "0.00€");
                    reloadDescriptionToolTip("Esimerkki 2. Henkilö tallettaa tililleen 20 000 € kahdeksi vuodeksi. Tilin vuosikorko on 0,3 % ja veroton korko" +
                        "lisätään pääomaan vuosittain. Paljonko tilillä on rahaa kahden vuoden kuluttua? Lähdevero on 30 %.");

                    LoadYearlyInterestRateFields(true);
                    LoadOfYearField(true);

                    string[] tips = { "Syötä talletettu summa", "Veroton korko.", "Korko kokonaiselta vuodelta" };

                    setTextfieldTooltips(tips);
                }
                else if(cb_mathAlgorithmType.SelectedIndex == 2)
                {
                    SetCurrentFieldValues("Laske tilillä olleen pääoman määrä", "0", "0", "0.00€");
                    reloadDescriptionToolTip("Esimerkki 3. Henkilö saa kolmen kuukauden talletukselleen verotonta korkoa 0,12 €." +
                        "Laske tilillä olleen pääoman määrä,kun tilin vuosikorko oli 1,1 % ja lähdevero on 30 %..");

                    LoadTimelineFields(true);
                    LoadTaxableFields(true);

                    string[] tips = { "Syötä veroton korko-osuus", "Pääoman suuruus", "Korko kokonaiselta vuodelta" };

                    setTextfieldTooltips(tips);
                }

                tf_reloadFields_ClickListener();

                nextYear = 0;
                lb_nextYear.Text = nextYear.ToString();
            };
        }

        private void reloadDescriptionToolTip(string value)
        {
            tooltip.SetToolTip(lb_algoritmType, value);
        }

        private void SetCurrentFieldValues(string _algoritmType,
            string _inputField_1, string _inputField_2, string _resultField)
        {
            lb_algoritmType.Text = _algoritmType;

            inputField_1 = _inputField_1;
            inputField_2 = _inputField_2;
            resultField = _resultField;

            tf_withdraw.Text = inputField_1;
            tf_result.Text = resultField;
        }

        private void setTextfieldTooltips(string[] tips)
        {
            tooltip.SetToolTip(tf_withdraw, tips[0]);
            tooltip.SetToolTip(tf_result, tips[1]);
            tooltip.SetToolTip(tf_ofYear, tips[2]);
        }

        private void loadToolTips()
        {
            // Tooltip displaying time...
            tooltip.AutoPopDelay = 20000;
        }

        private void bt_calculateTaxRate()
        {
            bt_calculate.Click += (sender, e) =>
            {
                Calculate();
            };
        }

        private void Calculate()
        {
            // Calculate percentage of the number...
            if(!ContainsChars.Contains(tf_withdraw.Text) &&
                !ContainSymbols.Contains(tf_withdraw.Text))
            {
                CalculationOfIncomeTax();
            }

        }

        private void CalculationOfIncomeTax()
        {
            double investment = Convert.ToDouble(DecimalPointer.Convert(tf_withdraw.Text));
            double annualIntrestRate = Convert.ToDouble(
                DecimalPointer.Convert(RemoveSymbols.Remove(tf_annualInterestRate.Text)));
            double withholdingTax = Convert.ToDouble(
                DecimalPointer.Convert(RemoveSymbols.Remove(tf_withholdingTax.Text)));
            double timeline = Convert.ToDouble(ContainsChars.Remove(tf_timeline.Text));

            if(cb_mathAlgorithmType.SelectedIndex == 0)
            {
                annualIntrestRate = annualIntrestRate / 100;
                withholdingTax = withholdingTax / 100;
                withholdingTax = 1 - withholdingTax;

                double result = annualIntrestRate * investment;
                result = withholdingTax * result;
                double ofYear = result;
                result = result / 2;

                tf_ofYear.Text = ofYear.ToString("0.00") + "€";
                tf_result.Text = result.ToString("0.00") + "€";
            }
            else if(cb_mathAlgorithmType.SelectedIndex == 1)
            {
                annualIntrestRate = annualIntrestRate / 100;
                withholdingTax = withholdingTax / 100;
                withholdingTax = 1 - withholdingTax;

                double result = annualIntrestRate * investment;
                double yearlyInterest = result;
                result = withholdingTax * result;
                

                nextYear++;
                lb_nextYear.Text = nextYear.ToString();

                tf_result.Text = result.ToString("0.00") + "€";
                tf_withdraw.Text = (result + investment).ToString("0.00");
                tf_ofYear.Text = yearlyInterest.ToString("0.00");
            }
            else if(cb_mathAlgorithmType.SelectedIndex == 2)
            {
                annualIntrestRate = annualIntrestRate / 100;
                withholdingTax = withholdingTax / 100;
                withholdingTax = 1 - withholdingTax;

                double result = investment / withholdingTax;

                result = Convert.ToDouble(DecimalPointer.Convert(ContainsChars.Remove(tf_timeline.Text))) * result;

                double fund = result / annualIntrestRate;

                nextYear++;
                lb_nextYear.Text = nextYear.ToString();

                tf_taxableInterest.Text = result.ToString("0.00") + "€";
                tf_result.Text = fund.ToString("0.00") + "€";

            }
        }

        private string FilterSymbols(string value)
        {
            value = value.Trim();
            value = value.Replace("€", "");
            value = value.Replace("%", "");
            value = value.Replace(" ", "");

            return DecimalPointer.Convert(value).ToString();
        }

        private void tf_reloadFields_ClickListener()
        {
            Textfield.LoadClearClickListener(tf_withdraw);
            Textfield.LoadClearClickListener(tf_result);

            Textfield.LoadDoubleTabClearClickListener(tf_withdraw, inputField_1);
            Textfield.LoadDoubleTabClearClickListener(tf_result, inputField_2);
        }

        private void tf_fields_ClickListener()
        {
            Textfield.LoadClearClickListener(tf_withdraw);
            Textfield.LoadClearClickListener(tf_result);

            Textfield.LoadDoubleTabClearClickListener(tf_withdraw, inputField_1);
            Textfield.LoadDoubleTabClearClickListener(tf_result, inputField_2);
        }
    }
}
