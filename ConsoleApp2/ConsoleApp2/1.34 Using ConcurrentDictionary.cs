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
//            var dict = new ConcurrentDictionary<string, int>();

//            if (dict.TryAdd("k1", 42))
//            {
//                Console.WriteLine("Added");
//            }

//            if (dict.TryUpdate("k1", 21, 42))
//            {
//                Console.WriteLine("42 updated to 21");
//            }

//            dict["k1"] = 42; //Overwrote unconditionally

//            int r1 = dict.AddOrUpdate("k1", 3, (s, i) => i * 2);
//            int r2 = dict.GetOrAdd("k2", 3);

//            Console.WriteLine(dict["k1"]);
//            Console.WriteLine(r1);
//            Console.WriteLine(r2);
//            Console.ReadLine();

//        }
//    }
//}
