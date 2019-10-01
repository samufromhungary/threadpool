using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace ThreadPoolDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            WaitCallback waitCallback = new WaitCallback(ShowMyText);
            ThreadPool.QueueUserWorkItem(waitCallback, "Yuri Tarded");
            ThreadPool.QueueUserWorkItem(waitCallback, "Moe Lester");
            ThreadPool.QueueUserWorkItem(waitCallback, "Downcore Jan Co");
            ThreadPool.QueueUserWorkItem(waitCallback, "Ken Hurt");
            Console.ReadKey();
        }

        static void ShowMyText(object state)
        {
            string text = "State: " + state.ToString() + " |";
            text += " Thread: " + Thread.CurrentThread.ManagedThreadId;
            Console.WriteLine(text);
        }
    }
}
