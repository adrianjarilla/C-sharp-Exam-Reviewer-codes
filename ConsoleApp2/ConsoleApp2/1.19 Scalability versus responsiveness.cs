using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Net.Http;
namespace ConsoleApp2
{
    public static class Program
    {
        public static void Main()
        {
            SleepAsyncA(3000);
            SleepAsyncB(3000);
        }

        //Occupies a thread
        public static Task SleepAsyncA(int millisecondTimeout)
        {
            return Task.Run(() => Thread.Sleep(millisecondTimeout));
        }

        //Doesn't occupy a thread while waiting for the timer to run
        public static Task SleepAsyncB(int millisecondsTimeout)
        {
            TaskCompletionSource<bool> tcs = null;
            var t = new Timer(delegate { tcs.TrySetResult(true);}, null, -1, -1);
            tcs = new TaskCompletionSource<bool>(t);
            t.Change(millisecondsTimeout, -1);
            return tcs.Task;
        }
       
    }
}
