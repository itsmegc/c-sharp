using System;

    class Program
    {
        static void Change(ref int a)
        {
            a = a + 50;  
            Console.WriteLine("The value inside change fn : " + a);
        }
        static void Main()
        {
            int a = 100;
            Console.WriteLine("This is the value inside main fn " + a);
            Change(ref a);
            Console.WriteLine("This is the value inside main fn " + a); 
           
            Console.ReadKey();

        }
    }

