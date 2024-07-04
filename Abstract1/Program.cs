using System;

namespace CS5B
{
    public abstract class Abstract
    {
        public int[]a;
        public abstract void getValue(int n);
        public void show()
        {
            for (int i = 0; i < a.Length; i++)
            {
                Console.WriteLine("Element {0} : {1} ", i + 1, a[i]);
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
                    int val = Int32.Parse(Console.ReadLine());
                    a[i] = val;
                }
            }
        }
        public static void Main(string[] args)
        {
            AbstractImp ab = new AbstractImp();
            Console.WriteLine("Implementation of Array using Abstract Class ... ");
            Console.Write("Enter Size of Array : ");
            int n = Int32.Parse(Console.ReadLine());
            ab.getValue(n);
            ab.show();
        }
    }
}