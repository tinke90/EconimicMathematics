using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EconimicMathematics.utils
{
    class Loans
    {
        
        private string inputField_1 = "";
        private string inputField_2 = "";
        private string resultField = "";


        public Loans(ToolTip _tooltip)
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

            tf_timeline.Visible = false;
            lb_timeline.Visible = false;
        }



        private Panel pnl_loans; //
        private ToolTip tooltip; //
        private Label lb_algoritmType; //
        private TextBox tf_result; //
        private TextBox tf_loan; //
        private Button bt_calculate; //
        private Label lb_equals_1; //
        private ComboBox cb_mathAlgorithmType; //
        private Label lb_annualInterestRate; //
        private TextBox tf_annualInterestRate; //
        private Label lb_interestRateOnLoanPeriod; //
        private TextBox tf_interestRateOnLoanPeriod; //
        private Label lb_timeline; //
        private TextBox tf_timeline; //

        #region Panel Layout code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        public Panel LoadPanel()
        {
            // PANEL...
            this.pnl_loans = new Panel();
            this.lb_timeline = new Label();
            this.tf_timeline = new TextBox();
            this.lb_interestRateOnLoanPeriod = new Label();
            this.tf_interestRateOnLoanPeriod = new TextBox();
            this.lb_annualInterestRate = new Label();
            this.tf_annualInterestRate = new TextBox();
            this.lb_equals_1 = new Label();
            this.lb_algoritmType = new Label();
            this.tf_result = new TextBox();
            this.tf_loan = new TextBox();
            this.bt_calculate = new Button();
            this.cb_mathAlgorithmType = new ComboBox();
            // 
            // pnl_loans
            // 
            this.pnl_loans.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl_loans.Controls.Add(this.lb_timeline);
            this.pnl_loans.Controls.Add(this.tf_timeline);
            this.pnl_loans.Controls.Add(this.lb_interestRateOnLoanPeriod);
            this.pnl_loans.Controls.Add(this.tf_interestRateOnLoanPeriod);
            this.pnl_loans.Controls.Add(this.lb_annualInterestRate);
            this.pnl_loans.Controls.Add(this.tf_annualInterestRate);
            this.pnl_loans.Controls.Add(this.lb_equals_1);
            this.pnl_loans.Controls.Add(this.lb_algoritmType);
            this.pnl_loans.Controls.Add(this.tf_result);
            this.pnl_loans.Controls.Add(this.tf_loan);
            this.pnl_loans.Controls.Add(this.bt_calculate);
            this.pnl_loans.Controls.Add(this.cb_mathAlgorithmType);
            this.pnl_loans.ForeColor = System.Drawing.Color.Black;
            this.pnl_loans.Location = new System.Drawing.Point(12, 105);
            this.pnl_loans.Name = "pnl_loans";
            this.pnl_loans.Size = new System.Drawing.Size(868, 420);
            this.pnl_loans.TabIndex = 8;
            // 
            // lb_timeline
            // 
            this.lb_timeline.AutoSize = true;
            this.lb_timeline.BackColor = System.Drawing.Color.Transparent;
            this.lb_timeline.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_timeline.ForeColor = System.Drawing.Color.White;
            this.lb_timeline.Location = new System.Drawing.Point(22, 161);
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
            this.tf_timeline.Location = new System.Drawing.Point(25, 181);
            this.tf_timeline.Name = "tf_timeline";
            this.tf_timeline.Size = new System.Drawing.Size(100, 20);
            this.tf_timeline.TabIndex = 75;
            this.tf_timeline.Text = "12kk";
            this.tf_timeline.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lb_interestRateOnLoanPeriod
            // 
            this.lb_interestRateOnLoanPeriod.AutoSize = true;
            this.lb_interestRateOnLoanPeriod.BackColor = System.Drawing.Color.Transparent;
            this.lb_interestRateOnLoanPeriod.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_interestRateOnLoanPeriod.ForeColor = System.Drawing.Color.White;
            this.lb_interestRateOnLoanPeriod.Location = new System.Drawing.Point(147, 108);
            this.lb_interestRateOnLoanPeriod.Name = "lb_interestRateOnLoanPeriod";
            this.lb_interestRateOnLoanPeriod.Size = new System.Drawing.Size(86, 13);
            this.lb_interestRateOnLoanPeriod.TabIndex = 74;
            this.lb_interestRateOnLoanPeriod.Text = "Laina-ajan korko";
            // 
            // tf_interestRateOnLoanPeriod
            // 
            this.tf_interestRateOnLoanPeriod.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tf_interestRateOnLoanPeriod.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tf_interestRateOnLoanPeriod.ForeColor = System.Drawing.Color.White;
            this.tf_interestRateOnLoanPeriod.Location = new System.Drawing.Point(150, 128);
            this.tf_interestRateOnLoanPeriod.Name = "tf_interestRateOnLoanPeriod";
            this.tf_interestRateOnLoanPeriod.Size = new System.Drawing.Size(100, 20);
            this.tf_interestRateOnLoanPeriod.TabIndex = 73;
            this.tf_interestRateOnLoanPeriod.Text = "0,00€";
            this.tf_interestRateOnLoanPeriod.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
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
            // tf_loan
            // 
            this.tf_loan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tf_loan.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tf_loan.ForeColor = System.Drawing.Color.White;
            this.tf_loan.Location = new System.Drawing.Point(25, 73);
            this.tf_loan.Name = "tf_loan";
            this.tf_loan.Size = new System.Drawing.Size(100, 20);
            this.tf_loan.TabIndex = 46;
            this.tf_loan.Text = "0";
            this.tf_loan.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
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
            
            this.pnl_loans.ResumeLayout(false);
            this.pnl_loans.PerformLayout();
            
            return this.pnl_loans;
        }
        #endregion

        #region Panel Visibility Control
        public bool Visible
        {
            set => pnl_loans.Visible = value;
        }
        #endregion

        
        private void LoadComboBoxItems()
        {
            cb_mathAlgorithmType.Items.Add("Koron määrä ajalta");
            cb_mathAlgorithmType.Items.Add("Laina-ajan laskeminen");
        }

        private void LoadInterestRateOnLoanPeriodFields(bool visible)
        {
            lb_interestRateOnLoanPeriod.Visible = visible;
            tf_interestRateOnLoanPeriod.Visible = visible;

            tf_timeline.Visible = visible;
            lb_timeline.Visible = visible;
        }


        private void cb_loadMathAlgorithm_ClickListener()
        {
            cb_mathAlgorithmType.SelectedIndexChanged += (sender, e) =>
            {
                LoadInterestRateOnLoanPeriodFields(false);

                if(cb_mathAlgorithmType.SelectedIndex == 0)
                {
                    SetCurrentFieldValues("Koron määrä ajalta", "0 €", "0 %", "0.00€");
                    reloadDescriptionToolTip("Esimerkki 1. Mikko on ottanut lainaa 16 000 €. Lainan vuosikorko on 4,6 %." +
                        "Paljonko Mikko maksaa lainastaan korkoa ensimmäisen kuukauden aikana.");

                }
                else if(cb_mathAlgorithmType.SelectedIndex == 1)
                {
                    SetCurrentFieldValues("Laina-ajan laskeminen", "0", "0", "0.00€");
                    reloadDescriptionToolTip("Esimerkki 2. Lainan määrä on ollut 5 200 € ja vuosikorko 6,2 %." +
                        "Laske laina-aika kuukausina, kun laina-ajan korko on ollut 107,47 €.");

                    LoadInterestRateOnLoanPeriodFields(true);
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

            tf_loan.Text = inputField_1;
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
            if(!ContainsChars.Contains(tf_loan.Text) &&
                !ContainSymbols.Contains(tf_loan.Text))
            {
                CalculationOfIncomeTax();
            }

        }

        private void CalculationOfIncomeTax()
        {
            double loan = Convert.ToDouble(DecimalPointer.Convert(tf_loan.Text));
            double annualIntrestRate = Convert.ToDouble(
                DecimalPointer.Convert(RemoveSymbols.Remove(tf_annualInterestRate.Text)));
            double timeline = Convert.ToDouble(DecimalPointer.Convert(ContainsChars.Remove(tf_timeline.Text)));
            double amountOfInstallment = Convert.ToDouble(DecimalPointer.Convert(
                FilterSymbols(tf_interestRateOnLoanPeriod.Text)));

            if(cb_mathAlgorithmType.SelectedIndex == 0)
            {
                annualIntrestRate = annualIntrestRate / 100;

                double result = annualIntrestRate * loan;
                result = Convert.ToDouble(DecimalPointer.Convert(result.ToString("0.00")));

                result = result / timeline;

                tf_result.Text = result.ToString("0.00") + "€";
            }
            else if(cb_mathAlgorithmType.SelectedIndex == 1)
            {
                annualIntrestRate = annualIntrestRate / 100;

                double result = annualIntrestRate * loan;

                result = result / timeline;
                result = Convert.ToDouble(DecimalPointer.Convert(result.ToString("0.00")));

                double _timeline = amountOfInstallment / result;

                tf_result.Text = result.ToString("0.00") + "€";
                tf_timeline.Text = _timeline.ToString("0.00") + "v";
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
            Textfield.LoadClearClickListener(tf_loan);
            Textfield.LoadClearClickListener(tf_result);

            Textfield.LoadDoubleTabClearClickListener(tf_loan, inputField_1);
            Textfield.LoadDoubleTabClearClickListener(tf_result, inputField_2);
        }

        private void tf_fields_ClickListener()
        {
            Textfield.LoadClearClickListener(tf_loan);
            Textfield.LoadClearClickListener(tf_result);

            Textfield.LoadDoubleTabClearClickListener(tf_loan, inputField_1);
            Textfield.LoadDoubleTabClearClickListener(tf_result, inputField_2);
        }
    }
}
