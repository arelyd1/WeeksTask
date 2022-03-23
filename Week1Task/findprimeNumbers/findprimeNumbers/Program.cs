using System;
using System.Collections.Generic;

namespace findprimeNumbers
{
    class Program
    {
        static void Main(string[] args)
        {

            for (int numbers = 1; numbers <=100; numbers++)
            {
                int control = 0;

                for (int i = 2; i < numbers; i++)
                {
                    if (numbers % i ==0)
                    {
                        control = 1;
                        break;
                    }
                }
                if (control ==0)
                {
                    Console.WriteLine("{0}  The number you entered is prime.", numbers);
                }

            }
            Console.ReadKey();
        }
    }
}

