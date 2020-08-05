using System;
using System.Collections.Generic;

namespace ThreeDataStructures
{
    /// <summary>
    /// Implementation of a Queue
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class Queue<T>
    {
        public Queue()
        {
            // initialize queue
            queue = new List<T>();
        }

        /// <summary>
        /// Checks if queue is empty
        /// </summary>
        /// <returns>true if queue is empty</returns>
        public bool isEmpty()
        {
            return count == 0;
        }

        /// <summary>
        /// add value to the end of queue
        /// </summary>
        /// <param name="value"></param>
        public void Enqueue(T value)
        {
            queue.Add(value);
            count++;
        }

        /// <summary>
        /// remove value from the start of queue
        /// </summary>
        /// <param name="value"></param>
        public T Dequeue()
        {
            if (count == 0) throw new InvalidOperationException("The queue is empty.");

            T item = queue[0];
            queue.RemoveAt(0);
            count--;
            return item;
        }

        /// <summary>
        /// Checks for the size of queue
        /// </summary>
        /// <returns>size of queue</returns>
        public int Size()
        {
            return queue.Count;
        }
        // 

        /// <summary>
        /// print out values in queue
        /// </summary>
        public void Print()
        {
            if (count == 0)
            {
                Console.WriteLine("The queue is empty.");
                return;
            }

            foreach (var item in queue)
            {
                Console.WriteLine(item);
            }
        }
        // declare the structure of queue
        private List<T> queue
        {
            get;
            set;
        }
        // initialize count to zero
        private int count = 0;
    }
}
