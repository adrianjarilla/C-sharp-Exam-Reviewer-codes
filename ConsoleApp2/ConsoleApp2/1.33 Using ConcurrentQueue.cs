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
//            ConcurrentQueue<int> queue = new ConcurrentQueue<int>();

//            queue.Enqueue(42);

//            int result;
//            if(queue.TryDequeue(out result))
//                Console.WriteLine(result);

//            Console.ReadLine();

//        }
//    }
//}
