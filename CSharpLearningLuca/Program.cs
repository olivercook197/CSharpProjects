using System;
using System.Collections.Generic;
using System.Linq;

namespace CSharpLearning
{
    public class Program
    {
        static void Main(string[] args)
        {

            Calculator();

            void Calculator()
            {
                string[] digits = {"0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z" };
                int startNumber;
                int startBase;
                int desiredBase;
                int[] allData;
                int resultBase10;
                int maxPower;
                bool isNegative;
                int absStartNumber;
                

                allData = GetData();
                startNumber = allData[0];
                startBase = allData[1];
                desiredBase = allData[2];

                if(startNumber < 0)
                {
                    isNegative = true;
                }
                else
                {
                    isNegative = false;
                }

                absStartNumber = Math.Abs(startNumber);

                resultBase10 = GetResultInBase10(absStartNumber, startBase);

                maxPower = FindMaxPower(resultBase10, desiredBase);

                int[] digitsInDesiredBase = ConvertToDesiredBase(resultBase10, desiredBase, maxPower);

                Console.Write("Number in base " + desiredBase + " is ");

                if (isNegative)
                {
                    Console.Write("-");
                }

                for (int i = 0; i < digitsInDesiredBase.Length; i++)
                {
                    Console.Write(digits[digitsInDesiredBase[i]]);
                }
                Console.Read();
            }

            int[] GetData()
            {
                int startNumber;
                int startBase;
                int desiredBase;
                int absStartNumber;
                
                startNumber = EnterNumber();

                absStartNumber = Math.Abs(startNumber);

                startBase = EnterBase();

                while (CheckInputBaseIsValid(absStartNumber, startBase) == 0)
                {
                    Console.WriteLine("This number does not exist in base " + startBase);
                    startNumber = EnterNumber();
                    startBase = EnterBase();
                    absStartNumber = Math.Abs(startNumber);
                }
                
                desiredBase = EnterDesiredBase();

                int[] allData = new int[3];
                allData[0] = startNumber;
                allData[1] = startBase;
                allData[2] = desiredBase;
                return allData;

            }

            int[] ConvertToDesiredBase(int resultBase10, int desiredBase, int maxPower)
            {
                int[] digitsInDesiredBase = new int[maxPower + 1];
                int currentResult = resultBase10;

                for (int i = maxPower; i >= 0; i--)
                {
                    digitsInDesiredBase[maxPower - i] = GetDigit(desiredBase, i, currentResult);
                    currentResult = Convert.ToInt32(currentResult - (digitsInDesiredBase[maxPower - i] * 
                        Math.Pow(desiredBase, i)));
                }
                return digitsInDesiredBase;

            }

            int GetDigit(int desiredBase, int power, int currentResult)
            {
                int maxDigit = 0;
                for (int i = 0; i * Math.Pow(desiredBase, power) <= currentResult; i++)
                {
                    maxDigit = i;
                }
                return maxDigit;
            }

            int FindMaxPower(int resultBase10, int desiredBase)
            {
                int currentPower = 0;
                int maxPower = 0;
                for (int i = 0; currentPower <= resultBase10; i++)
                {
                    maxPower = i - 1;
                    currentPower = Convert.ToInt32(Math.Pow(desiredBase, i));
                }
                return maxPower;
            }

            int EnterNumber()
            {
                try
                {
                    int num;
                    Console.Write("Enter a number: ");
                    num = Convert.ToInt32(Console.ReadLine());
                    return num;
                }
                catch
                {
                    int num;
                    Console.WriteLine("Value must be an integer");
                    num = EnterNumber();
                    return num;
                    
                }
            }

            int EnterBase()
            {
                try
                {
                    int num;
                    Console.Write("Enter its base: ");
                    num = Convert.ToInt16(Console.ReadLine());
                    if (num > 1 && num < 11)
                    {
                        return num;
                    }
                    else if (num <= 1)
                    {
                        Console.WriteLine("Value must be at least 2");
                        num = EnterBase();
                        return num;
                    }
                    else
                    {
                        Console.WriteLine("Value can be a maximum of 10");
                        num = EnterBase();
                        return num;
                    }
                }
                catch
                {
                    int num;
                    Console.WriteLine("Value must be a positive integer");
                    num = EnterBase();
                    return num;
                }
            }

            int CheckInputBaseIsValid(int startNumber, int startBase )
            {
                int[] startNumberDigits;

                startNumberDigits = GetIntArray(startNumber);


                for (int i = 0; i < startNumberDigits.Length; i++)
                {
                    if (startNumberDigits[i] < startBase) { }
                    else
                    {
                        return 0;
                    }
                }
                return 1;


            }

            int EnterDesiredBase()
            {
                try
                {
                    int num;
                    Console.Write("Enter desired base: ");
                    num = Convert.ToInt32(Console.ReadLine());
                    if (num > 1 && num < 37)
                    {
                        return num;
                    }
                    else if (num <= 1)
                    {
                        Console.WriteLine("Value must be at least 2");
                        num = EnterDesiredBase();
                        return num;
                    }
                    else
                    {
                        Console.WriteLine("Value can be a maximum of 36");
                        num = EnterDesiredBase();
                        return num;
                    }
                }
                catch
                {
                    int num;
                    Console.WriteLine("Value must be a positive integer");
                    num = EnterDesiredBase();
                    return num;
                }
            }

            int[] GetIntArray(int num)
            {
                List<int> listOfInts = new List<int>();
                while (num > 0)
                {
                    listOfInts.Add(num % 10);
                    num = num / 10;
                }
                listOfInts.Reverse();
                return listOfInts.ToArray();
            }

            int GetResultInBase10(int startNumber, int startBase)
            {
                int[] startNumberDigits = GetIntArray(startNumber);
                int resultBase10 = 0;
                for (int i = startNumberDigits.Length - 1; i >= 0; i--)
                {
                    resultBase10 += Convert.ToInt32(startNumberDigits[startNumberDigits.Length - i - 1]
                        * Math.Pow(startBase, i));
                }
                return resultBase10;
            }

        }

        
    }
}
