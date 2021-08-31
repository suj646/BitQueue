using System;
using System.Collections;

namespace bitqueueex
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Queue my_queue = new Queue();
            my_queue.Enqueue("Sujit");
            my_queue.Enqueue(2);
            my_queue.Enqueue(200);
            my_queue.Enqueue(null);
            my_queue.Enqueue(4.4);
            my_queue.Enqueue("Pankaj");
            foreach (var ele in my_queue)
            {
                Console.WriteLine(ele);
            }
        }
    }
}
