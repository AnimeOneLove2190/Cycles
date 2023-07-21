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
            bool numberIsEasy = numberService.CheckEasyNumbers(inputNumThree);
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
        }
    }
}
