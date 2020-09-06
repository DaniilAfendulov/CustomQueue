using System;
using System.Collections.Generic;

namespace CustomQueue
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomQueue queue = new CustomQueue();
            for (int i = 0; i < 10; i++)
            {
                queue.Push(i * 3);
            }
            for (int i = 0; i < 10; i++)
            {
                Console.Write(queue.Pop() + "\t");
            }
            // Результат: 0       3       6       9       12      15      18      21      24      27



            CustomQueue queue2 = new CustomQueue();
            for (int i = 0; i < 5; i++)
            {
                queue2.Push(i * 3);
            }
            for (int i = 0; i < 3; i++)
            {
                Console.Write(queue2.Pop() + "\t");
            }
            for (int i = 5; i < 10; i++)
            {
                queue2.Push(i * 3);
            }
            for (int i = 3; i < 10; i++)
            {
                Console.Write(queue2.Pop() + "\t");
            }
            // Результат: 0       3       6       9       12      15      18      21      24      27
        }
    }

    public class CustomQueue
    {
        private Stack<int> stack;

        public CustomQueue()
        {
            stack = new Stack<int>();
        }

        public void Push(int x) => stack.Push(x);

        public int Pop()
        {
            Stack<int> tStack = new Stack<int>();
            while (stack.Count != 0)
            {
                tStack.Push(stack.Pop());
            }
            int value = tStack.Pop();
            while (tStack.Count != 0)
            {
                stack.Push(tStack.Pop());
            }
            return value;
        }
    }


}