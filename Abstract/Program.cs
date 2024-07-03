using System;
namespace CS5B
{
    public abstract class Abstract
    {
       public abstract void getValue(int n);
    }
     class NonAbstract : Abstract {
        public int[] a;
        public override void getValue(int n)
        {
            for (int i = 0; i < n; i++)
            {
                a[i] = Int32.Parse(Console.ReadLine());
            }
        }
    }
}