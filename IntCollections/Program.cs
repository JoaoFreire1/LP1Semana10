using System;
using System.Collections.Generic;

namespace IntCollections
{
    public class Program
    {
        private static void Main(string[] args)
        {
            List<int> lst1 = new List<int>() {1, 10, -30, 10, -5};
            // lst1.Add(1);
            // ..
            
            Stack<int> stk1 = new Stack<int>();
            stk1.Push(1);
            stk1.Push(10);
            stk1.Push(-30);
            stk1.Push(10);
            stk1.Push(-5);

            Queue<int> que1 = new Queue<int>() ;
            que1.Enqueue(1);
            que1.Enqueue(10);
            que1.Enqueue(-30);
            que1.Enqueue(10);
            que1.Enqueue(-5);

            HashSet<int> hass1 = new HashSet<int>() {1, 10, -30, 10, -5};
            // hass1.Add(1);
            // ..

            // Just a List.
            Console.Write("List: ");
            foreach (int itm in lst1)
                Console.Write(itm+", ");

            // LIFO.
            Console.Write("\nStack: ");
            foreach (int itm in stk1)
                Console.Write(itm+", ");

            // FIFO.
            Console.Write("\nQueue: ");
            foreach (int itm in que1)
                Console.Write(itm+", ");

            // Imprime valores que não repetem.
            Console.Write("\nHashSet: ");
            foreach (int itm in hass1)
                Console.Write(itm+", ");
        }
    }
}

