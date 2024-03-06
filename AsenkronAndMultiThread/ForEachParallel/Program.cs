using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForEachParallelApp
{
    internal class Program
    {
        static  void Main(string[] args)
        {
            //ForEachParallel1();

            long FilesByte = 0;

            
            Stopwatch sw = new Stopwatch();
            sw.Start();

            string picturePath = @"C:\\Users\\sulen\\Desktop\\Pictures";

            var files = Directory.GetFiles(picturePath);

            Parallel.ForEach(files, file =>
            {
                Console.WriteLine("thread no:" + Thread.CurrentThread.ManagedThreadId);

                FileInfo f=new FileInfo(file);

                Interlocked.Add(ref FilesByte, f.Length); //Interlocked blocks access other threads
                //Interlocked.Exchange(ref FilesByte, 300);

            });

            Console.WriteLine("total : " + FilesByte );

        }

        private static void ForEachParallel1()
        {
            Stopwatch sw = new Stopwatch();
            sw.Start();

            string picturePath = @"C:\\Users\\sulen\\Desktop\\Pictures";

            var files = Directory.GetFiles(picturePath);

            Parallel.ForEach(files, file =>
            {
                Console.WriteLine("thread no:" + Thread.CurrentThread.ManagedThreadId);

                Image img = new Bitmap(file);
                var thumbnail = img.GetThumbnailImage(50, 50, () => false, IntPtr.Zero);

                thumbnail.Save(Path.Combine(picturePath, "thumbnail", Path.GetFileName(file)));


            });
            sw.Stop();
            Console.WriteLine("finished" + sw.ElapsedMilliseconds);

            sw.Reset();
            sw.Start();

            files.ToList().ForEach(file =>
            {
                Console.WriteLine("thread no:" + Thread.CurrentThread.ManagedThreadId);

                Image img = new Bitmap(file);
                var thumbnail = img.GetThumbnailImage(50, 50, () => false, IntPtr.Zero);

                thumbnail.Save(Path.Combine(picturePath, "thumbnail", Path.GetFileName(file)));
            });
            sw.Stop();
            Console.WriteLine("finished 2" + sw.ElapsedMilliseconds);
        }
    }
}
