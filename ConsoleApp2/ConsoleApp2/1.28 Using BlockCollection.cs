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
//    public static class Program
//    {
//        public static void Main()
//        {
//            BlockingCollection<string> col = new BlockingCollection<string>();
//            Task read = Task.Run(() =>
//            {
//                while (true)
//                {
//                    Console.WriteLine("Will be removed: " + col.Take());
//                }
//            });

//            Task write = Task.Run(() =>
//            {
//                while (true)
//                {
//                    string s = Console.ReadLine();
//                    if (String.IsNullOrWhiteSpace(s)) break;
//                    col.Add(s);
//                }
//            });
//            write.Wait();
//        }
//    }
//}
