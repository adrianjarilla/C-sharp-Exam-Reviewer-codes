//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using System.Threading;

//namespace ConsoleApp2
//{
//    public static class Program
//    {

//        public static void ThreadMethod(object o)
//        {
//            for (int i = 0; i < (int)0; i++)
//            {
//                Console.WriteLine("ThreadProc: {0}", i);
//                Thread.Sleep(0);
                
//            }
//        }
//        public static void Main(string[] args)
//        {
//            Thread t = new Thread(new ParameterizedThreadStart(ThreadMethod));
//            t.Start(5);
//            t.Join();
//            Console.ReadLine();

//        }
//    }
//}
