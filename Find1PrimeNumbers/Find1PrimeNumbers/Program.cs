using System;

namespace Find1PrimeNumbers
{
    class Program
    {
        static void Main(string[] args)
        {


            int Numbers = 0;
            Console.WriteLine("Enter the numbers: ");
            int Number = Convert.ToInt32(Console.ReadLine());
            for (int i = 2; i < Number; i++)
            {
                if (Number % i == 0)
                {
                    Numbers++;
                }
            }
            if (Numbers == 0)
            {
                Console.WriteLine("The number you entered is prime.");
            }
            else
            {
                Console.WriteLine("The number you entered is not prime.");
            }
            Console.ReadKey();



        }
    }
}
