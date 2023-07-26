using System;

namespace Project01
{
    class Program
    {
        static void Main(string[] args)
        {
            NumberService numberService = new NumberService();
            //Quest01
            int inputNumOne = int.Parse(Console.ReadLine());
            int resultAddNumbers = numberService.AddUpTheNumbers(inputNumOne);
            Console.WriteLine(resultAddNumbers);
            //Quest02
            int inputNumTwo = int.Parse(Console.ReadLine());
            numberService.WriteEvenNumbers(inputNumTwo);
            //Quest03
            int inputNumThree = int.Parse(Console.ReadLine());
            bool numberIsEasy = numberService.IsPrimeNumber(inputNumThree);
            Console.WriteLine(numberIsEasy);
            //Quest04
            int inputNumFour = int.Parse(Console.ReadLine());
            int resulAddEnteredNumbers = numberService.AddReadNumbers(inputNumFour);
            Console.WriteLine(resulAddEnteredNumbers);
            //Quest05
            int inputNumFive = int.Parse(Console.ReadLine());
            double resultAverageOfNumbers = numberService.AverageOfNumbers(inputNumFive);
            Console.WriteLine(resultAverageOfNumbers);
            //Quest06
            int inputNumSix = int.Parse(Console.ReadLine());
            int resultMinOfEnteredNumbers = numberService.FindMinNumbers(inputNumSix);
            Console.WriteLine(resultMinOfEnteredNumbers);
            //Quest07
            int inputNumSeven = int.Parse(Console.ReadLine());
            int resultMaxOfEnteredNumbers = numberService.FindMaxNumber(inputNumSeven);
            Console.WriteLine(resultMaxOfEnteredNumbers);
            //Quest08
            int inputNumEight = int.Parse(Console.ReadLine());
            int resultNumberOfEvenNumbers = numberService.GetCountEvenNumbers(inputNumEight);
            Console.WriteLine(resultNumberOfEvenNumbers);
            //Quest09
            int inputNumNine = int.Parse(Console.ReadLine());
            int resultNumberOfOddNumbers = numberService.GetCountOddNumbers(inputNumNine);
            Console.WriteLine(resultNumberOfOddNumbers);
            //Quest10
            int inputNumTen = int.Parse(Console.ReadLine());
            int resultNumberOfPositiveNumbers = numberService.GetCountPositiveNumbers(inputNumTen);
            Console.WriteLine(resultNumberOfPositiveNumbers);
            //Quest11
            int inputNumEleven = int.Parse(Console.ReadLine());
            int resultNumberOfNegativeNumbers = numberService.GetCountNegativeNumbers(inputNumEleven);
            Console.WriteLine(resultNumberOfNegativeNumbers);
            //Quest12
            int inputNumTwelve = int.Parse(Console.ReadLine());
            int resultFlipNumber = numberService.ReverseNumber(inputNumTwelve);
            Console.WriteLine(resultFlipNumber);
            //Quest13
            int firstNumber = int.Parse(Console.ReadLine());
            int percentOfBank = int.Parse(Console.ReadLine());
            int months = int.Parse(Console.ReadLine());
            double resultDebt = numberService.GetDepositAmount(firstNumber, percentOfBank, months);
            Console.WriteLine(resultDebt);
            //Quest14
            int inputNumFourteen = int.Parse(Console.ReadLine());
            int inputDegree = int.Parse(Console.ReadLine());
            double resultWhat = numberService.Exponentiate(inputNumFourteen, inputDegree);
            Console.WriteLine(resultWhat);
        }
    }
}
