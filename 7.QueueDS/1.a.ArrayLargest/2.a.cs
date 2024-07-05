using System;
namespace CS2A
{
    class NumberReverse
        {
                public static void Main(string[] args)
                        {
                                    int n;
                                                Console.Write("Enter an Integer : ");
                                                       
                                                                   n = Int32.Parse(Console.ReadLine());
                                                                               int num = n;
                                                                                           int rev = 0;
                                                                                                       while (n != 0)
                                                                                                                   {
                                                                                                                                   rev = rev * 10 + (n % 10);
                                                                                                                                                   n /= 10;
                                                                                                                                                               }
                                                                                                                                                                           Console.WriteLine("The Reverse of Given Number {0} is : {1} ",num,rev);
                                                                                                                                                                                   }
                                                                                                                                                                                       }

                                                                                                                                                                                       }