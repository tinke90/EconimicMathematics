using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EconimicMathematics.utils
{
    class CalculatingOfIncomeTaxPanel
    {
        private string[] income_1 = null;
        private string[] income_2 = null;
        private string[] income_3 = null;
        private string[] income_4 = null;

        private double lowLimit_1 = 0;
        private double lowLimit_2 = 0;
        private double lowLimit_3 = 0;
        private double lowLimit_4 = 0;

        private double overLimit_1 = 0;
        private double overLimit_2 = 0;
        private double overLimit_3 = 0;
        private double overLimit_4 = 0;

        private double paidTax = 0;

        private double communityTax = 0;

        private string inputField_1 = "";
        private string inputField_2 = "";
        private string resultField = "";

        private double storedValue = 0;


        private Panel pnl_calculatingIncomeTax; //
        private Label lb_equals_1; //
        private Label lb_algoritmType;  //
        private TextBox tf_result;  //
        private TextBox tf_salary; //
        private Button bt_calculate; //
        private Label lb_title_3; //
        private Label lb_title_2; //
        private Label lb_title_1; //
        private TextBox tf_overLowerLimit_1; //
        private TextBox tf_lowerLimit_1; //
        private TextBox tf_taxableIncome_1; //
        private Label label1; //
        private Panel pnl_taxTable; //
        private TextBox tf_taxableIncome_4; //
        private TextBox tf_lowerLimit_4; //
        private TextBox tf_overLowerLimit_4; //
        private TextBox tf_taxableIncome_3; //
        private TextBox tf_lowerLimit_3; //
        private TextBox tf_overLowerLimit_3; //
        private TextBox tf_taxableIncome_2; //
        private TextBox tf_lowerLimit_2; //
        private TextBox tf_overLowerLimit_2; //
        private Button bt_loadTaxTable; //
        private TextBox tf_communityCharge; //
        private Label label2; //
        private Label label3; //
        private Label lb_paybackOrPayment; //
        private TextBox tf_paybackOrPayment; //
        private Label label4; //
        private TextBox tf_totalPaidTax; //
        private Label label6; //
        private TextBox tf_amountOfStateTax; //
        private Label label7; //
        private TextBox tf_amountOfCommunityCharge; //
        private ToolTip tooltip;


        public CalculatingOfIncomeTaxPanel(ToolTip _tooltip)
        {
            tooltip = _tooltip;
        }

        public void InitializeComponents()
        {
            loadToolTipDelay();
            bt_calculateTaxRate();
            bt_reloadTaxTable_ClickListener();
            tf_reloadFields_ClickListener();
            tf_fields_ClickListener();
            LoadTaxTable();
        }

        #region Panel Layout code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        public Panel LoadPanel()
        {
            // PANEL...

            this.pnl_calculatingIncomeTax = new Panel();
            this.label6 = new Label();
            this.tf_amountOfStateTax = new TextBox();
            this.label7 = new Label();
            this.tf_amountOfCommunityCharge = new TextBox();
            this.lb_paybackOrPayment = new Label();
            this.tf_paybackOrPayment = new TextBox();
            this.label4 = new Label();
            this.tf_totalPaidTax = new TextBox();
            this.label3 = new Label();
            this.tf_communityCharge = new TextBox();
            this.label2 = new Label();
            this.pnl_taxTable = new Panel();
            this.bt_loadTaxTable = new Button();
            this.tf_taxableIncome_4 = new TextBox();
            this.tf_lowerLimit_4 = new TextBox();
            this.tf_overLowerLimit_4 = new TextBox();
            this.tf_taxableIncome_3 = new TextBox();
            this.tf_lowerLimit_3 = new TextBox();
            this.tf_overLowerLimit_3 = new TextBox();
            this.tf_taxableIncome_2 = new TextBox();
            this.tf_lowerLimit_2 = new TextBox();
            this.tf_overLowerLimit_2 = new TextBox();
            this.label1 = new Label();
            this.tf_taxableIncome_1 = new TextBox();
            this.lb_title_3 = new Label();
            this.tf_lowerLimit_1 = new TextBox();
            this.lb_title_2 = new Label();
            this.tf_overLowerLimit_1 = new TextBox();
            this.lb_title_1 = new Label();
            this.lb_equals_1 = new Label();
            this.lb_algoritmType = new Label();
            this.tf_result = new TextBox();
            this.tf_salary = new TextBox();
            this.bt_calculate = new Button();
            this.pnl_calculatingIncomeTax.SuspendLayout();
            this.pnl_taxTable.SuspendLayout();
            // 
            // pnl_calculatingIncomeTax
            // 
            this.pnl_calculatingIncomeTax.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl_calculatingIncomeTax.Controls.Add(this.label6);
            this.pnl_calculatingIncomeTax.Controls.Add(this.tf_amountOfStateTax);
            this.pnl_calculatingIncomeTax.Controls.Add(this.label7);
            this.pnl_calculatingIncomeTax.Controls.Add(this.tf_amountOfCommunityCharge);
            this.pnl_calculatingIncomeTax.Controls.Add(this.lb_paybackOrPayment);
            this.pnl_calculatingIncomeTax.Controls.Add(this.tf_paybackOrPayment);
            this.pnl_calculatingIncomeTax.Controls.Add(this.label4);
            this.pnl_calculatingIncomeTax.Controls.Add(this.tf_totalPaidTax);
            this.pnl_calculatingIncomeTax.Controls.Add(this.label3);
            this.pnl_calculatingIncomeTax.Controls.Add(this.tf_communityCharge);
            this.pnl_calculatingIncomeTax.Controls.Add(this.label2);
            this.pnl_calculatingIncomeTax.Controls.Add(this.pnl_taxTable);
            this.pnl_calculatingIncomeTax.Controls.Add(this.lb_equals_1);
            this.pnl_calculatingIncomeTax.Controls.Add(this.lb_algoritmType);
            this.pnl_calculatingIncomeTax.Controls.Add(this.tf_result);
            this.pnl_calculatingIncomeTax.Controls.Add(this.tf_salary);
            this.pnl_calculatingIncomeTax.Controls.Add(this.bt_calculate);
            this.pnl_calculatingIncomeTax.ForeColor = System.Drawing.Color.Black;
            this.pnl_calculatingIncomeTax.Location = new System.Drawing.Point(12, 105);
            this.pnl_calculatingIncomeTax.Name = "pnl_calculatingIncomeTax";
            this.pnl_calculatingIncomeTax.Size = new System.Drawing.Size(868, 420);
            this.pnl_calculatingIncomeTax.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(283, 158);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 13);
            this.label6.TabIndex = 76;
            this.label6.Text = "Valtioveron määrä";
            // 
            // tf_amountOfStateTax
            // 
            this.tf_amountOfStateTax.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tf_amountOfStateTax.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tf_amountOfStateTax.ForeColor = System.Drawing.Color.White;
            this.tf_amountOfStateTax.Location = new System.Drawing.Point(286, 178);
            this.tf_amountOfStateTax.Name = "tf_amountOfStateTax";
            this.tf_amountOfStateTax.Size = new System.Drawing.Size(100, 20);
            this.tf_amountOfStateTax.TabIndex = 75;
            this.tf_amountOfStateTax.Text = "0,00€";
            this.tf_amountOfStateTax.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(283, 106);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(108, 13);
            this.label7.TabIndex = 74;
            this.label7.Text = "Kunnallisveron määrä";
            // 
            // tf_amountOfCommunityCharge
            // 
            this.tf_amountOfCommunityCharge.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tf_amountOfCommunityCharge.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tf_amountOfCommunityCharge.ForeColor = System.Drawing.Color.White;
            this.tf_amountOfCommunityCharge.Location = new System.Drawing.Point(286, 126);
            this.tf_amountOfCommunityCharge.Name = "tf_amountOfCommunityCharge";
            this.tf_amountOfCommunityCharge.Size = new System.Drawing.Size(100, 20);
            this.tf_amountOfCommunityCharge.TabIndex = 73;
            this.tf_amountOfCommunityCharge.Text = "0,00€";
            this.tf_amountOfCommunityCharge.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lb_paybackOrPayment
            // 
            this.lb_paybackOrPayment.AutoSize = true;
            this.lb_paybackOrPayment.BackColor = System.Drawing.Color.Transparent;
            this.lb_paybackOrPayment.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_paybackOrPayment.ForeColor = System.Drawing.Color.White;
            this.lb_paybackOrPayment.Location = new System.Drawing.Point(22, 211);
            this.lb_paybackOrPayment.Name = "lb_paybackOrPayment";
            this.lb_paybackOrPayment.Size = new System.Drawing.Size(118, 13);
            this.lb_paybackOrPayment.TabIndex = 72;
            this.lb_paybackOrPayment.Text = "Palautus / Lisävero";
            // 
            // tf_paybackOrPayment
            // 
            this.tf_paybackOrPayment.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tf_paybackOrPayment.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tf_paybackOrPayment.ForeColor = System.Drawing.Color.White;
            this.tf_paybackOrPayment.Location = new System.Drawing.Point(25, 231);
            this.tf_paybackOrPayment.Name = "tf_paybackOrPayment";
            this.tf_paybackOrPayment.Size = new System.Drawing.Size(100, 20);
            this.tf_paybackOrPayment.TabIndex = 71;
            this.tf_paybackOrPayment.Text = "0,00€";
            this.tf_paybackOrPayment.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(22, 158);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(127, 13);
            this.label4.TabIndex = 70;
            this.label4.Text = "Maksettu veroa yhteensä";
            // 
            // tf_totalPaidTax
            // 
            this.tf_totalPaidTax.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tf_totalPaidTax.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tf_totalPaidTax.ForeColor = System.Drawing.Color.White;
            this.tf_totalPaidTax.Location = new System.Drawing.Point(25, 178);
            this.tf_totalPaidTax.Name = "tf_totalPaidTax";
            this.tf_totalPaidTax.Size = new System.Drawing.Size(100, 20);
            this.tf_totalPaidTax.TabIndex = 69;
            this.tf_totalPaidTax.Text = "0,00€";
            this.tf_totalPaidTax.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(22, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 13);
            this.label3.TabIndex = 68;
            this.label3.Text = "Kunnallisvero";
            // 
            // tf_communityCharge
            // 
            this.tf_communityCharge.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tf_communityCharge.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tf_communityCharge.ForeColor = System.Drawing.Color.White;
            this.tf_communityCharge.Location = new System.Drawing.Point(25, 126);
            this.tf_communityCharge.Name = "tf_communityCharge";
            this.tf_communityCharge.Size = new System.Drawing.Size(100, 20);
            this.tf_communityCharge.TabIndex = 67;
            this.tf_communityCharge.Text = "0%";
            this.tf_communityCharge.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(22, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(159, 17);
            this.label2.TabIndex = 66;
            this.label2.Text = "Laske veronpalautus";
            // 
            // pnl_taxTable
            // 
            this.pnl_taxTable.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.pnl_taxTable.Controls.Add(this.bt_loadTaxTable);
            this.pnl_taxTable.Controls.Add(this.tf_taxableIncome_4);
            this.pnl_taxTable.Controls.Add(this.tf_lowerLimit_4);
            this.pnl_taxTable.Controls.Add(this.tf_overLowerLimit_4);
            this.pnl_taxTable.Controls.Add(this.tf_taxableIncome_3);
            this.pnl_taxTable.Controls.Add(this.tf_lowerLimit_3);
            this.pnl_taxTable.Controls.Add(this.tf_overLowerLimit_3);
            this.pnl_taxTable.Controls.Add(this.tf_taxableIncome_2);
            this.pnl_taxTable.Controls.Add(this.tf_lowerLimit_2);
            this.pnl_taxTable.Controls.Add(this.tf_overLowerLimit_2);
            this.pnl_taxTable.Controls.Add(this.label1);
            this.pnl_taxTable.Controls.Add(this.tf_taxableIncome_1);
            this.pnl_taxTable.Controls.Add(this.lb_title_3);
            this.pnl_taxTable.Controls.Add(this.tf_lowerLimit_1);
            this.pnl_taxTable.Controls.Add(this.lb_title_2);
            this.pnl_taxTable.Controls.Add(this.tf_overLowerLimit_1);
            this.pnl_taxTable.Controls.Add(this.lb_title_1);
            this.pnl_taxTable.Location = new System.Drawing.Point(464, 12);
            this.pnl_taxTable.Name = "pnl_taxTable";
            this.pnl_taxTable.Size = new System.Drawing.Size(391, 241);
            this.pnl_taxTable.TabIndex = 65;
            // 
            // bt_loadTaxTable
            // 
            this.bt_loadTaxTable.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_loadTaxTable.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_loadTaxTable.ForeColor = System.Drawing.Color.White;
            this.bt_loadTaxTable.Location = new System.Drawing.Point(253, 209);
            this.bt_loadTaxTable.Name = "bt_loadTaxTable";
            this.bt_loadTaxTable.Size = new System.Drawing.Size(117, 23);
            this.bt_loadTaxTable.TabIndex = 66;
            this.bt_loadTaxTable.Text = "Lataa taulukko";
            this.bt_loadTaxTable.UseVisualStyleBackColor = true;
            // 
            // tf_taxableIncome_4
            // 
            this.tf_taxableIncome_4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tf_taxableIncome_4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tf_taxableIncome_4.ForeColor = System.Drawing.Color.White;
            this.tf_taxableIncome_4.Location = new System.Drawing.Point(22, 164);
            this.tf_taxableIncome_4.Name = "tf_taxableIncome_4";
            this.tf_taxableIncome_4.Size = new System.Drawing.Size(118, 20);
            this.tf_taxableIncome_4.TabIndex = 71;
            this.tf_taxableIncome_4.Text = "74200€ - ";
            this.tf_taxableIncome_4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tf_lowerLimit_4
            // 
            this.tf_lowerLimit_4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tf_lowerLimit_4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tf_lowerLimit_4.ForeColor = System.Drawing.Color.White;
            this.tf_lowerLimit_4.Location = new System.Drawing.Point(155, 164);
            this.tf_lowerLimit_4.Name = "tf_lowerLimit_4";
            this.tf_lowerLimit_4.Size = new System.Drawing.Size(100, 20);
            this.tf_lowerLimit_4.TabIndex = 72;
            this.tf_lowerLimit_4.Text = "10156,25 €";
            this.tf_lowerLimit_4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tf_overLowerLimit_4
            // 
            this.tf_overLowerLimit_4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tf_overLowerLimit_4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tf_overLowerLimit_4.ForeColor = System.Drawing.Color.White;
            this.tf_overLowerLimit_4.Location = new System.Drawing.Point(270, 164);
            this.tf_overLowerLimit_4.Name = "tf_overLowerLimit_4";
            this.tf_overLowerLimit_4.Size = new System.Drawing.Size(100, 20);
            this.tf_overLowerLimit_4.TabIndex = 73;
            this.tf_overLowerLimit_4.Text = "31,25 %";
            this.tf_overLowerLimit_4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tf_taxableIncome_3
            // 
            this.tf_taxableIncome_3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tf_taxableIncome_3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tf_taxableIncome_3.ForeColor = System.Drawing.Color.White;
            this.tf_taxableIncome_3.Location = new System.Drawing.Point(22, 138);
            this.tf_taxableIncome_3.Name = "tf_taxableIncome_3";
            this.tf_taxableIncome_3.Size = new System.Drawing.Size(118, 20);
            this.tf_taxableIncome_3.TabIndex = 68;
            this.tf_taxableIncome_3.Text = "42400€ - 74200€";
            this.tf_taxableIncome_3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tf_lowerLimit_3
            // 
            this.tf_lowerLimit_3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tf_lowerLimit_3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tf_lowerLimit_3.ForeColor = System.Drawing.Color.White;
            this.tf_lowerLimit_3.Location = new System.Drawing.Point(155, 138);
            this.tf_lowerLimit_3.Name = "tf_lowerLimit_3";
            this.tf_lowerLimit_3.Size = new System.Drawing.Size(100, 20);
            this.tf_lowerLimit_3.TabIndex = 69;
            this.tf_lowerLimit_3.Text = "3398,75 €";
            this.tf_lowerLimit_3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tf_overLowerLimit_3
            // 
            this.tf_overLowerLimit_3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tf_overLowerLimit_3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tf_overLowerLimit_3.ForeColor = System.Drawing.Color.White;
            this.tf_overLowerLimit_3.Location = new System.Drawing.Point(270, 138);
            this.tf_overLowerLimit_3.Name = "tf_overLowerLimit_3";
            this.tf_overLowerLimit_3.Size = new System.Drawing.Size(100, 20);
            this.tf_overLowerLimit_3.TabIndex = 70;
            this.tf_overLowerLimit_3.Text = "21,25 %";
            this.tf_overLowerLimit_3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tf_taxableIncome_2
            // 
            this.tf_taxableIncome_2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tf_taxableIncome_2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tf_taxableIncome_2.ForeColor = System.Drawing.Color.White;
            this.tf_taxableIncome_2.Location = new System.Drawing.Point(22, 112);
            this.tf_taxableIncome_2.Name = "tf_taxableIncome_2";
            this.tf_taxableIncome_2.Size = new System.Drawing.Size(118, 20);
            this.tf_taxableIncome_2.TabIndex = 65;
            this.tf_taxableIncome_2.Text = "25700€ - 42400€";
            this.tf_taxableIncome_2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tf_lowerLimit_2
            // 
            this.tf_lowerLimit_2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tf_lowerLimit_2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tf_lowerLimit_2.ForeColor = System.Drawing.Color.White;
            this.tf_lowerLimit_2.Location = new System.Drawing.Point(155, 112);
            this.tf_lowerLimit_2.Name = "tf_lowerLimit_2";
            this.tf_lowerLimit_2.Size = new System.Drawing.Size(100, 20);
            this.tf_lowerLimit_2.TabIndex = 66;
            this.tf_lowerLimit_2.Text = "518,00 €";
            this.tf_lowerLimit_2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tf_overLowerLimit_2
            // 
            this.tf_overLowerLimit_2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tf_overLowerLimit_2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tf_overLowerLimit_2.ForeColor = System.Drawing.Color.White;
            this.tf_overLowerLimit_2.Location = new System.Drawing.Point(270, 112);
            this.tf_overLowerLimit_2.Name = "tf_overLowerLimit_2";
            this.tf_overLowerLimit_2.Size = new System.Drawing.Size(100, 20);
            this.tf_overLowerLimit_2.TabIndex = 67;
            this.tf_overLowerLimit_2.Text = "17,25 %";
            this.tf_overLowerLimit_2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(41, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(202, 17);
            this.label1.TabIndex = 64;
            this.label1.Text = "Vuoden 2019 verotaulukko";
            // 
            // tf_taxableIncome_1
            // 
            this.tf_taxableIncome_1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tf_taxableIncome_1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tf_taxableIncome_1.ForeColor = System.Drawing.Color.White;
            this.tf_taxableIncome_1.Location = new System.Drawing.Point(22, 86);
            this.tf_taxableIncome_1.Name = "tf_taxableIncome_1";
            this.tf_taxableIncome_1.Size = new System.Drawing.Size(118, 20);
            this.tf_taxableIncome_1.TabIndex = 58;
            this.tf_taxableIncome_1.Text = "17200€ - 25700€";
            this.tf_taxableIncome_1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lb_title_3
            // 
            this.lb_title_3.BackColor = System.Drawing.Color.Transparent;
            this.lb_title_3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_title_3.ForeColor = System.Drawing.Color.White;
            this.lb_title_3.Location = new System.Drawing.Point(271, 39);
            this.lb_title_3.Name = "lb_title_3";
            this.lb_title_3.Size = new System.Drawing.Size(100, 44);
            this.lb_title_3.TabIndex = 63;
            this.lb_title_3.Text = "Vero alarajan ylittävästä tulon osasta";
            // 
            // tf_lowerLimit_1
            // 
            this.tf_lowerLimit_1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tf_lowerLimit_1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tf_lowerLimit_1.ForeColor = System.Drawing.Color.White;
            this.tf_lowerLimit_1.Location = new System.Drawing.Point(155, 86);
            this.tf_lowerLimit_1.Name = "tf_lowerLimit_1";
            this.tf_lowerLimit_1.Size = new System.Drawing.Size(100, 20);
            this.tf_lowerLimit_1.TabIndex = 59;
            this.tf_lowerLimit_1.Text = "8,00 €";
            this.tf_lowerLimit_1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lb_title_2
            // 
            this.lb_title_2.BackColor = System.Drawing.Color.Transparent;
            this.lb_title_2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_title_2.ForeColor = System.Drawing.Color.White;
            this.lb_title_2.Location = new System.Drawing.Point(156, 52);
            this.lb_title_2.Name = "lb_title_2";
            this.lb_title_2.Size = new System.Drawing.Size(100, 31);
            this.lb_title_2.TabIndex = 62;
            this.lb_title_2.Text = "Vero alarajan kohdalla";
            // 
            // tf_overLowerLimit_1
            // 
            this.tf_overLowerLimit_1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tf_overLowerLimit_1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tf_overLowerLimit_1.ForeColor = System.Drawing.Color.White;
            this.tf_overLowerLimit_1.Location = new System.Drawing.Point(270, 86);
            this.tf_overLowerLimit_1.Name = "tf_overLowerLimit_1";
            this.tf_overLowerLimit_1.Size = new System.Drawing.Size(100, 20);
            this.tf_overLowerLimit_1.TabIndex = 60;
            this.tf_overLowerLimit_1.Text = "6,00 %";
            this.tf_overLowerLimit_1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lb_title_1
            // 
            this.lb_title_1.BackColor = System.Drawing.Color.Transparent;
            this.lb_title_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_title_1.ForeColor = System.Drawing.Color.White;
            this.lb_title_1.Location = new System.Drawing.Point(22, 51);
            this.lb_title_1.Name = "lb_title_1";
            this.lb_title_1.Size = new System.Drawing.Size(119, 32);
            this.lb_title_1.TabIndex = 61;
            this.lb_title_1.Text = "Verotettava ansiotulo";
            // 
            // lb_equals_1
            // 
            this.lb_equals_1.BackColor = System.Drawing.Color.Transparent;
            this.lb_equals_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_equals_1.ForeColor = System.Drawing.Color.White;
            this.lb_equals_1.Location = new System.Drawing.Point(125, 38);
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
            this.lb_algoritmType.Location = new System.Drawing.Point(22, 18);
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
            this.tf_result.Location = new System.Drawing.Point(150, 38);
            this.tf_result.Name = "tf_result";
            this.tf_result.Size = new System.Drawing.Size(100, 20);
            this.tf_result.TabIndex = 47;
            this.tf_result.Text = "0,00€";
            this.tf_result.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tf_salary
            // 
            this.tf_salary.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tf_salary.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tf_salary.ForeColor = System.Drawing.Color.White;
            this.tf_salary.Location = new System.Drawing.Point(25, 38);
            this.tf_salary.Name = "tf_salary";
            this.tf_salary.Size = new System.Drawing.Size(100, 20);
            this.tf_salary.TabIndex = 46;
            this.tf_salary.Text = "0";
            this.tf_salary.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
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
            
            this.pnl_calculatingIncomeTax.ResumeLayout(false);
            this.pnl_calculatingIncomeTax.PerformLayout();
            this.pnl_taxTable.ResumeLayout(false);
            this.pnl_taxTable.PerformLayout();
            

            return pnl_calculatingIncomeTax;
        }

        #endregion

        #region Panel Visibility Control
        public bool Visible
        {
            set => pnl_calculatingIncomeTax.Visible = value;
        }
        #endregion

        private void loadToolTipDelay()
        {
            // Tooltip displaying time...
            tooltip.AutoPopDelay = 20000;
        }

        private void LoadTaxTable()
        {
            income_1 = FilterTaxTable(tf_taxableIncome_1.Text);
            income_2 = FilterTaxTable(tf_taxableIncome_2.Text);
            income_3 = FilterTaxTable(tf_taxableIncome_3.Text);
            income_4 = FilterTaxTable(tf_taxableIncome_4.Text);

            lowLimit_1 = Convert.ToDouble(FilterSymbols(tf_lowerLimit_1.Text));
            lowLimit_2 = Convert.ToDouble(FilterSymbols(tf_lowerLimit_2.Text));
            lowLimit_3 = Convert.ToDouble(FilterSymbols(tf_lowerLimit_3.Text));
            lowLimit_4 = Convert.ToDouble(FilterSymbols(tf_lowerLimit_4.Text));

            overLimit_1 = Convert.ToDouble(FilterSymbols(tf_overLowerLimit_1.Text));
            overLimit_2 = Convert.ToDouble(FilterSymbols(tf_overLowerLimit_2.Text));
            overLimit_3 = Convert.ToDouble(FilterSymbols(tf_overLowerLimit_3.Text));
            overLimit_4 = Convert.ToDouble(FilterSymbols(tf_overLowerLimit_4.Text));
            Console.WriteLine(income_1.Length);
        }

        private void ReloadTaxTable()
        {
            LoadTaxTable();
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

        private void bt_reloadTaxTable_ClickListener()
        {
            bt_loadTaxTable.Click += (sender, e) =>
            {
                ReloadTaxTable();
            };
        }

        private void Calculate()
        {
            // Calculate percentage of the number...
            if(!ContainsChars.Contains(tf_salary.Text) &&
                !ContainSymbols.Contains(tf_salary.Text))
            {
                CalculationOfIncomeTax();
            }

        }

        private void CheckIfPaybackOrExtraPayment(double value)
        {
            double tax = Convert.ToDouble(DecimalPointer.Convert(RemoveSymbols.Remove(tf_communityCharge.Text)));
            tax = tax / 100;

            double salary = Convert.ToDouble(DecimalPointer.Convert(tf_salary.Text));

            double communityCharge = tax * salary;

            double taxTableValue = value;

            double totalTax = communityCharge + taxTableValue;

            double paidTaxes = Convert.ToDouble(DecimalPointer.Convert(RemoveSymbols.Remove(tf_totalPaidTax.Text)));

            if(paidTaxes < 1)
            {
                tf_totalPaidTax.Text = totalTax.ToString("0.00") + "€";
            }
            else
            {
                paidTaxes = Convert.ToDouble(DecimalPointer.Convert(RemoveSymbols.Remove(tf_totalPaidTax.Text)));
            }


            double result = paidTaxes - totalTax;

            if(result < 0)
            {
                lb_paybackOrPayment.Text = "Lisävero";
                result = -1 * result;
            }
            else
            {
                lb_paybackOrPayment.Text = "Palautus";
            }

            tf_amountOfStateTax.Text = taxTableValue.ToString("0.00") + "€";
            tf_amountOfCommunityCharge.Text = communityCharge.ToString("0.00") + "€";
            tf_paybackOrPayment.Text = result.ToString("0.00") + "€";
        }

        private void CalculationOfIncomeTax()
        {
            double salary = Convert.ToDouble(DecimalPointer.Convert(tf_salary.Text));

            CheckTaxTable(salary);
        }

        private void CheckTaxTable(double salary)
        {
            if(salary <= Convert.ToDouble(income_1[0]))
            {
                CheckIfPaybackOrExtraPayment(lowLimit_1);

                tf_result.Text = lowLimit_1.ToString("0.00") + "€";
            }
            else if(salary > Convert.ToDouble(income_1[0]) && salary <= Convert.ToDouble(income_1[1]))
            {
                double overLimited = Convert.ToDouble(
                    DecimalPointer.Convert(tf_salary.Text)) - Convert.ToDouble(income_1[0]);
                double tax = overLimit_1 / 100;
                double taxed = tax * overLimited;

                CheckIfPaybackOrExtraPayment(lowLimit_1 + taxed);

                tf_result.Text = (lowLimit_1 + taxed).ToString("0.00") + "€";
            }
            else if(salary <= Convert.ToDouble(income_2[0]))
            {
                CheckIfPaybackOrExtraPayment(lowLimit_2);

                tf_result.Text = lowLimit_2.ToString("0.00") + "€";
            }
            else if(salary > Convert.ToDouble(income_2[0]) && salary <= Convert.ToDouble(income_2[1]))
            {
                double overLimited = Convert.ToDouble(
                    DecimalPointer.Convert(tf_salary.Text)) - Convert.ToDouble(income_2[0]);
                double tax = overLimit_2 / 100;
                double taxed = tax * overLimited;

                CheckIfPaybackOrExtraPayment(lowLimit_2 + taxed);

                tf_result.Text = (lowLimit_2 + taxed).ToString("0.00") + "€";
            }
            else if(salary <= Convert.ToDouble(income_3[0]))
            {
                CheckIfPaybackOrExtraPayment(lowLimit_3);

                tf_result.Text = lowLimit_3.ToString("0.00") + "€";
            }
            else if(salary > Convert.ToDouble(income_3[0]) && salary <= Convert.ToDouble(income_3[1]))
            {
                double overLimited = Convert.ToDouble(
                    DecimalPointer.Convert(tf_salary.Text)) - Convert.ToDouble(income_3[0]);
                double tax = overLimit_3 / 100;
                double taxed = tax * overLimited;

                CheckIfPaybackOrExtraPayment(lowLimit_2 + taxed);

                tf_result.Text = (lowLimit_3 + taxed).ToString("0.00") + "€";
            }
            else if(salary > Convert.ToDouble(income_4[0]))
            {
                double overLimited = Convert.ToDouble(
                    DecimalPointer.Convert(tf_salary.Text)) - Convert.ToDouble(income_4[0]);
                double tax = overLimit_4 / 100;
                double taxed = tax * overLimited;

                CheckIfPaybackOrExtraPayment(lowLimit_2 + taxed);

                tf_result.Text = (lowLimit_4 + taxed).ToString("0.00") + "€";
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

        private string[] FilterTaxTable(string value)
        {
            string[] split = value.Split('-');

            char[] tmp_split_1 = split[0].ToCharArray();
            char[] tmp_split_2 = split[1].ToCharArray();

            string firstValue = ReSetValue(tmp_split_1);
            string secondValue = ReSetValue(tmp_split_2);

            string[] values = { firstValue, secondValue };

            return values;
        }

        private string ReSetValue(char[] list)
        {
            string value = "";

            foreach(char ch in list)
            {
                if(!ContainSymbols.Contains(ch) && !ContainsChars.Contains(ch))
                {
                    value += ch;
                }
            }

            return value;
        }


        private void tf_reloadFields_ClickListener()
        {
            Textfield.LoadClearClickListener(tf_salary);
            Textfield.LoadClearClickListener(tf_result);

            Textfield.LoadDoubleTabClearClickListener(tf_salary, inputField_1);
            Textfield.LoadDoubleTabClearClickListener(tf_result, inputField_2);
        }

        private void tf_fields_ClickListener()
        {
            Textfield.LoadClearClickListener(tf_salary);
            Textfield.LoadClearClickListener(tf_result);

            Textfield.LoadDoubleTabClearClickListener(tf_salary, inputField_1);
            Textfield.LoadDoubleTabClearClickListener(tf_result, inputField_2);
        }

        private void reloadDescriptionToolTip(string value)
        {
            tooltip.SetToolTip(lb_algoritmType, value);
        }


    }
}
