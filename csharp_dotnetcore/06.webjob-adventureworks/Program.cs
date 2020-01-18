using System;
using System.Threading;

namespace _06.webjob_adventureworks
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Background task started..");
            for (int counter=0; counter<100; counter++)
            {
                Console.WriteLine("{0} - {1}", DateTime.Now.ToString(), counter.ToString());
                Thread.Sleep(300); //delay
            }
            Console.WriteLine("Background task finished..");
            Console.Read();
        }
    }
}
