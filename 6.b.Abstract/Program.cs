using System;
namespace CS6B
{
    public abstract class Abstract
    {
        public int[] a;
        public abstract void getValue(int n);
        public void show()
        {
            Console.WriteLine("Array Created and Elements are ... ");
            for (int i = 0; i < a.Length; i++)
            {
                Console.Write(" Element {0} : {1}\n", i + 1, a[i]);
            }
        }
        public class AbstractImp : Abstract
        {
            public override void getValue(int n)
            {
                a = new int[n];
                for (int i = 0; i < n; i++)
                {
                    Console.Write("Enter Element {0} : ", i + 1);
                    a[i] = Int32.Parse(Console.ReadLine());
                }
            }
        }
        public static void Main(string[] args)
        {
            AbstractImp ab = new AbstractImp();
            Console.WriteLine("Implementation of Array using Abstract Class ... ");
            Console.Write("Enter Size of Array : ");
            ab.getValue(Int32.Parse(Console.ReadLine()));
            ab.show();
        }
    }
}
