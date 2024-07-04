using System;
namespace CS6A
{
    public class MOverloading {
        public void sum()
        {
            Console.WriteLine("\nDefault Method is called : ");
            int a = 10, b = 12;
            Console.WriteLine("Sum of {0} and {1} = {2} ", a, b, a + b);
        }
        public void sum(int a, int b)
        {
            Console.WriteLine("\nMethod is Overloaded by integer parameters ...: ");
            Console.WriteLine("Sum of {0} and {1} = {2} ", a, b, a + b);
        }
        public void sum(float a, float b)
        {
            Console.WriteLine("\nMethod is Overloaded by floating parameters ...: ");
            Console.WriteLine("Sum of {0:N2} and {1:N2} = {2:N2} ", a, b, a + b);
        }
    }
    public class COverloading
    {
        public COverloading()
        {
            int a = 0;
            int b = 0;
            Console.WriteLine("The Default Constructor is Called and Memory Created... ");
            Console.WriteLine("Value of a and b is initialized as ... \n{0} \n{1}", a, b);
        }
        public COverloading(int a, int b)
        {
            Console.WriteLine("\nThe Constructor is Overloaded  : ");
            Console.WriteLine("Sum of {0} and {1} = {2} ", a, b, a + b);
        }
        public COverloading(float a, double b)
        {
            Console.WriteLine("\nThe Constructor is Overloaded by Float values : ");
            Console.WriteLine("Sum of {0:N2} and {1:N2} = {2:N2} ", a, b, a + b);
        }
        public static void Main()
        {
            int ch;
            Console.WriteLine("Program to Illustrate Overloading...");
            Console.Write("\n1.Constructor Overloading...\n2.Method Overloading...\n3.Exit\nChoose to Illustrate : ");
            ch = Int32.Parse(Console.ReadLine());
                switch (ch)
                {
                    case 1:
                        COverloading co = new COverloading();
                        COverloading co1 = new COverloading(10, 20);
                        COverloading co2 = new COverloading(10.5f, 20.676f);
                        break;
                    case 2:
                       MOverloading mo = new MOverloading();
                        mo.sum();
                        mo.sum(15, 20);
                        mo.sum(10.65f, 25.55f);
                        break;
                    case 3:
                        Console.WriteLine("Thanks for Using.. :)");
                        return;
                    default:
                        Console.WriteLine("Wrong Choice ...");
                        Main();
                        break;
        }
        }

       
    }
}