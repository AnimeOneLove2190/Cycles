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
                average = (double)added / (double)numberOfNumbers;
            }
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
                    int numMax = numMin;
                    numMin = numOne;
                    numOne = numMax;
                    result = numMin;
                }
            }
            return result;
        }
    }
}

