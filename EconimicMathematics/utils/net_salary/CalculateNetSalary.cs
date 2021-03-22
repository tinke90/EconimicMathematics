using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EconimicMathematics.utils.net_salary
{
    class CalculateNetSalary
    {
        
        private double paidTaxValue;
        private double taxRate;
        private bool salaryType;

        public CalculateNetSalary(double value1, double value2, bool value3)
        {
            paidTaxValue = value1;
            taxRate = value2 / 100;

            salaryType = value3;
        }

        // Calculate either net salary or gross salary by tax rate and paid tax volume...
        public double GetResult()
        {
            if(salaryType == false)
            {
                double result = paidTaxValue / taxRate;
                result = result - paidTaxValue;

                return result;
            }
            else
            {
                double result = paidTaxValue / taxRate;

                return result;
            }
        }
    }
}
