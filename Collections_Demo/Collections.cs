using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections_Demo
{
    public class Collections
    {
        public void ListDemo()
        {
            List<string> list = new List<string>();
            list.Add("Ela");
            list.Add("Ravi");
            list.Add("Suba");
            list.Add("Gowtham");
            Console.WriteLine("Values Added To list");
            foreach (string name in list)
            {               
                Console.WriteLine(name);
            }
            list.RemoveAt(1);
            Console.WriteLine("==================================");
            Console.WriteLine("Index 1 Value Removed");
            foreach (string name in list)
            {
                Console.WriteLine(name);
            }
            Console.WriteLine("==================================");
            Console.WriteLine("List size");
            int length = list.Count;
            Console.WriteLine(length);
            Console.WriteLine("==================================");
            Console.WriteLine("Check Entered Value Present in List");
            Console.WriteLine("Enter Name");
            string check = Console.ReadLine();
            bool isPresent = list.Contains(check);
            Console.WriteLine(isPresent);
            Console.WriteLine("==================================");
            Console.WriteLine("Clear All Content");
            list.Clear();
            foreach (string name in list)
            {
                Console.WriteLine(name);
            }
            bool empty = list.Count == 0;
            Console.WriteLine(empty);
            Console.WriteLine("========================");
        }
        public void StackDemo()
        {
            Stack<string> stack = new Stack<string>();
            stack.Push("Nantha");
            stack.Push("Ela");
            stack.Push("Suba");
            stack.Push("Gowth");
            Console.WriteLine("Names Presenrt in Stack are");
            foreach (string name in stack)
            {
                Console.WriteLine(name);
            }
            Console.WriteLine("========================");
            Console.WriteLine("Peek Element");
            Console.WriteLine(stack.Peek());
            Console.WriteLine("========================");
            Console.WriteLine("Poped Elements");
            int count = stack.Count;
            while(count>0)
            { 
                string pop = stack.Pop();
                Console.WriteLine(pop);
                count--;
            }
            Console.WriteLine("========================");
        }
        public void QueueDemo()
        {
            Queue<int> queue = new Queue<int>();
            queue.Enqueue(10);
            queue.Enqueue(20);
            queue.Enqueue(30);
            queue.Enqueue(40);
            queue.Enqueue(50);
            Console.WriteLine("Queue Elements are");
            foreach (int num in queue)
            {
                Console.WriteLine(num);
            }
            Console.WriteLine("========================");
            Console.WriteLine("Dequeue Element");
            int removed = queue.Dequeue();
            Console.WriteLine(removed);
            Console.WriteLine("========================");
            Queue<int>.Enumerator enumerator = queue.GetEnumerator();
            while(enumerator.MoveNext())
            {
                Console.WriteLine(enumerator.Current);
            }
            Console.WriteLine("========================");
            int result = queue.Count;
            Console.WriteLine("Queue Count");
            Console.WriteLine(result);
        }
        public void Dictionary()
        {
            Dictionary<int, string> dictionary = new Dictionary<int, string>();
            dictionary.Add(1 ,"Nantha");
            dictionary.Add(2, "Ela");
            dictionary.Add(3, "Suba");
            dictionary.Add(4, "Ravi");
            Console.WriteLine("Access Value Using Key" + dictionary[1]);
            foreach(var pair in dictionary)
            {
                Console.WriteLine("Key :"+pair.Key+" Value :"+pair.Value);
            }
        }
    }
}
