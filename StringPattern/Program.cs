using System;
namespace CS4
{
    public class StringPattern {
        public static void Main()
        {
            string s = "123456789";
            int k = 1;
            for (int i = 0; i < (s.Length + 1) / 2; i++)
            {
                for (int j = i; j < 2*s.Length; j++)
                {
                    if (j <= 2 * i)
                    {
                        k = s[j] - '0';
                        Console.Write(k + " ");
                    }
                    else
                    {
                        --k;
                        if (k > i)
                        {
                            Console.Write(k + " ");
                        }
                    }  
                }
                Console.WriteLine();
            }
        }
    }
}