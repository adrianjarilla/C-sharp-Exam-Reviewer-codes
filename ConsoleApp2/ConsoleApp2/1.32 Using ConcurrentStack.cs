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
//            ConcurrentStack<int> stack = new ConcurrentStack<int>();
            
//            stack.Push(42);

//            int result;
//            if(stack.TryPop(out result))
//                Console.WriteLine("Popped" + result);

//            stack.PushRange(new int[] { 1,2,3,4});

//            int[] values = new int[1];
//            stack.TryPopRange(values);

//            foreach(int i in values)
//                Console.WriteLine(i);

//            Console.ReadLine();

//        }
//    }
//}
