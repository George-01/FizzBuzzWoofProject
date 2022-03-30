using System;

namespace FizzBuzzWoofProject
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");

            var objRef = new FizzSolution();
            objRef.FizzBuzzWoof(7);
        }

        
    }

    public class FizzSolution
    {
        public void FizzBuzzWoof(int inputNum)
        {
            var retVal = string.Empty;
            for (int i = inputNum; i > 2; i--)
            {
                if (i % 3 == 0)
                {
                    retVal = "Fizz";
                    Console.WriteLine(retVal);
                }
                else if (i % 5 == 0)
                {
                    retVal = "Buzz";
                    Console.WriteLine(retVal);
                }
                else if (i % 7 == 0)
                {
                    retVal = "Woof";
                    Console.WriteLine(retVal);
                }
            }
        }
    }
}
