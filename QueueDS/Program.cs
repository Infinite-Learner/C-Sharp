using System;
namespace CS6
{
    public interface Queue
    {
        public void QueueCreation();
        public void EnQueue(int value);
        public int DeQueue();
        public void front();
        public void rear();
        public bool isEmpty();
        public bool isFull();
    }
    public class QueueImp : Queue
    {
        int[] Que;
        private int Max = 100, Rear=0, Front=0;
        public void QueueCreation()
        {

            Que = new int[100];

            throw new NotImplementedException();
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
            throw new NotImplementedException();

        }
        public int DeQueue()
        {
            if (isEmpty())
            {
                Console.WriteLine("Queue is Empty");            }
            throw new NotImplementedException();

        }
        public void front()
        {
            throw new NotImplementedException();

        }
        public void rear()
        {
            throw new NotImplementedException();

        }
        public bool isEmpty()
        {
            throw new NotImplementedException();
}
        public bool isFull()
        {
            throw new NotImplementedException();

        }

    }
}
