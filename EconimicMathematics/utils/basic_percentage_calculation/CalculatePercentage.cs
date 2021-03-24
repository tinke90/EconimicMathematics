using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EconimicMathematics.utils
{
    class CalculatePercentage
    {
        
        // Calculate percentage of the number...
        public double CalculatePercentageOfNumber(double percentage, double value)
        {
            percentage = GetPercentage(percentage);

            double result = percentage * value;

            return result;
        }

        // Calculate how many percent X is of the Y...
        public double CalculateHowManyPercent(double value1, double value2)
        {
            double percent = value1 / value2;
            
            return percent * 100;
        }

        // Calculate the original value...
        public double CalculateOriginalValue(double percentage, double value)
        {
            double result = value / percentage;

            return result * 100;
        }

        // Calculate discounted price...
        public double CalculateDiscountPrice(double percentage, double value)
        {
            percentage = GetPercentage(percentage);
            double result = percentage * value;

            return result;
        }

        public double ComputingApplications(double percentage, double value)
        {
            percentage = GetPercentage(percentage);
            percentage = 1 - percentage;
            
            double result = value / percentage;

            return result;
        }

        public double CalculatingSuccessiveChanges(double percentage, double value)
        {
            percentage = GetPercentage(percentage);
            percentage = 1 - percentage;

            double result = percentage * value;

            return result;
        }

        public double CalculatingPercentageChanges(double value1, double value2)
        {
            double halfResult = value1 - value2;
            double result = halfResult / value2;
            
            return result * 100;
        }

        public double CalculatingOfTheIncrease(double percentage, double value)
        {
            percentage = GetPercentage(100 + percentage);
            percentage = percentage;

            double result = percentage * value;

            return result;
        }

        public double CalculatingReferencePercentage(double value1, double value2)
        {
            double halfResult = value1 - value2;
            double result = halfResult / value1;

            return result * 100;
        }

        public double SalaryCalculation(double percentage, double value)
        {
            percentage = GetPercentage(percentage);
            percentage = 1 - percentage;

            double result = percentage * value;

            return result;
        }

        public double CalculateTaxRate(double value1, double value2)
        {
            double result = value1 / value2;
            result = 1 - result;

            return result * 100;
        }

        public double PriceIncrease(double value, double percentage)
        {
            percentage = percentage + 100;
            percentage = GetPercentage(percentage);
            

            double result = value / percentage;

            return result;
        }

        public double PriceReduction(double value, double percentage)
        {
            percentage = GetPercentage(percentage);
            percentage = 1 - percentage;

            double result = percentage * value;

            return result;
        }


        // Get generated percentage...
        private double GetPercentage(double percent)
        {
            percent = percent / 100;

            return percent;
        }

        
    }
}
