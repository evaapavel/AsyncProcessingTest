using System;
using System.Threading.Tasks;



namespace AsyncProcessingMain.AsyncBreakfast
{



    public class BreakfastProcess
    {



        public static void MakeBreakfast()
        {

            MultiStopwatch clock = new MultiStopwatch();

            clock.Start("Breakfast");
            // ***


            clock.Start("Coffee");
            // ***
            Coffee cup = PourCoffee();
            Console.WriteLine("coffee is ready");
            // ***
            clock.Stop("Coffee");


            clock.Start("Egg");
            // ***
            Egg eggs = FryEggs(2);
            Console.WriteLine("eggs are ready");
            // ***
            clock.Stop("Egg");


            clock.Start("Bacon");
            // ***
            Bacon bacon = FryBacon(3);
            Console.WriteLine("bacon is ready");
            // ***
            clock.Stop("Bacon");


            clock.Start("Toast");
            // ***
            Toast toast = ToastBread(2);
            ApplyButter(toast);
            ApplyJam(toast);
            Console.WriteLine("toast is ready");
            // ***
            clock.Stop("Toast");


            clock.Start("Juice");
            // ***
            Juice oj = PourOJ();
            Console.WriteLine("oj is ready");
            // ***
            clock.Stop("Juice");


            Console.WriteLine("Breakfast is ready!");
            // ***
            clock.Stop("Breakfast");

            ProcessHelpers.DisplayTimeStats(clock);

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



        private static Bacon FryBacon(int slices)
        {
            Console.WriteLine($"putting {slices} slices of bacon in the pan");
            Console.WriteLine("cooking first side of bacon...");
            Task.Delay(3000).Wait();
            for (int slice = 0; slice < slices; slice++)
            {
                Console.WriteLine("flipping a slice of bacon");
            }
            Console.WriteLine("cooking the second side of bacon...");
            Task.Delay(3000).Wait();
            Console.WriteLine("Put bacon on plate");

            return new Bacon();
        }



        private static Egg FryEggs(int howMany)
        {
            Console.WriteLine("Warming the egg pan...");
            Task.Delay(3000).Wait();
            Console.WriteLine($"cracking {howMany} eggs");
            Console.WriteLine("cooking the eggs...");
            Task.Delay(3000).Wait();
            Console.WriteLine("Put eggs on plate");

            return new Egg();
        }



        private static Coffee PourCoffee()
        {
            Console.WriteLine("Pouring coffee");
            return new Coffee();
        }



    }



}
