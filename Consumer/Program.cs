using System;
using System.Threading;
using System.Threading.Tasks;
using Wrike.IO.Service;

namespace Consumer
{
    class Program
    {
        static void Main(string[] args)
        {
            string title = "";
            Task t = TaskUtilities.CreateTaskAsync(title);

            Thread.Sleep(2000);
            Console.ReadKey();

        }
    }
}
