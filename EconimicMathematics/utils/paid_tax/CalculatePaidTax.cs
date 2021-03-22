using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EconimicMathematics.utils.paid_tax
{
    class CalculatePaidTax
    {
        private double grossSalary;
        private double taxRate;
        private bool operationType;

        public CalculatePaidTax(double value1, double value2, bool value3)
        {
            grossSalary = value1;
            taxRate = value2 / 100;
            operationType = value3;
        }

        // Calculate tax rate of net salary divided by gross salary...
        public double GetResult()
        {
            if(operationType)
            {
                double result = grossSalary * taxRate;

                return result;
            }
            else
            {
                taxRate = 1 - taxRate;
                double result = grossSalary * taxRate;

                return result;
            }
        }
    }
}
