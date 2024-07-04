using System;

namespace CS5
{
    public class Overloading
    {
        public Overloading()
        {
            int a = 0;
            int b = 0;
            Console.WriteLine("The Default Constructor is Called and Memory Created ");
            Console.WriteLine("Value of a and b is initialized as ... {0},{1}", a, b);

        }
        public Overloading(int a, int b)
        {
            Console.WriteLine("The Constructor is Overloaded  : ");
            Console.WriteLine("Sum of {0} ,{1} is {2} ", a, b, a + b);
        }
        public static void Main()
        {
            Overloading obj = new Overloading();
            Overloading obj1 = new Overloading(10, 20);
        }

    }
}