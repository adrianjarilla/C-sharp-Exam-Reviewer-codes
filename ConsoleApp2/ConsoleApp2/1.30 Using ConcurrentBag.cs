﻿//using System;
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
//            ConcurrentBag<int> bag = new ConcurrentBag<int>();
//            bag.Add(42);
//            bag.Add(21);

//            int result;
//            if(bag.TryTake(out result))
//                Console.WriteLine(result);
//            if(bag.TryPeek(out result))
//                Console.WriteLine($"There is a next item: {result}");
//            Console.ReadLine();


//        }
//    }
//}
