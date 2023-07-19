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
Dear HR Team,
I am writing to inform you of my decision to resign from my position at Bet365. Please consider this letter as my formal notice of resignation, effective August 25, 2023.

I have thoroughly enjoyed my time at Bet365 and appreciate all the opportunities and experiences I have gained during my tenure here. However, after careful consideration, I have decided to pursue a new path in my career.
I am committed to ensuring a smooth transition during my notice period. I am willing to assist with any necessary handovers or training to ensure that my responsibilities are properly delegated.
I want to express my gratitude to the entire team for their support and camaraderie throughout my time at Bet365. I have learned a great deal and will carry these valuable experiences with me in my future endeavours.
Thank you for understanding my decision. If there are any formalities or procedures I need to follow, please let me know.

Wishing you and the entire team continued success.

Kind Regards,
George Coker.

