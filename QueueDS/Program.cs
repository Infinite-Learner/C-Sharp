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
                Console.WriteLine("Queue Is Full");
            }
            else
            {
                Que[Rear] = value;
                Rear++;
            }

        }
        public int DeQueue()
        {
            if (isEmpty())
            {
                Console.WriteLine("Queue is Empty");
                return 0;
            }
            else
            {
                int val = Que[Front];
                for(int i=0;i<Rear;i++)
                {
                    Que[i] = Que[i+1];
                }
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
                return (Que[Rear]);
            }
        }
        public bool isEmpty()
        {
            if(Rear==Front)
            {
                return true;
            }
        return false;
           
        }
        public bool isFull()
        {
            if (Rear == Max - 1)
            { 
                return true;
            }
           return false;
        }
        public static void Main()
        {
            QueueImp queue1 = new QueueImp(10);
            queue1.EnQueue(10);
            queue1.EnQueue(20);
            Console.WriteLine(queue1.DeQueue());
            Console.WriteLine(queue1.front());
            Console.WriteLine(queue1.rear());
        }

    }

}
