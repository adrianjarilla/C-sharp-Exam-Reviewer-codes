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
//                foreach(string v in col.GetConsumingEnumerable())
//                    Console.WriteLine("Will be removed: " + v);

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
