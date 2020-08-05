using System;

namespace ThreeDataStructures
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList<int> list = new LinkedList<int>();
            list.Add(7);
            list.Add(5);

            //list.Remove(5);
            list.Insert(0, 7);
            Console.WriteLine(list.Index(5));
        }
    }
}
