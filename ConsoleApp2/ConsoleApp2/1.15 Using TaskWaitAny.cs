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
//            Task<int>[] tasks = new Task<int>[3];

//            tasks[0] = Task.Run(() =>
//            {
//                Thread.Sleep(2000);
//                return 1;
//            });

//            tasks[1] = Task.Run(() =>
//            {
//                Thread.Sleep(1000);
//                return 2;
//            });

//            tasks[2] = Task.Run(() =>
//            {
//                Thread.Sleep(3000);
//                return 3;
//            });
//            while (tasks.Length > 0)
//            {
//                int i = Task.WaitAny(tasks);
//                Task<int> completedTask = tasks[i];

//                Console.WriteLine(completedTask.Result);

//                var temp = tasks.ToList();
//                temp.RemoveAt(i);
//                tasks = temp.ToArray();
//            }
//            Console.ReadLine();
//        }
//    }
//}
