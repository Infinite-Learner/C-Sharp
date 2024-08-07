using System;
namespace CS9 {
    class ExceptionHandling{
        public static int Add(int a,int b)
        {
            if (b < 0 || a < 0)
            {
                Console.WriteLine("Argument Must be Positve");
            }
            return a + b;
            
        }
       public static void Main(string[] args) {
            try
            {
                int div = 0;
                char[] Name;
                Console.Write("Enter Name(Don't exceed 15 characters) :");
                Name = Console.ReadLine().ToCharArray();
                if (Name.Length <= 15)
                {
                    Console.Write("Welcome : ");
                    Console.WriteLine(Name);
                }
                Console.Write("Enter a number : ");
                int n = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine(n / div);
                throw new IndexOutOfRangeException();
            }
            catch (IndexOutOfRangeException)
            {
                Console.WriteLine("Name Exceed 15 Characters : ");
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Cannot Divide By Zero ");
                int a = 10, b = 20;
                int res = Add(a, -b);
                Console.WriteLine(res);
            }
            catch (NotFiniteNumberException)
            {
                Console.WriteLine("It is Not-a-Number(NAN)");
            }
            catch (ArgumentException)
            {
                Console.WriteLine("Parameter Specification Mismatch");
            }
            catch (FormatException) {
                Console.WriteLine("The Entered Input Format is incorrect");
            }
            finally
            {
                Console.WriteLine("Illustration of Exception Handling methods with Multiple catch and throw Keyword");
            }
        }
    }
}