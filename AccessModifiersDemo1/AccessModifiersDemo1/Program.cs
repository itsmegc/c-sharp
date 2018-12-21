using System;


class Test
{
    public void hello1()
    {
        Console.WriteLine("This is public fn");
    }
    internal void hello2()
    {
        Console.WriteLine("This is internal fn");
    }
    protected void hello3()
    {
        Console.WriteLine("This is protected fn");
    }
    void hello4()
    {
        Console.WriteLine("This is private fn");
    }
}

    class Program
    {
        static void Main()
        {
           Test obj= new Test();
           obj.hello1();
           obj.hello2();

          // obj.hello3();  Error- we can not access protected member outside of class until it is not child class
           // obj.hello4(); Error- we can not access private member outside of class
           Console.ReadKey();
        }
    }

