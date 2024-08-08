using System;
namespace CS9 {
    class ExceptionHandling{
        public static object Add(int a,int b)
        {
            int sum = 0;
            if (a == 0 && b == 0)
            {
                ArgumentException e = new ArgumentException("any one paramters value should be 1 or greater");
                return e;
            }
            sum = a + b;
            return sum;
        }
       public static void Main(string[] args) {
            try
            {
                char[] Name = new char[15];
                int m=0, n=0;
                Console.Write("Enter Name(Don't exceed 15 characters) :");
                Name = Console.ReadLine().ToCharArray();
                if (Name.Length > 15)
                {
                    throw new IndexOutOfRangeException();
                }
                Console.Write("Welcome : ");
                Console.WriteLine(Name);
                Console.Write("Enter a number 1 : ");
                n = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter a number 2 : ");
                m = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("The Sum Of {0}+{1} : {2}", m, n, Add(m, n));
                Console.Write("The {0}/0 Divided by 0 goes : ",m);
                Console.WriteLine(m / 0);

                
            }
            catch (IndexOutOfRangeException)
            {
                Console.WriteLine("Name Exceed 15 Characters : ");
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine(new DivideByZeroException("Cannot Divide By Zero "));
            }
            catch (NotFiniteNumberException)
            {
                Console.WriteLine("It is Not-a-Number(NAN)");
            }
            catch (FormatException) {
              Console.WriteLine("The Entered Input Format is invalid");
            }
            finally
            {
                Console.WriteLine("Illustration of Exception Handling methods with\n1.throw Keyword\n2.try-catch block\n3.finally");
            }
        }
    }
}