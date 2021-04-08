using System;
using System.Threading.Tasks;



namespace AsyncProcessingMain.AsyncBreakfast
{



    public class BreakfastProcess
    {



        public static void MakeBreakfast()
        {

            Coffee cup = PourCoffee();
            Console.WriteLine("coffee is ready");

        }



        private static Juice PourOJ()
        {
            Console.WriteLine("Pouring orange juice");
            return new Juice();
        }



        private static void ApplyJam(Toast toast) =>
            Console.WriteLine("Putting jam on the toast");



        private static void ApplyButter(Toast toast) =>
            Console.WriteLine("Putting butter on the toast");



        private static Toast ToastBread(int slices)
        {
            for (int slice = 0; slice < slices; slice++)
            {
                Console.WriteLine("Putting a slice of bread in the toaster");
            }
            Console.WriteLine("Start toasting...");
            Task.Delay(3000).Wait();
            Console.WriteLine("Remove toast from the toaster");

            return new Toast();
        }



        private static Coffee PourCoffee()
        {
            Console.WriteLine("Pouring coffee");
            return new Coffee();
        }



    }



}
