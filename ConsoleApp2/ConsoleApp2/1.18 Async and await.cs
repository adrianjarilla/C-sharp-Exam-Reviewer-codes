﻿//using System;
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
//            string result = DownloadContent().Result;
//            Console.WriteLine(result);
//            Console.ReadLine();
//        }

//        public static async Task<string> DownloadContent()
//        {
//            using (HttpClient client = new HttpClient())
//            {
//                string result = await client.GetStringAsync("http://www.microsoft.com");
//                return result;
//            }
//        }

       
//    }
//}
