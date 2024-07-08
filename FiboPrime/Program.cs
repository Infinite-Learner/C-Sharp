using System;
namespace CS2B
{
    class FiboPrime
    {
        void Prime(int n)
        {
            int c, k = 0;
            for (int i = 1; i < n; k++)
            {
                c = 0;
                int j = 1;
                for (j = 1; j <= k; j++)
                {
                    if (k % j == 0)
                    {
                        c++;
                    }
                }
                if (c == 2)
                {
                    Console.WriteLine(k);
                    i++;
                }
            }
        }
        void Fibo(int n)
        {
            ulong n1 = 0, n2 = 1, n3;
           
            Console.WriteLine(" {0}\n {1}", n1, n2);

            for (int i = 2; i <= n; i++)
            {
                n3 = n1 + n2;
                Console.WriteLine(" " + n3);
                n1 = n2;
                n2 = n3;
            }
        }
        public static void Main(string[] args)
        {
            int n;
            Console.Write("Enter Interger to generate Fibonacci Series or Prime Number : ");
            n = Int32.Parse(Console.ReadLine());
            Console.Write("1.Fibonacci Series\n2.Prime Numbers\nChoose Option : ");
            int ch = Int32.Parse(Console.ReadLine());
            FiboPrime fb = new FiboPrime();
            switch (ch)
            {
                case 1:
                    Console.WriteLine("\n{0} Fibonacci Terms ", n);
                    fb.Fibo(n);
                    break;
                case 2:
                    Console.WriteLine("\n{0} Prime Numbers ", n);
                    fb.Prime(n);
                    break;
                default:
                    Console.WriteLine("Wrong Choice ");
                    Main(args);
                    break;
            }
        }
    }
}