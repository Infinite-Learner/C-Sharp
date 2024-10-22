using System;
namespace CS1A
{
    class ArrayLargest
    {
        int large(int[] a, int n)
        {
            int large = a[0];
            for (int i = 1; i < n; i++)
            {
                if (a[i] > large)
                    large = a[i];
            }
            return large;
        }
        float avg(int[] a, int n)
        {
            float avg = 0;
            for (int i = 0; i < n; i++)
                avg += a[i];
            avg /= n;
            return avg;
        }
        public static void Main()
        {
            ArrayLargest obj = new ArrayLargest();
            int n;
            float large, avg;
            int[] a = new int[50];
            Console.Write("Enter the size of Array : ");
            string s, s1;
            s = Console.ReadLine();
            n = Int32.Parse(s);
            Console.WriteLine("Enter the array elements");
            for (int i = 0; i < n; i++)
            {
                s1 = Console.ReadLine();
                a[i] = Int32.Parse(s1);
            }
            Console.Write("");
            large = obj.large(a, n);
            avg = obj.avg(a, n);
            Console.WriteLine("Largest element in the given array is {0}", large);
            Console.WriteLine("Average of elements in the given array is {0}", avg);
        }
    }

}