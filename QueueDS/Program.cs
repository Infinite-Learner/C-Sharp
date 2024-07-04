using System;
namespace CS6
{
    public interface Queue
    {
        public void EnQueue(int value);
        public int DeQueue();
        public int front();
        public int rear();
        public bool isEmpty();
        public bool isFull();
        public void Display();
    }
    public class QueueImp : Queue
    {
        int[] Que;
        private int Max,Rear,Front;
        public QueueImp(int n)
        {
            Que = new int[n];
            Max = n;
            Rear = Front = 0;
        }
        public void EnQueue(int value)
        {
            if (isFull())
            {
                Console.WriteLine("Queue Is Full {0} is not added.",value);
            }
            else
            {
                Que[Rear] = value;
                Console.WriteLine("{0} --> Queue",value);
                Rear++;
            }

        }
        public void Display()
        {
            if (isEmpty())
            {
                Console.WriteLine("No Queue is Formed...");
            }
            else {
                for (int i = 0; i < Rear; i++)
                {
                    Console.WriteLine("Queue {0} : {1} ", i + 1, Que[i]);
                }
                Console.WriteLine();
            }
        }
        public int DeQueue()
        {
            if (isEmpty())
            {
                Console.WriteLine("No Queue is Formed...");
                return 0;
            }
            else
            {
                int val = Que[Front];
                for(int i=0;i<Que.Length-1;i++)
                {
                    Que[i] = Que[i+1];
                }
                Rear--;
                return val;
            }

        }
        public int front()
        {
            if(isEmpty())
            {
                Console.WriteLine("Queue is Empty");
                return 0;
            }
            else{
                return(Que[Front]);
            }   
        }
        public int rear()
        {
            if (isEmpty())
            {
                Console.WriteLine("Queue is Empty");
                return 0;
            }
            else
            {
                return (Que[--Rear]);
            }
        }
        public bool isEmpty()
        {
            if(Rear==0)
            {
                return true;
            }
        return false;
           
        }
        public bool isFull()
        {
            if (Rear == Max )
            { 
                return true;
            }
           return false;
        }
        private static int Choice()
        {
            Console.WriteLine("Queue Operation...\n1.EnQueue\n2.DeQueue\n3.Front_Element\n4.Rear_Element\n5.Display\n6.Exit");
            Console.Write("Enter Choice : ");
            int ch = Int32.Parse(Console.ReadLine());
            return ch;
        }
        private static int Choice(int n) 
        {
            int[] re = new int[]{1,7};
            Console.WriteLine("1.AddMore\n2.Main_Menu");
            Console.Write("Enter Choice : ");
            int ch = Int32.Parse(Console.ReadLine());
            return re[ch-1];
        }
        public static void Main()
        {
            Console.Write("Enter Queue Limit... : ");
            int n = Int32.Parse(Console.ReadLine());
            QueueImp queue1 = new QueueImp(n);
            int ch = Choice();
            while (true)
            {
                    switch (ch)
                    {
                        case 1:
                            Console.Write("\nEnQueue..\nEnter Element : ");
                            queue1.EnQueue(Int32.Parse(Console.ReadLine()));
                            ch = Choice(1);
                            Console.Clear();
                            break;
                        case 2:
                            Console.WriteLine("Queue --> {0} \n", queue1.DeQueue());
                            ch = Choice();
                            Console.Clear();
                            break;
                        case 3:
                            Console.WriteLine("Queue Front : {0} \n", queue1.front());
                            ch = Choice();
                            Console.Clear();
                            break;
                        case 4:
                            Console.WriteLine("Queue Rear : {0} \n ", queue1.rear());
                            ch = Choice();
                            Console.Clear();    
                            break;
                        case 5:
                            Console.WriteLine("Queue Elements are ...");
                            queue1.Display();
                            ch = Choice();
                            break;
                        case 6:
                            Console.WriteLine("Thanks For using...");
                            return;
                        case 7:
                            Console.Clear();
                            ch = Choice();
                            break;
                    }
                }
             
            }
            }
        }


