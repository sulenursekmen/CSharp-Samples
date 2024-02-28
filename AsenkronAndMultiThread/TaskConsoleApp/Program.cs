using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TaskConsoleApp
{
    // Usage of Task.Factory.StartNew()
    public class Status
    {
        public int threadId { get; set; }
        public DateTime date { get; set; }
    }
    public class Program
    {
        private static async Task Main(string[] args)
        {
            var myTask = Task.Factory.StartNew((Obj) =>
            {
                Console.WriteLine("Runned myTask");
                var status = Obj as Status;
                status.threadId = Thread.CurrentThread.ManagedThreadId;

            }, new Status() { date = DateTime.Now });

            await myTask;

            Status s= myTask.AsyncState as Status;

            Console.WriteLine(s.date);
            Console.WriteLine(s.threadId);


            Console.ReadLine();
        }
    }
}
