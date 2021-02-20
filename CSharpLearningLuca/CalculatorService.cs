using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpLearning
{
    public class CalculatorService
    {
        public double ECalculator(double baseNum, double powNum)
        {
                double answer;
                answer = GetPow(baseNum, powNum);

            return answer;

        }

        public double GetPow(double baseNum, double powNum)
        {
            double result = 1;
            if (powNum >= 0)
            {
                for (double i = 0; i < powNum; i++)
                {
                    result = result * baseNum;
                }
            }
            else
            {
                powNum = -powNum;
                for (double i = 0; i < powNum; i++)
                {
                    result = result * baseNum;
                }
                result = 1 / result;
            }

            return result;
        }

        public double GetBaseNum()
        {
            double baseNum;
            string baseTry;

            bool tryAgain = true;

            while (tryAgain)
            {
                Console.Write("Enter a base (to exit enter 0): ");
                baseTry = Console.ReadLine();
                try
                {
                    baseNum = Convert.ToDouble(baseTry);
                    tryAgain = false;
                    baseNum = Convert.ToDouble(baseTry);
                    return baseNum;
                }
                catch (Exception e)
                {
                    Console.WriteLine("Invalid entry");

                }
            }
            return 1;


        }
        public double GetPowerNum()
        {
            double powerNum;
            string powerTry;

            bool tryAgain = true;

            while (tryAgain)
            {
                Console.Write("Enter a power: ");
                powerTry = Console.ReadLine();
                try
                {
                    powerNum = Convert.ToDouble(powerTry);
                    tryAgain = false;
                    powerNum = Convert.ToDouble(powerTry);
                    return powerNum;
                }
                catch (Exception e)
                {
                    Console.WriteLine("Invalid entry");

                }
            }
            return 1;

        }
    }
}
