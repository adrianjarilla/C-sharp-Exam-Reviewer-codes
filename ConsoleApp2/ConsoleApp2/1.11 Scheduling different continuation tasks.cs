﻿//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using System.Threading;

//namespace ConsoleApp2
//{
//    public static class Program
//    {
//        public static void Main()
//        {
//            Task<int> t = Task.Run(() => { return 42; });

//            t.ContinueWith((i) => { Console.WriteLine("Canceled"); }, TaskContinuationOptions.OnlyOnCanceled);

//            t.ContinueWith((i) => { Console.WriteLine("Faulted"); }, TaskContinuationOptions.OnlyOnFaulted);

//            var completedTask = t.ContinueWith((i) => { Console.WriteLine("Completed"); },
//                TaskContinuationOptions.OnlyOnRanToCompletion);

//            completedTask.Wait();

//            Console.ReadLine();
//        }
//    }
//}
