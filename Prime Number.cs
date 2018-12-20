using System;


    class Program
    {
        static void Main()
        {
            Console.WriteLine("Enter any number");
            int num = Convert.ToInt32(Console.ReadLine());

            int temp = 0;

            for (int i = 2; i < num; i++)
            {
                if (num % i == 0)
                {
                    temp = 1;
                    break;
                }
            }
            if (temp == 1)
            {
                Console.WriteLine("Number is not prime");
            }
            else
            {
                Console.WriteLine("Number is  prime");
            }
            Console.ReadKey();
        }
    }

