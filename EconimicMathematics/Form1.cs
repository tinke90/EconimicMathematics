using EconimicMathematics.utils;
using EconimicMathematics.utils.checkbox;
using EconimicMathematics.utils.grab;
using EconimicMathematics.utils.net_salary;
using EconimicMathematics.utils.paid_tax;
using EconimicMathematics.utils.tax_rate;
using EconimicMathematics.utils.vat;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// Panel location...
// Panel Size...

namespace EconimicMathematics
{
    public partial class Form1 : Form
    {
        BasicPercentageCalculationsPanel basicPercentagePanel;
        CalculatingOfIncomeTaxPanel calculatingOfIncomeTaxPanel;
        CalculatingOfVat calculatingOfVatPanel;
        InvestmentCalculation investmentPanel;
        Loans loansPanel;

        private string inputField_1 = "";
        private string inputField_2 = "";
        private string resultField = "";


        public Form1()
        {
            InitializeComponent();

            Initialize();
        }

        private void Initialize()
        {
            LoadPanels();

            Drag drag = new Drag(this, pl_navbar);
            drag.LoadFormDrag();

            loadToolTips();

            bt_calculateTaxRate();

            tf_fields_ClickListener();

            bt_openWeeklyHourCalculator();

            tf_reloadFields_ClickListener();

            LoadBasicPercentageCalculationPanel_ClickListener();
            LoadCalculatingOfIncomeTaxPanel_ClickListener();
            LoadCalculatingOfVatPanel_ClickListener();
            LoadInvestmentPanel_ClickListener();
            LoadLoansPanel_ClickListener();

            cb_loadMathAlgorithm_ClickListener();

            LoadComboBoxItems();

            LoadInterestRateOnLoanPeriodFields(false);
        }

        private void LoadPanels()
        {
            basicPercentagePanel = new BasicPercentageCalculationsPanel(tooltip);
            pl_background.Controls.Add(basicPercentagePanel.LoadPanel());
            basicPercentagePanel.InitializeComponents();
            basicPercentagePanel.Visible = false;

            calculatingOfIncomeTaxPanel = new CalculatingOfIncomeTaxPanel(tooltip);
            pl_background.Controls.Add(calculatingOfIncomeTaxPanel.LoadPanel());
            calculatingOfIncomeTaxPanel.InitializeComponents();
            calculatingOfIncomeTaxPanel.Visible = false;

            calculatingOfVatPanel = new CalculatingOfVat(tooltip);
            pl_background.Controls.Add(calculatingOfVatPanel.LoadPanel());
            calculatingOfVatPanel.InitializeComponents();
            calculatingOfVatPanel.Visible = false;

            investmentPanel = new InvestmentCalculation(tooltip);
            pl_background.Controls.Add(investmentPanel.LoadPanel());
            investmentPanel.InitializeComponents();
            investmentPanel.Visible = false;

            loansPanel = new Loans(tooltip);
            pl_background.Controls.Add(loansPanel.LoadPanel());
            loansPanel.InitializeComponents();
            loansPanel.Visible = false;
        }

        private void ReloadPanelsVisibility(int selection)
        {
            basicPercentagePanel.Visible = false;
            calculatingOfIncomeTaxPanel.Visible = false;
            calculatingOfVatPanel.Visible = false;
            investmentPanel.Visible = false;

            switch(selection)
            {
                case 0:
                    basicPercentagePanel.Visible = true;
                    break;
                case 1:
                    calculatingOfIncomeTaxPanel.Visible = true;
                    break;
                case 2:
                    calculatingOfVatPanel.Visible = true;
                    break;
                case 3:
                    investmentPanel.Visible = true;
                    break;
                case 4:
                    loansPanel.Visible = true;
                    break;
                default:
                    break;
            }
        }

        private void LoadComboBoxItems()
        {
            cb_mathAlgorithmType.Items.Add("Koron määrä ajalta");
            cb_mathAlgorithmType.Items.Add("Laina-ajan laskeminen");
        }

        private void LoadInterestRateOnLoanPeriodFields(bool visible)
        {
            lb_interestRateOnLoanPeriod.Visible = visible;
            tf_interestRateOnLoanPeriod.Visible = visible;
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


        private void LoadBasicPercentageCalculationPanel_ClickListener()
        {
            bt_basicPercentageCalculations.Click += (sender, e) =>
            {
                ReloadPanelsVisibility(0);
            };
        }

        private void LoadCalculatingOfIncomeTaxPanel_ClickListener()
        {
            bt_calculatingOfIncomeTax.Click += (sender, e) =>
            {
                ReloadPanelsVisibility(1);
            };
        }

        private void LoadCalculatingOfVatPanel_ClickListener()
        {
            bt_calculatingOfAVT.Click += (sender, e) =>
            {
                ReloadPanelsVisibility(2);
            };
        }

        private void LoadInvestmentPanel_ClickListener()
        {
            bt_investmentCalculation.Click += (sender, e) =>
            {
                ReloadPanelsVisibility(3);
            };
        }

        private void LoadLoansPanel_ClickListener()
        {
            bt_loans.Click += (sender, e) =>
            {
                ReloadPanelsVisibility(4);
            };
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
                tf_interestRateOnLoanPeriod.Text));
            
            if(cb_mathAlgorithmType.SelectedIndex == 0)
            {
                annualIntrestRate = annualIntrestRate / 100;
                
                double result = annualIntrestRate * loan;

                result = result / timeline;

                tf_result.Text = result.ToString("0.00") + "€";
            }
            else if(cb_mathAlgorithmType.SelectedIndex == 1)
            {
                annualIntrestRate = annualIntrestRate / 100;
                
                double result = annualIntrestRate * loan;

                result = result / timeline;
                //result = Convert.ToDouble(DecimalPointer.Convert(result.ToString("0.00")));

                double _timeline = amountOfInstallment / result;

                tf_result.Text = result.ToString("0.00") + "€";
                tf_timeline.Text = _timeline.ToString("0.00") + "v";
            }
        }


        private void bt_openWeeklyHourCalculator()
        {
            bt_open_weekly_hour_calculator.Click += (sender, e) =>
            {
                Customized window = new Customized();
                window.Show();
            };
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
/*private double incomeLimit;
        private double totalIncome;
        private double basicTaxRate;
        private double extraTaxRate;

        public CalculateTotalPaidTax(double value1, double value2, double value3, double value4)
        {
            incomeLimit = value1;
            totalIncome = value2;
            basicTaxRate = value3;
            extraTaxRate = value4;
        }

        // Calculate net salary of paid tax and tax rate...
        public double GetTaxRate()
        {
            
            return 0;
        }*/