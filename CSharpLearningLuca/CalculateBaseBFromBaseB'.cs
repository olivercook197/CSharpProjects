using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpLearning
{
    class CalculateBaseBFromBaseB_
    {

        public void Calculator()
        {
            string[] digits = { "1", "2", "3", "4", "5", "6", "7", "8", "9", "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z" };
            int startNumber;
            int startBase;

            
            startNumber = EnterNumber();
            Console.WriteLine(startNumber);

            Console.Write("Enter a number");
            startNumber = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter its base");
            startNumber = Convert.ToInt32(Console.ReadLine());

        }


        private int EnterNumber()
        {
            try
            {
                int num;
                Console.Write("Enter a number");
                num = Convert.ToInt32(Console.ReadLine());
                return num;
            }
            catch
            {
                Console.WriteLine("Value must be an integer");
                EnterNumber();
            }
            return 1;
            
        }

        


    }
}
