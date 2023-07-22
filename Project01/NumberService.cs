using System;
using System.Collections.Generic;
using System.Text;

namespace Project01
{
    class NumberService
    {
        //Quest01
        public int AddUpTheNumbers(int inputNum)
        {
            int result = 0;
            int numAdd = 0;
            for (int i = 0; i < inputNum; i++)
            {
                numAdd++;
                result = result + numAdd;
            }
            return result;
        }
        //Quest02
        public void WriteEvenNumbers(int inputNum)
        {
            for (int i = 0; i <= inputNum; i++)
            {
                int conditionalEven = i % 2;
                if (conditionalEven == 1)
                {
                    continue;
                }
                Console.WriteLine(i);
            }
        }
        //Quest03
        public bool CheckEasyNumbers(int inputNum)
        {
            if (inputNum == 1)
            {
                return false;
            }
            if (inputNum == 2)
            {
                return true;
            }
            int division = 0;
            int numberAdd = 2;
            for (int i = 2; i < inputNum; i++)
            {

                division = inputNum % numberAdd;
                numberAdd++;
                if (division == 0)
                {
                    break;
                }
            }
            if (!(division == 0))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        //Quest04
        public int AddReadNumbers(int inputNum)
        {
            Random random = new Random();
            int result = 0;
            for (int i = 0; i < inputNum; i++)
            {

                int numOne = random.Next(int.MinValue, int.MaxValue);
                result = result + numOne;
            }
            return result;
        }
        //Quest05
        public double AverageOfNumbers(int inputNum)
        {
            Random random = new Random();
            int added = 0;
            double average = 0;
            int numberOfNumbers = 0;
            for (int i = 0; i < inputNum; i++)
            {

                int numOne = random.Next(int.MinValue, int.MaxValue);
                numberOfNumbers++;
                added = added + numOne;
            }
            average = (double)added / (double)numberOfNumbers;
            return average;
        }
        //Quest06
        public int FindMinNumbers(int inputNum)
        {
            Random random = new Random();
            int numMin = int.MaxValue;
            int result = 0;
            for (int i = 0; i < inputNum; i++)
            {
                int numOne = random.Next(int.MinValue, int.MaxValue);
                if (numOne <= numMin)
                {
                    numMin = numOne;
                    result = numMin;
                }
            }
            return result;
        }
        //Quest07
        public int FindMaxNumber(int inputNum)
        {
            Random random = new Random();
            int numMax = int.MinValue;
            for (int i = 0; i < inputNum; i++)
            {
                int numOne = random.Next(int.MinValue, int.MaxValue);
                if (numOne >= numMax)
                {
                    numMax = numOne;
                }
            }
            return numMax;
        }
        //Quest08
        public int GetNumberOfEvenNumbers(int inputNum)
        {
            Random random = new Random();
            int numberOfNumbers = 0;
            for (int i = 0; i < inputNum; i++)
            {
                int numRandom = random.Next(int.MinValue, int.MaxValue);
                if (numRandom % 2 == 0)
                {
                    numberOfNumbers++;
                }
            }
            return numberOfNumbers;
        }
        //Quest09
        public int GetNumberOfOddNumbers(int inputNum)
        {
            Random random = new Random();
            int numberOfNumbers = 0;
            for (int i = 0; i < inputNum; i++)
            {
                int numRandom = random.Next(int.MinValue, int.MaxValue);
                if (!(numRandom % 2 == 0))
                {
                    numberOfNumbers++;
                }
            }
            return numberOfNumbers;
        }
        //Quest10
        public int GetNumberOfPositiveNumbers(int inputNum)
        {
            Random random = new Random();
            int numberOfNumbers = 0;
            for (int i = 0; i < inputNum; i++)
            {
                int numRandom = random.Next(int.MinValue, int.MaxValue);
                if (numRandom > 0)
                {
                    numberOfNumbers++;
                }
            }
            return numberOfNumbers;
        }
        //Quest11
        public int GetNumberOfNegativeNumbers(int inputNum)
        {
            Random random = new Random();
            int numberOfNumbers = 0;
            for (int i = 0; i < inputNum; i++)
            {
                int numRandom = random.Next(int.MinValue, int.MaxValue);
                if (numRandom < 0)
                {
                    numberOfNumbers++;
                }
            }
            return numberOfNumbers;
        }
        //Quest12
        public string FlipNumber(int inputNum)
        {
            TextService textService = new TextService();
            int numEnter = inputNum;
            int numberOfDigits = 1;
            for (int i = 0; i < int.MaxValue; i++, numberOfDigits++)
            {
                if (numEnter / 10 == 0)
                {
                    break;
                }
                numEnter = numEnter / 10;
            }
            int divider = 1;
            string result = "";
            for (int i = 0; i < numberOfDigits; i++, divider *= 10)
            {
                int numOne = inputNum / divider % 10;
                result = textService.AddText(result, numOne);
            }
            return result;
        }
        //Quest13
        public double GetDebt(int firstNumber, int percentOfBank, int months)
        {
            double realPercent = (double)percentOfBank / 100;
            double result = (double)firstNumber;
            for (int i = 0; i < months; i++)
            {
                result = result + result * (double)realPercent;
            }
            return result;
        }
        //Quest14
        public double GetWhat(int inputNum, int degree)
        {
            if (degree == 0)
            {
                return 1;
            }
            double result = (double)inputNum;
            if (degree > 0)
            {
                for (int i = 1; i < degree; i++)
                {
                    result = result * inputNum;
                }
            }
            if (degree < 0)
            {
                result = 1;
                for (int i = 0; i > degree; i--)
                {
                    result = result / (double)inputNum;
                }
            }
            return result;
        }
    }
}


