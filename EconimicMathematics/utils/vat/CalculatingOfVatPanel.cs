using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EconimicMathematics.utils.vat
{
    class CalculatingOfVatPanel
    {
        private int merchandise = 10;
        private int foods = 14;
        private int others = 24;

        private int current_vat = 0;

        private string inputField_1 = "";
        private string inputField_2 = "";
        private string resultField = "";

        private Panel pnl_calculatingVAT;
        private ToolTip tooltip;
        private Label lb_algoritmType;
        private TextBox tf_result;
        private TextBox tf_productPrice;
        private Button bt_calculate;
        private Panel pnl_taxTable;
        private Label label1;
        private TableLayoutPanel tableLayoutPanel1;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label lb_equals_1;
        private ComboBox cb_mathAlgorithmType;
        private ComboBox cb_vat;
        private Label lb_netPrice;
        private TextBox tf_netPrice;

        public CalculatingOfVatPanel(ToolTip _tooltip)
        {
            tooltip = _tooltip;
        }

        public void InitializeComponents()
        {
            loadToolTipDelay();
            bt_calculateTaxRate();
            tf_reloadFields_ClickListener();
            tf_fields_ClickListener();

            LoadComboBoxItems();
            VAT_Loader();
            cb_loadMathAlgorithm_ClickListener();
            loadToolTips();

            LoadNetPriceTextfield(false);
        }

        #region Panel Layout code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        public Panel LoadPanel()
        {
            
            this.pnl_calculatingVAT = new Panel();
            this.cb_vat = new ComboBox();
            this.pnl_taxTable = new Panel();
            this.tableLayoutPanel1 = new TableLayoutPanel();
            this.label8 = new Label();
            this.label7 = new Label();
            this.label6 = new Label();
            this.label5 = new Label();
            this.label4 = new Label();
            this.label3 = new Label();
            this.label2 = new Label();
            this.label1 = new Label();
            this.lb_equals_1 = new Label();
            this.lb_algoritmType = new Label();
            this.tf_result = new TextBox();
            this.tf_productPrice = new TextBox();
            this.bt_calculate = new Button();
            this.cb_mathAlgorithmType = new ComboBox();
            this.lb_netPrice = new Label();
            this.tf_netPrice = new TextBox();
            this.pnl_taxTable.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            // 
            // pnl_calculatingVAT
            // 
            this.pnl_calculatingVAT.BorderStyle = BorderStyle.FixedSingle;
            this.pnl_calculatingVAT.Controls.Add(this.cb_vat);
            this.pnl_calculatingVAT.Controls.Add(this.pnl_taxTable);
            this.pnl_calculatingVAT.Controls.Add(this.lb_equals_1);
            this.pnl_calculatingVAT.Controls.Add(this.lb_algoritmType);
            this.pnl_calculatingVAT.Controls.Add(this.tf_result);
            this.pnl_calculatingVAT.Controls.Add(this.tf_productPrice);
            this.pnl_calculatingVAT.Controls.Add(this.bt_calculate);
            this.pnl_calculatingVAT.Controls.Add(this.cb_mathAlgorithmType);
            this.pnl_calculatingVAT.Controls.Add(this.tf_netPrice);
            this.pnl_calculatingVAT.Controls.Add(this.lb_netPrice);
            this.pnl_calculatingVAT.ForeColor = System.Drawing.Color.Black;
            this.pnl_calculatingVAT.Location = new System.Drawing.Point(12, 105);
            this.pnl_calculatingVAT.Name = "pnl_calculatingVAT";
            this.pnl_calculatingVAT.Size = new System.Drawing.Size(868, 420);
            this.pnl_calculatingVAT.TabIndex = 8;
            // 
            // cb_vat
            // 
            this.cb_vat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.cb_vat.Cursor = Cursors.Hand;
            this.cb_vat.FlatStyle = FlatStyle.Flat;
            this.cb_vat.ForeColor = System.Drawing.Color.White;
            this.cb_vat.FormattingEnabled = true;
            this.cb_vat.Location = new System.Drawing.Point(243, 12);
            this.cb_vat.Name = "cb_vat";
            this.cb_vat.RightToLeft = RightToLeft.No;
            this.cb_vat.Size = new System.Drawing.Size(194, 21);
            this.cb_vat.TabIndex = 70;
            this.cb_vat.Text = "Arvonlisävero";
            // 
            // pnl_taxTable
            // 
            this.pnl_taxTable.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.pnl_taxTable.Controls.Add(this.tableLayoutPanel1);
            this.pnl_taxTable.Location = new System.Drawing.Point(464, 12);
            this.pnl_taxTable.Name = "pnl_taxTable";
            this.pnl_taxTable.Size = new System.Drawing.Size(391, 333);
            this.pnl_taxTable.TabIndex = 65;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.label8, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.label7, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.label6, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label4, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 15.90909F));
            this.tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 51.2987F));
            this.tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 17.20779F));
            this.tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 16.55844F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(367, 308);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // label8
            // 
            this.label8.Anchor = ((AnchorStyles)((((AnchorStyles.Top | AnchorStyles.Bottom)
            | AnchorStyles.Left)
            | AnchorStyles.Right)));
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.BorderStyle = BorderStyle.FixedSingle;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(186, 256);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(178, 52);
            this.label8.TabIndex = 73;
            this.label8.Text = "Muut";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.Anchor = ((AnchorStyles)((((AnchorStyles.Top | AnchorStyles.Bottom)
            | AnchorStyles.Left)
            | AnchorStyles.Right)));
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.BorderStyle = BorderStyle.FixedSingle;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(3, 256);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(177, 52);
            this.label7.TabIndex = 72;
            this.label7.Text = "24%";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.Anchor = ((AnchorStyles)((((AnchorStyles.Top | AnchorStyles.Bottom)
            | AnchorStyles.Left)
            | AnchorStyles.Right)));
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.BorderStyle = BorderStyle.FixedSingle;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(186, 204);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(178, 52);
            this.label6.TabIndex = 71;
            this.label6.Text = "Elintarvikkeet, ravintola- ja ateriapalvelut, rehut";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.Anchor = ((AnchorStyles)((((AnchorStyles.Top | AnchorStyles.Bottom)
            | AnchorStyles.Left)
            | AnchorStyles.Right)));
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.BorderStyle = BorderStyle.FixedSingle;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(3, 204);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(177, 52);
            this.label5.TabIndex = 70;
            this.label5.Text = "14%";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.Anchor = ((AnchorStyles)((((AnchorStyles.Top | AnchorStyles.Bottom)
            | AnchorStyles.Left)
            | AnchorStyles.Right)));
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.BorderStyle = BorderStyle.FixedSingle;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(186, 48);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(178, 156);
            this.label4.TabIndex = 69;
            this.label4.Text = "Läälleet, kirjat, tilatut sanoma- ja aikakauslehdet, liikuntapalvelut, henkilökul" +
    "jetukset, majoituspalvelut, kulttuuri- ja viihdetilaisuudet";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Anchor = ((AnchorStyles)((((AnchorStyles.Top | AnchorStyles.Bottom)
            | AnchorStyles.Left)
            | AnchorStyles.Right)));
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.BorderStyle = BorderStyle.FixedSingle;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(3, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(177, 156);
            this.label3.TabIndex = 68;
            this.label3.Text = "10%";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Anchor = ((AnchorStyles)((((AnchorStyles.Top | AnchorStyles.Bottom)
            | AnchorStyles.Left)
            | AnchorStyles.Right)));
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.BorderStyle = BorderStyle.FixedSingle;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(186, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(178, 48);
            this.label2.TabIndex = 67;
            this.label2.Text = "Tuotteet ja palvelut";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Anchor = ((AnchorStyles)((((AnchorStyles.Top | AnchorStyles.Bottom)
            | AnchorStyles.Left)
            | AnchorStyles.Right)));
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.BorderStyle = BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(177, 48);
            this.label1.TabIndex = 66;
            this.label1.Text = "Arvolisäveronprosentti Suomessa (v. 2019->)";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_equals_1
            // 
            this.lb_equals_1.BackColor = System.Drawing.Color.Transparent;
            this.lb_equals_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_equals_1.ForeColor = System.Drawing.Color.White;
            this.lb_equals_1.Location = new System.Drawing.Point(125, 72);
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
            this.lb_algoritmType.Location = new System.Drawing.Point(22, 52);
            this.lb_algoritmType.Name = "lb_algoritmType";
            this.lb_algoritmType.Size = new System.Drawing.Size(171, 17);
            this.lb_algoritmType.TabIndex = 48;
            this.lb_algoritmType.Text = "Laske verotettu määrä";
            // 
            // tf_result
            // 
            this.tf_result.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tf_result.BorderStyle = BorderStyle.FixedSingle;
            this.tf_result.ForeColor = System.Drawing.Color.White;
            this.tf_result.Location = new System.Drawing.Point(150, 72);
            this.tf_result.Name = "tf_result";
            this.tf_result.Size = new System.Drawing.Size(100, 20);
            this.tf_result.TabIndex = 47;
            this.tf_result.Text = "0,00€";
            this.tf_result.TextAlign = HorizontalAlignment.Center;
            // 
            // tf_productPrice
            // 
            this.tf_productPrice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tf_productPrice.BorderStyle = BorderStyle.FixedSingle;
            this.tf_productPrice.ForeColor = System.Drawing.Color.White;
            this.tf_productPrice.Location = new System.Drawing.Point(25, 72);
            this.tf_productPrice.Name = "tf_productPrice";
            this.tf_productPrice.Size = new System.Drawing.Size(100, 20);
            this.tf_productPrice.TabIndex = 46;
            this.tf_productPrice.Text = "0";
            this.tf_productPrice.TextAlign = HorizontalAlignment.Center;
            // 
            // bt_calculate
            // 
            this.bt_calculate.FlatStyle = FlatStyle.Flat;
            this.bt_calculate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_calculate.ForeColor = System.Drawing.Color.White;
            this.bt_calculate.Location = new System.Drawing.Point(25, 370);
            this.bt_calculate.Name = "bt_calculate";
            this.bt_calculate.Size = new System.Drawing.Size(124, 23);
            this.bt_calculate.TabIndex = 9;
            this.bt_calculate.Text = "LASKE";
            this.bt_calculate.UseVisualStyleBackColor = true;
            // 
            // tf_netPrice
            // 
            this.tf_netPrice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tf_netPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tf_netPrice.ForeColor = System.Drawing.Color.White;
            this.tf_netPrice.Location = new System.Drawing.Point(25, 131);
            this.tf_netPrice.Name = "tf_netPrice";
            this.tf_netPrice.Size = new System.Drawing.Size(100, 20);
            this.tf_netPrice.TabIndex = 71;
            this.tf_netPrice.Text = "0.00€";
            this.tf_netPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lb_netPrice
            // 
            this.lb_netPrice.AutoSize = true;
            this.lb_netPrice.BackColor = System.Drawing.Color.Transparent;
            this.lb_netPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_netPrice.ForeColor = System.Drawing.Color.White;
            this.lb_netPrice.Location = new System.Drawing.Point(22, 111);
            this.lb_netPrice.Name = "lb_netPrice";
            this.lb_netPrice.Size = new System.Drawing.Size(106, 17);
            this.lb_netPrice.TabIndex = 72;
            this.lb_netPrice.Text = "Veroton hinta";
            // 
            // cb_mathAlgorithmType
            // 
            this.cb_mathAlgorithmType.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.cb_mathAlgorithmType.Cursor = Cursors.Hand;
            this.cb_mathAlgorithmType.FlatStyle = FlatStyle.Flat;
            this.cb_mathAlgorithmType.ForeColor = System.Drawing.Color.White;
            this.cb_mathAlgorithmType.FormattingEnabled = true;
            this.cb_mathAlgorithmType.Location = new System.Drawing.Point(25, 12);
            this.cb_mathAlgorithmType.Name = "cb_mathAlgorithmType";
            this.cb_mathAlgorithmType.RightToLeft = RightToLeft.No;
            this.cb_mathAlgorithmType.Size = new System.Drawing.Size(194, 21);
            this.cb_mathAlgorithmType.TabIndex = 56;
            this.cb_mathAlgorithmType.Text = "Laskukaavat";
            
            this.pnl_calculatingVAT.ResumeLayout(false);
            this.pnl_calculatingVAT.PerformLayout();
            this.pnl_taxTable.ResumeLayout(false);
            this.pnl_taxTable.PerformLayout();

            return this.pnl_calculatingVAT;
        }
        #endregion

        #region Panel Visibility Control
        public bool Visible
        {
            set => pnl_calculatingVAT.Visible = value;
        }
        #endregion

        private void loadToolTipDelay()
        {
            // Tooltip displaying time...
            tooltip.AutoPopDelay = 20000;
        }

        private void LoadNetPriceTextfield(bool visible)
        {
            lb_netPrice.Visible = visible;
            tf_netPrice.Visible = visible;
        }

        private void LoadComboBoxItems()
        {
            cb_mathAlgorithmType.Items.Add("Laske tuotteen verollinen hinta");
            cb_mathAlgorithmType.Items.Add("Laske arvolisäveron määrä");

            cb_vat.Items.Add("Höydykkeet 10%");
            cb_vat.Items.Add("Elintarvikkeet 14%");
            cb_vat.Items.Add("Muut 24%");
        }

        private void VAT_Loader()
        {
            cb_vat.SelectedIndexChanged += (sender, e) =>
            {
                if(cb_vat.SelectedIndex == 0)
                {
                    current_vat = merchandise;
                }
                else if(cb_vat.SelectedIndex == 1)
                {
                    current_vat = foods;
                }
                else if(cb_vat.SelectedIndex == 2)
                {
                    current_vat = others;
                }
            };
        }

        private void cb_loadMathAlgorithm_ClickListener()
        {
            cb_mathAlgorithmType.SelectedIndexChanged += (sender, e) =>
            {
                if(cb_mathAlgorithmType.SelectedIndex == 0)
                {
                    SetCurrentFieldValues("Laske tuotteen verollinen hinta", "0 €", "0 %", "0.00€");
                    reloadDescriptionToolTip("Esimerkki 1. Juuston veroton hinta on 3,66 € ja arvonlisävero 14 %." +
                        "Laske juuston verollinen hinta.");

                    LoadNetPriceTextfield(false);
                }
                else if(cb_mathAlgorithmType.SelectedIndex == 1)
                {
                    SetCurrentFieldValues("Laske arvolisäveron määrä", "0", "0", "0.00€");
                    reloadDescriptionToolTip("Esimerkki 2. Asiakas maksaa kampaajalle 81,35 €." +
                        "Arvonlisävero on 24 %. Montako euroa asiakas maksaa arvonlisveroa.");

                    LoadNetPriceTextfield(true);
                }

                tf_reloadFields_ClickListener();
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

            tf_productPrice.Text = inputField_1;
            tf_result.Text = resultField;
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
            if(!ContainsChars.Contains(tf_productPrice.Text) &&
                !ContainSymbols.Contains(tf_productPrice.Text))
            {
                CalculationOfIncomeTax();
            }

        }

        private void CalculationOfIncomeTax()
        {
            double productPrice = Convert.ToDouble(DecimalPointer.Convert(tf_productPrice.Text));

            if(cb_mathAlgorithmType.SelectedIndex == 0)
            {
                double avt = current_vat + 100;
                avt = avt / 100;

                double result = avt * productPrice;

                tf_result.Text = result.ToString("0.00") + "€";
            }
            else if(cb_mathAlgorithmType.SelectedIndex == 1)
            {
                double avt = current_vat + 100;
                avt = avt / 100;

                double tmp_result = productPrice / avt;
                double result = productPrice - tmp_result;

                tf_result.Text = result.ToString("0.00") + "€";

                tf_netPrice.Text = (Convert.ToDouble(
                    DecimalPointer.Convert(tf_productPrice.Text)) - result).ToString("0.00") + "€";
            }
        }

        private void tf_reloadFields_ClickListener()
        {
            Textfield.LoadClearClickListener(tf_productPrice);
            //Textfield.LoadClearClickListener(tf_result);

            Textfield.LoadDoubleTabClearClickListener(tf_productPrice, inputField_1);
            //Textfield.LoadDoubleTabClearClickListener(tf_result, inputField_2);
        }

        private void tf_fields_ClickListener()
        {
            Textfield.LoadClearClickListener(tf_productPrice);
            //Textfield.LoadClearClickListener(tf_result);

            Textfield.LoadDoubleTabClearClickListener(tf_productPrice, inputField_1);
            //Textfield.LoadDoubleTabClearClickListener(tf_result, inputField_2);
        }
    }
}
