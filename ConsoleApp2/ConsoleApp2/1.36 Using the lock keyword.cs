//using System;
//using System.Collections.Concurrent;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using System.Threading;
//using System.Net.Http;
//namespace ConsoleApp2
//{
//    public class Program
//    {
//        public static void Main()
//        {
//            int n = 0;

//            object _lock = new object();

//            var up = Task.Run(() =>
//            {
//                for (int i = 0; i < 1000000; i++)
//                    lock(_lock)
//                    n++;

//            });

//            for (int i = 0; i < 1000000; i++)
//            {
//                lock(_lock)
//                n--;
//            }

//            up.Wait();
//            Console.WriteLine(n);
//            Console.ReadLine();
//        }
//    }
//}
