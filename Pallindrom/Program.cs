using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter any number");
        int num = Convert.ToInt32(Console.ReadLine());  //1234
        int temp = num;
        int rev = 0, rem = 0;
        while (num > 0)  //1234, 123, 12, 1
        {
            rem = num % 10;  //1234%10=4, 123%10=3, 12%10=2, 1%10=1
            rev = rev * 10 + rem; //0+4=4, 4*10+3=43, 43*10+2=432, 432*10+1=4321
            num = num / 10; //1234/10=123, 123/10=12, 12/10=1, 1/10=0
        }
        if (temp == rev)
        {
            Console.WriteLine("Pallindrom number");
        }
        else
        {
            Console.WriteLine("Not pallindrom number");
        }
        Console.ReadKey();
    }
}

