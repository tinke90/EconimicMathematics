using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EconimicMathematics.utils.paid_tax
{
    class CalculateTotalPaidTax
    {
        private double incomeLimit;
        private double totalIncome;
        private double basicTaxRate;
        private double extraTaxRate;

        public CalculateTotalPaidTax(double value1, double value2, double value3, double value4)
        {
            incomeLimit = value1;
            totalIncome = value2;
            basicTaxRate = value3 / 100;
            extraTaxRate = value4 / 100;
        }

        // Calculate net salary of paid tax and tax rate...
        public double GetResult()
        {
            double extraIncome = totalIncome - incomeLimit;
            double normalTaxed = incomeLimit * basicTaxRate;
            double extraTaxed = extraIncome * extraTaxRate;

            return normalTaxed + extraTaxed;
        }
    }
}
