using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EconimicMathematics.utils.tax_rate
{
    class CalculateTaxRate
    {
        private double netSalary;
        private double grossSalary;

        public CalculateTaxRate(double value1, double value2)
        {
            netSalary = value1;
            grossSalary = value2;
        }

        // Calculate tax rate of net salary divided by gross salary...
        public double GetResult()
        {
            double tmp = netSalary / grossSalary;
            double percent = 1 - tmp;

            return percent * 100;
        }
    }
}
