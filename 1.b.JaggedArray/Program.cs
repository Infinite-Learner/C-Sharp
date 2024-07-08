using System;


namespace CS1B
{
    public class SumOfElementsInJaggedArray
    {
        static void Main(string[] args)
        {
            int sum = 0;
            int n, val, k;
            Console.Write("Enter How Many Arrays in Jagged Array : ");
            n = Convert.ToInt32(Console.ReadLine());
            int[][] jagged_array = new int[n][];
            for (int i = 0; i < jagged_array.Length; i++)
            {
                Console.Write("\nEnter How Many Elements in ({0}) - Array in Jagged Array : ", i + 1);
                k = Convert.ToInt32(Console.ReadLine());
                jagged_array[i] = new int[k];
            }
            for (int i = 0; i < jagged_array.Length; i++)
            {
                Console.WriteLine("\nEnter Elements of ({0}) - Array in Jagged Array  ", i + 1);
                for (int j = 0; j < jagged_array[i].Length; j++)
                {
                    Console.Write("     Enter Element  {0} :  ", j + 1);
                   jagged_array[i][j] = Int32.Parse(Console.ReadLine());
                    
                }
            }
            for (int i = 0; i < jagged_array.Length; i++)
            {
                val = 0;
                for (int j = 0; j < jagged_array[i].Length; j++)
                {
                    val += jagged_array[i][j];
                }
                Console.WriteLine("\nThe Sum of array ({0}) = {1}", i + 1, val);
                sum += val;
            }
            Console.WriteLine("\nThe Sum of Elements in Jagged Array is {0} \n", sum);
        }
    }
}