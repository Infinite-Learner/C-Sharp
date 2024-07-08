using System;
namespace CS3
{
    public class Stack
    {
        static readonly int MAX = 100;
        int[] stack = new int[MAX];
        int top;
        bool isStackEmpty()
        {
            return (top < 0);
        }
        public Stack()
        {
            top -= 1;
        }
        internal bool Push(int data)
        {
            if (top >= MAX)
            {
                Console.WriteLine("\nStack Overflow");
                return false;
            }
            else
            {
                stack[++top] = data;
                Console.WriteLine("\n{0} --> pushed into stack ", data);
                return true;
            }
        }
        internal int Pop()
        {
            if (top < 0)
            {
                Console.WriteLine("\nStack Underflow");
                return 0;
            }
            else
            {
                int value = stack[top--];
                return value;
            }
        }
        internal void Peek()
        {
            if (top < 0)
            {
                Console.WriteLine("\nStack Underflow");
                return;
            }
            else
            {
                Console.WriteLine("\nThe topmost element of the stack - {0} .\n", stack[top]);
                return;
            }
        }
        internal void PrintStack()
        {
            if (top < 0)
            {
                Console.WriteLine("\nStack Underflow");
                return;
            }
            else
            {
                Console.WriteLine("\nElements in Stack are ...");
                for (int i = top; i >= 0; i--)
                {
                    Console.WriteLine(stack[i] + "\n");
                }
            }
        }
        internal int Menu()
        {
            Console.WriteLine("\nStack Operations..\n1.Push\n2.Pop\n3.Peek\n4.Allelements\n5.exit");
            Console.Write("Enter Choice : ");
            return (Int32.Parse(Console.ReadLine()));
        }
        public static void Main(string[] args)
        {
            Stack st = new Stack();
            int ch = 1;
            while (ch != 0)
            {
                ch = st.Menu();
                switch (ch)
                {
                    case 1:
                        Console.Write("\nEnter Data to push into stack : ");
                        int data = Int32.Parse(Console.ReadLine());
                        st.Push(data);
                        break;
                    case 2:
                        Console.WriteLine("\n{0} <-- Popped from stack", st.Pop());
                        break;
                    case 3:
                        st.Peek();
                        break;
                    case 4:
                        st.PrintStack();
                        break;
                    case 5:
                        Console.WriteLine("\nThank You ");
                        ch = 0;
                        break;
                    default:
                        Console.WriteLine("\nWrong Choice");
                        Main(args);
                        break;
                }
            }
        }
    }
}