using System;
using System.Threading.Tasks;
using AsyncProcessingMain.AsyncBreakfast;



namespace AsyncProcessingMain
{



    public class Program
    {



        //public static void Main(string[] args)
        //{
        //    //SimpleAsyncTest.Go();

        //    //Console.WriteLine("Press a key to finish...");
        //    //Console.ReadKey(true);
        //    //BreakfastProcess.MakeBreakfast();
        //    //BreakfastProcess.MakeBreakfastAsync();
        //    await BreakfastProcess.MakeBreakfastAsync();
        //}
        //public static void Main(string[] args)
        //public static async void Main(string[] args)
        //public static async Task Main(string[] args)
        public static async Task MainAsync(string[] args)
        {
            //await BreakfastProcess.MakeBreakfastAsync();
            await BreakfastProcessAsync.MakeBreakfastAsync();
        }



        //public static void Main(string[] args)
        //{
        //    MainAsync(args);
        //}

        //public static async Task Main(string[] args)
        //{
        //    await MainAsync(args);
        //}
        //public static async Task Main(string[] args)
        //{
        //    await BreakfastProcessAsync.MakeBreakfastAsync();
        //}
        public static void Main(string[] args)
        {
            BreakfastProcess.MakeBreakfast();
        }



    }



}
