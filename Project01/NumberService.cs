using System;
using System.Collections.Generic;
using System.Text;

namespace Project01
{
    class NumberService
    {
        //Quest01
        public int AddUpTheNumbers(int ToNumber)
        {
            int result = 0;
            for (int i = 0; i < ToNumber; i++)
            {
                result = result + i;
            }
            return result;
        }
        //Quest02
        public void WriteEvenNumbers(int inputNum)
        {
            for (int i = 0; i <= inputNum; i++)
            {
                if (i % 2 == 0)
                {
                    continue;
                }
                Console.WriteLine(i);
            }
        }
        //Quest03
        public bool IsPrimeNumber(int inputNum)
        {
            if (inputNum == 1)
            {
                return false;
            }
            if (inputNum == 2)
            {
                return true;
            }
            for (int divider = 2; divider < inputNum; divider++)
            {
                if (inputNum % divider == 0)
                {
                    return false;
                }
            }
            return true;
        }
        //Quest04
        public int AddReadNumbers(int countNumbers)
        {
            Random random = new Random();
            int result = 0;
            for (int i = 0; i < countNumbers; i++)
            {

                int numOne = random.Next(int.MinValue, int.MaxValue);
                result = result + numOne;
            }
            return result;
        }
        //Quest05
        public double AverageOfNumbers(int amountOfNumbers)
        {
            Random random = new Random();
            int added = 0;
            for (int i = 0; i < amountOfNumbers; i++)
            {

                int numOne = random.Next(int.MinValue, int.MaxValue);
                added += numOne;
            }
            double average = (double)added / (double)amountOfNumbers;
            return average;
        }
        //Quest06
        public int FindMinNumbers(int amountOfNumbers)
        {
            Random random = new Random();
            int numMin = int.MaxValue;
            for (int i = 0; i < amountOfNumbers; i++)
            {
                int currentNum = random.Next(int.MinValue, int.MaxValue);
                if (currentNum < numMin)
                {
                    numMin = currentNum;
                }
            }
            return numMin;
        }
        //Quest07
        public int FindMaxNumber(int inputNum)
        {
            Random random = new Random();
            int numMax = int.MinValue;
            for (int i = 0; i < inputNum; i++)
            {
                int numOne = random.Next(int.MinValue, int.MaxValue);
                if (numOne > numMax)
                {
                    numMax = numOne;
                }
            }
            return numMax;
        }
        //Quest08
        public int GetCountEvenNumbers(int inputNum)
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
        public int GetCountOddNumbers(int inputNum)
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
        public int GetCountPositiveNumbers(int inputNum)
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
        public int GetCountNegativeNumbers(int inputNum)
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
        public int ReverseNumber(int number)
        {
            TextService textService = new TextService();
            int CountDigits = GetCountDigits(number);
            int divider = 1;
            int result = 0;
            for (int i = 0; i < CountDigits; i++, divider *= 10)
            {
                int CurrentNum = number / divider % 10;
                result = result * 10 + CurrentNum;
            }
            return result;
        }
        public int GetCountDigits(int number)
        {
            int CountDigits = 1;
            for (; number / 10 != 0; CountDigits++)
            {
                number /= 10;
            }
            return CountDigits;
        }
        //Quest13
        public double GetDepositAmount(int depositAmount, int percentOfBank, int countMonths)
        {
            double realPercent = (double)percentOfBank / 100;
            double result = (double)depositAmount;
            for (int i = 0; i < countMonths; i++)
            {
                result = result + result * (double)realPercent;
            }
            return result;
        }
        //Quest14
        public double Exponentiate(int raisedNumber, int degree)
        {
            if (degree == 0)
            {
                return 1;
            }
            double result = (double)raisedNumber;
            if (degree > 0)
            {
                for (int i = 1; i < degree; i++)
                {
                    result = result * raisedNumber;
                }
            }
            if (degree < 0)
            {
                result = 1;
                for (int i = 0; i > degree; i--)
                {
                    result = result / (double)raisedNumber;
                }
            }
            return result;
        }
    }
}


