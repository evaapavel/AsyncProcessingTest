using System;
using System.Threading;
using System.Threading.Tasks;



namespace AsyncProcessingMain
{



    public class SimpleAsyncTest
    {



        public static void Go()
        //async public static void Go()
        {
            SimpleAsyncApp app = new SimpleAsyncApp();
            app.Run();
            //await app.Run();
            //Thread.Sleep()
            Task.Delay(5000).Wait();
        }



    }



}
