using EconimicMathematics.utils;
using EconimicMathematics.utils.checkbox;
using EconimicMathematics.utils.grab;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EconimicMathematics
{
    public partial class Customized : Form
    {
        double dailyHours = 0;
        double firstOvertimeHours = 0;
        double afterOvertimeHours = 0;

        double weeklySalary = 0;
        double totalSalary = 0;
        double overtimeSalary = 0;

        double taxedWeeklySalary = 0;
        double taxedTotalSalary = 0;
        double taxedOvertimeSalary = 0;

        double extraTaxedWeeklySalary = 0;
        double extraTaxedTotalSalary = 0;
        double extraTaxedOvertimeSalary = 0;

        int week = 0;

        public Customized()
        {
            InitializeComponent();

            Initialize();
        }

        private void Initialize()
        {
            Drag drag = new Drag(this, pl_navbar);
            drag.LoadFormDrag();

            loadToolTips();

            tf_fields_ClickListener();

            bt_minimizeWindowClicListener();
            bt_closeWindowClicListener();
            bt_calculateClicListener();
            bt_clearClicListener();

            lb_week.Text = week.ToString();

            SalaryType.LoadCheckboxSwitch(cb_taxSwitch, "Nettopalkka", "Bruttopalkka");
            SalaryType.LoadCheckboxSwitch(cb_taxOption, "Lisävero", "Perusvero");

            cb_taxOption.Visible = false;
            cb_hideTaxedCheckbox_ClickListener();
            cb_switchNormOrExtra_ClickListener();
        }

        private void cb_hideTaxedCheckbox_ClickListener()
        {
            cb_taxSwitch.Click += (sender, e) =>
            {
                if(!cb_taxSwitch.Checked)
                {
                    cb_taxOption.Visible = false;
                    DisplayGrossSalary();
                }
                else
                {
                    cb_taxOption.Visible = true;
                    DisplayNetSalary();
                }
            };
        }

        private void cb_switchNormOrExtra_ClickListener()
        {
            cb_taxOption.Click += (sender, e) =>
            {
                if(!cb_taxOption.Checked)
                {
                    DisplayNetSalary();
                }
                else
                {
                    DisplayExtraTaxedSalary();
                }
            };
        }

        private void bt_minimizeWindowClicListener()
        {
            bt_minimize.Click += (sender, e) =>
            {
                this.WindowState = FormWindowState.Minimized;
            };
        }

        private void bt_closeWindowClicListener()
        {
            bt_close.Click += (sender, e) =>
            {
                this.Close();
            };
        }

        private void bt_calculateClicListener()
        {
            bt_calculate.Click += (sender, e) =>
            {
                Calculate();
            };
        }

        private void bt_clearClicListener()
        {
            bt_zero.Click += (sender, e) =>
            {
                ClearFields();
            };
        }

        // Textfields tooltips...
        private void loadToolTips()
        {
            tooltip.SetToolTip(tf_monday, "Syötä Maanantain tunnit.");
            tooltip.SetToolTip(tf_thuesday, "Syötä Tiistain tunnit.");
            tooltip.SetToolTip(tf_wednesday, "Syötä Keskiviikon tunnit.");
            tooltip.SetToolTip(tf_thursday, "Syötä Torstain tunnit.");
            tooltip.SetToolTip(tf_friday, "Syötä Perjantain tunnit.");
            tooltip.SetToolTip(tf_saturday, "Syötä Lauantain tunnit.");
            tooltip.SetToolTip(tf_sunday, "Syötä Sunnuntain tunnit.");

            tooltip.SetToolTip(tf_hourlySalary, "Syötä tuntipalkka käyttäen pelkkiä numeroita sekä pistettä tai pilkkua.");
            tooltip.SetToolTip(tf_workingHours, "Syötä työaika käyttäen vain numeroita.");
            tooltip.SetToolTip(tf_taxRate, "Syötä veroprosentti käyttäen pelkkiä numeroita sekä pistettä tai pilkkua.");
            tooltip.SetToolTip(tf_extraTaxRate, "Syötä lisäveroprosentti käyttäen pelkkiä numeroita sekä pistettä tai pilkkua.");
            tooltip.SetToolTip(tf_totalWeeklyHours, "Koko viikon työtunnit.");
            tooltip.SetToolTip(tf_totalOvertimeHours, "Koko viikon ylityötunnit.");
            tooltip.SetToolTip(tf_weeklySalary, "Viikon perus palkka");
            tooltip.SetToolTip(tf_totalSalary, "Viikon kokonaispalkka.");
            tooltip.SetToolTip(tf_overtimeSalary, "Viikon ylityökorvaus osuus.");

            tooltip.SetToolTip(tf_totalWeeklyHours, "Tunnit yhteensä.");
            tooltip.SetToolTip(tf_totalOvertimeHours, "Ylityötunnit yhteensä.");

            tooltip.SetToolTip(cb_taxSwitch, "Laske palkka nettona tai bruttona.");
            tooltip.SetToolTip(cb_taxOption, "Laske palkka perus verotettuna tai lisäverotettuna.");
        }

        private void tf_fields_ClickListener()
        {
            Textfield.LoadClearClickListener(tf_monday);
            Textfield.LoadClearClickListener(tf_thuesday);
            Textfield.LoadClearClickListener(tf_wednesday);
            Textfield.LoadClearClickListener(tf_thursday);
            Textfield.LoadClearClickListener(tf_friday);
            Textfield.LoadClearClickListener(tf_saturday);
            Textfield.LoadClearClickListener(tf_sunday);
            
            Textfield.LoadDoubleTabClearClickListener(tf_monday, "Maanantai");
            Textfield.LoadDoubleTabClearClickListener(tf_thuesday, "Tiistai");
            Textfield.LoadDoubleTabClearClickListener(tf_wednesday, "Keskiviikko");
            Textfield.LoadDoubleTabClearClickListener(tf_thursday, "Torstai");
            Textfield.LoadDoubleTabClearClickListener(tf_friday, "Perjantai");
            Textfield.LoadDoubleTabClearClickListener(tf_saturday, "Lauantai");
            Textfield.LoadDoubleTabClearClickListener(tf_sunday, "Sunnuntai");


            Textfield.LoadClearClickListener(tf_hourlySalary);
            Textfield.LoadDoubleTabClearClickListener(tf_hourlySalary, "Tuntipalkka");

            Textfield.LoadClearClickListener(tf_workingHours);
            Textfield.LoadClearClickListener(tf_taxRate);
            Textfield.LoadClearClickListener(tf_extraTaxRate);

            Textfield.LoadDoubleTabClearClickListener(tf_workingHours, "0 h");
            Textfield.LoadDoubleTabClearClickListener(tf_taxRate, "12 %");
            Textfield.LoadDoubleTabClearClickListener(tf_extraTaxRate, "32 %");
        }

        // Calculate weekly salary...
        private void Calculate()
        {
            
            TextBox[] textfields = {tf_monday, tf_thuesday, tf_wednesday,
                tf_thursday, tf_friday, tf_saturday, tf_sunday};

            if(ContainsChars.Contains(tf_hourlySalary.Text))
            {
                return;
            }

            foreach(TextBox field in textfields)
            {
                if(!ContainsChars.Contains(field.Text) && !ContainSymbols.Contains(field.Text))
                {
                    double[] hours = GetHours(Convert.ToDouble(DecimalPointer.Convert(field.Text)));
                    
                    if(hours.Length == 3)
                    {
                        dailyHours += hours[0];
                        firstOvertimeHours += hours[1];
                        afterOvertimeHours += hours[2];
                    }
                    else if(hours.Length == 2)
                    {
                        dailyHours += hours[0];
                        firstOvertimeHours += hours[1];
                    }
                    else if(hours.Length == 1)
                    {
                        dailyHours += hours[0];
                    }
                }
            }


            // This is basic salary of 40hours in week for example...
            weeklySalary = dailyHours * Convert.ToDouble(DecimalPointer.Convert(tf_hourlySalary.Text));
            
            // This is total weekly hours 40hours plus next overtime hours and everything after it...
            double totalHours = dailyHours + (firstOvertimeHours * 1.5) + (afterOvertimeHours * 2);
            totalSalary = totalHours * Convert.ToDouble(DecimalPointer.Convert(tf_hourlySalary.Text));

            // This is only for overtime hours totally...
            double totalOvertimeHours = (firstOvertimeHours * 1.5) + (afterOvertimeHours * 2);
            overtimeSalary = totalOvertimeHours * Convert.ToDouble(DecimalPointer.Convert(tf_hourlySalary.Text));

            // Display weekly hours, 40 h for example
            tf_totalWeeklyHours.Text = (dailyHours + firstOvertimeHours + afterOvertimeHours).ToString();

            // Display all the overtime hours 12 for example...
            tf_totalOvertimeHours.Text = (firstOvertimeHours + afterOvertimeHours).ToString();

            // Process net salary in norm. taxed salary...
            taxedWeeklySalary = GetTaxedSalary(weeklySalary);
            taxedTotalSalary = GetTaxedSalary(totalSalary);
            taxedOvertimeSalary = GetTaxedSalary(overtimeSalary);

            // Process extra taxed salary
            extraTaxedWeeklySalary = GetExtraTaxedSalary(weeklySalary);
            extraTaxedTotalSalary = GetExtraTaxedSalary(totalSalary);
            extraTaxedOvertimeSalary = GetExtraTaxedSalary(overtimeSalary);


            if(cb_taxSwitch.Checked)
            {
                if(cb_taxOption.Checked)
                {
                    // Extra taxed salary
                    DisplayExtraTaxedSalary();
                }
                else
                {
                    // Norm. taxed salary
                    DisplayNetSalary();
                }
            }
            else
            {
                // Gross salary
                DisplayGrossSalary();
            }

            
            // Provide the number of weeks calculated hours...
            week++;
            lb_week.Text = week.ToString();
        }

        // Separate hours in three different blocks:
        // Working hours: 8 for example
        // Overtime working hours 2 for example
        // Overtime working hours after 2 hours for example
        private double[] GetHours(double hours)
        {
            double[] dailyHours;

            /*  If working hours has exceeded over 3 hours, calculate +50% and +100%
                Else if working hours has exceeded below 3 but over daily limit calculate +50%
                Else mark only working hours...
            */

            double workingHours = Convert.ToDouble(DecimalPointer.Convert(ContainsChars.Remove(tf_workingHours.Text)));

            if(hours >= Convert.ToDouble(DecimalPointer.Convert(ContainsChars.Remove(tf_workingHours.Text))) + 2)
            {
                dailyHours = new double[3];
                dailyHours[0] = Convert.ToDouble(DecimalPointer.Convert(tf_workingHours.Text));
                dailyHours[1] = 2;
                dailyHours[2] = (hours - (Convert.ToDouble(DecimalPointer.Convert(tf_workingHours.Text)))) - 2;
            }
            else if(hours >= Convert.ToDouble(DecimalPointer.Convert(tf_workingHours.Text)))
            {
                dailyHours = new double[2];
                dailyHours[0] = Convert.ToDouble(DecimalPointer.Convert(tf_workingHours.Text));
                dailyHours[1] = hours - Convert.ToDouble(DecimalPointer.Convert(tf_workingHours.Text));
            }
            else
            {
                dailyHours = new double[1];
                dailyHours[0] = hours;
            }

            return dailyHours;
        }


        // Clear all the fields and variables as in fresh start...
        private void ClearFields()
        {
            tf_monday.Text = "Maanantai";
            tf_thuesday.Text = "Tiistai";
            tf_wednesday.Text = "Keskiviikko";
            tf_thursday.Text = "Torstai";
            tf_friday.Text = "Perjantai";
            tf_saturday.Text = "Lauantai";
            tf_sunday.Text = "Sunnuntai";
            tf_hourlySalary.Text = "Tuntipalkka";

            tf_weeklySalary.Text = "0 €";
            tf_totalSalary.Text = "0 €";
            tf_overtimeSalary.Text = "0 €";

            tf_totalWeeklyHours.Text = "0 h";
            tf_totalOvertimeHours.Text = "0 h";

            tf_workingHours.Text = "0 h";

            dailyHours = 0;
            firstOvertimeHours = 0;
            afterOvertimeHours = 0;

            weeklySalary = 0;
            totalSalary = 0;
            overtimeSalary = 0;

            week = 0;
            lb_week.Text = week.ToString();
        }

        // Calculate basic tax rate
        private double GetTaxedSalary(double salary)
        {
            double taxRate = Convert.ToDouble(DecimalPointer.Convert(FilterSymbolsOff(tf_taxRate.Text)));
            taxRate = taxRate / 100;
            taxRate = 1 - taxRate;

            double result = salary * taxRate;

            return result;
        }

        // Calculate extra tax rate
        private double GetExtraTaxedSalary(double salary)
        {
            double taxRate = Convert.ToDouble(DecimalPointer.Convert(FilterSymbolsOff(tf_extraTaxRate.Text)));
            taxRate = taxRate / 100;
            taxRate = 1 - taxRate;

            double result = salary * taxRate;

            return result;
        }

        // Filter all the symbols off the input...
        private string FilterSymbolsOff(string input)
        {
            string result = "";

            if(ContainSymbols.Contains(input))
            {
                char[] charArray = input.ToCharArray();

                foreach(char ch in charArray)
                {
                    if(!ContainSymbols.Contains(ch))
                    {
                        result += ch;
                    }
                }

                return result;
            }
            else
            {
                return input;
            }
        }

        // Print gross salary...
        private void DisplayGrossSalary()
        {
            // Gross salary
            tf_weeklySalary.Text = weeklySalary.ToString("0.00") + "€";
            tf_overtimeSalary.Text = overtimeSalary.ToString("0.00") + "€";
            tf_totalSalary.Text = totalSalary.ToString("0.00") + "€";
        }

        // Print net salary...
        private void DisplayNetSalary()
        {
            // Norm. taxed salary
            tf_weeklySalary.Text = taxedWeeklySalary.ToString("0.00") + "€";
            tf_overtimeSalary.Text = taxedOvertimeSalary.ToString("0.00") + "€";
            tf_totalSalary.Text = taxedTotalSalary.ToString("0.00") + "€";
        }

        // Print net salary in exta tax rate...
        private void DisplayExtraTaxedSalary()
        {
            // Extra taxed salary
            tf_weeklySalary.Text = extraTaxedWeeklySalary.ToString("0.00") + "€";
            tf_overtimeSalary.Text = extraTaxedOvertimeSalary.ToString("0.00") + "€";
            tf_totalSalary.Text = extraTaxedTotalSalary.ToString("0.00") + "€";
        }

    }
}
