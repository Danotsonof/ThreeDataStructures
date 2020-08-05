using System;

namespace ThreeDataStructures
{
    class Program
    {
        static void Main(string[] args)
        {
            // LinkedList Example
            LinkedList<int> list = new LinkedList<int>();
            list.Add(7);
            list.Add(5);
            //list.Remove(5);
            list.Insert(0, 7);
            Console.WriteLine(list.Check(17));

            // Queue Example
            Queue<int> queue = new Queue<int>();
            queue.Enqueue(7);
            queue.Enqueue(5);
            queue.Dequeue();
            queue.Enqueue(7);
            Console.WriteLine(queue.Size());

            // Stack Example
            Stack<int> stack = new Stack<int>();
            stack.Push(7);
            stack.Push(5);
            stack.Pop();
            stack.Push(7);
            Console.WriteLine(stack.Size());
        }
    }
}
