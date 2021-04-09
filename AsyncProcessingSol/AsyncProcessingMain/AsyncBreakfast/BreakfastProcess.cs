using System;
using System.Threading.Tasks;



namespace AsyncProcessingMain.AsyncBreakfast
{



    public class BreakfastProcess
    {



        public static void MakeBreakfast()
        {

            DateTime breakfastStart = DateTime.Now;
            MultiStopwatch clock = new MultiStopwatch();


            clock.Start("Coffee");
            // ***
            Coffee cup = PourCoffee();
            Console.WriteLine("coffee is ready");
            // ***
            TimeSpan coffeeTook = clock.StopAndGetTook("Coffee");
            Console.WriteLine($"Coffee took {coffeeTook.Seconds} seconds and {coffeeTook.Milliseconds} milliseconds.");


            clock.Start("Egg");
            // ***
            Egg eggs = FryEggs(2);
            Console.WriteLine("eggs are ready");
            // ***
            TimeSpan eggsTook = clock.StopAndGetTook("Egg");
            Console.WriteLine($"Eggs took {eggsTook.Seconds} seconds and {eggsTook.Milliseconds} milliseconds.");


            clock.Start("Bacon");
            // ***
            Bacon bacon = FryBacon(3);
            Console.WriteLine("bacon is ready");
            // ***
            TimeSpan baconTook = clock.StopAndGetTook("Bacon");
            Console.WriteLine($"Bacon took {baconTook.Seconds} seconds and {baconTook.Milliseconds} milliseconds.");


            clock.Start("Toast");
            // ***
            Toast toast = ToastBread(2);
            ApplyButter(toast);
            ApplyJam(toast);
            Console.WriteLine("toast is ready");
            // ***
            TimeSpan toastTook = clock.StopAndGetTook("Toast");
            Console.WriteLine($"Toast took {toastTook.Seconds} seconds and {toastTook.Milliseconds} milliseconds.");


            clock.Start("Juice");
            // ***
            Juice oj = PourOJ();
            Console.WriteLine("oj is ready");
            // ***
            TimeSpan juiceTook = clock.StopAndGetTook("Juice");
            Console.WriteLine($"Juice took {juiceTook.Seconds} seconds and {juiceTook.Milliseconds} milliseconds.");


            Console.WriteLine("Breakfast is ready!");

            DateTime breakfastDone = DateTime.Now;
            TimeSpan breakfastTook = breakfastDone.Subtract(breakfastStart);
            Console.WriteLine($"Breakfast took {breakfastTook.Seconds} seconds and {breakfastTook.Milliseconds} milliseconds.");

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
            Console.WriteLine($"craking {howMany} eggs");
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
