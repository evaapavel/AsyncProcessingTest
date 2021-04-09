using System;
using System.Threading.Tasks;



namespace AsyncProcessingMain.AsyncBreakfast
{



    public class BreakfastProcessAsync
    {



        public static async Task MakeBreakfastAsync()
        {

            DateTime breakfastStart = DateTime.Now;
            MultiStopwatch clock = new MultiStopwatch();


            clock.Start("Coffee");
            // ***
            Coffee cup = PourCoffee();
            Console.WriteLine("coffee is ready");
            // ***
            //TimeSpan coffeeTook = clock.StopAndGetTook("Coffee");
            Stopwatch coffeeTook = clock.Stop("Coffee");


            clock.Start("Egg");
            // ***
            Task<Egg> eggsTask = FryEggsAsync(2);

            clock.Start("Bacon");
            // ***
            Task<Bacon> baconTask = FryBaconAsync(3);

            clock.Start("Toast");
            // ***
            //Task<Toast> toastTask = ToastBreadAsync(2);
            Task<Toast> toastTask = MakeToastWithButterAndJamAsync(2);


            Egg eggs = await eggsTask;
            Console.WriteLine("eggs are ready");
            // ***
            //TimeSpan eggsTook = clock.StopAndGetTook("Egg");
            Stopwatch eggsTook = clock.Stop("Egg");


            Bacon bacon = await baconTask;
            Console.WriteLine("bacon is ready");
            // ***
            //TimeSpan baconTook = clock.StopAndGetTook("Bacon");
            Stopwatch baconTook = clock.Stop("Bacon");


            Toast toast = await toastTask;
            //ApplyButter(toast);
            //ApplyJam(toast);
            Console.WriteLine("toast is ready");
            // ***
            //TimeSpan toastTook = clock.StopAndGetTook("Toast");
            Stopwatch toastTook = clock.Stop("Toast");


            clock.Start("Juice");
            // ***
            Juice oj = PourOJ();
            Console.WriteLine("oj is ready");
            // ***
            //TimeSpan juiceTook = clock.StopAndGetTook("Juice");
            Stopwatch juiceTook = clock.Stop("Juice");


            Console.WriteLine("Breakfast is ready!");

            DateTime breakfastDone = DateTime.Now;
            TimeSpan breakfastTook = breakfastDone.Subtract(breakfastStart);
            //Console.WriteLine($"Breakfast took {breakfastTook.Seconds} seconds and {breakfastTook.Milliseconds} milliseconds.");
            Console.WriteLine($"Breakfast started at {breakfastStart.ToString(ProcessConstants.DateTimeFormatString)} and took {breakfastTook.Seconds} seconds and {breakfastTook.Milliseconds} milliseconds.");
            // ***
            //Console.WriteLine($"Coffee took {coffeeTook.Seconds} seconds and {coffeeTook.Milliseconds} milliseconds.");
            //Console.WriteLine($"Eggs took {eggsTook.Seconds} seconds and {eggsTook.Milliseconds} milliseconds.");
            //Console.WriteLine($"Bacon took {baconTook.Seconds} seconds and {baconTook.Milliseconds} milliseconds.");
            //Console.WriteLine($"Toast took {toastTook.Seconds} seconds and {toastTook.Milliseconds} milliseconds.");
            //Console.WriteLine($"Juice took {juiceTook.Seconds} seconds and {juiceTook.Milliseconds} milliseconds.");
            Console.WriteLine($"Coffee started at {coffeeTook.StartTime.ToString(ProcessConstants.DateTimeFormatString)} and took {coffeeTook.Seconds} seconds and {coffeeTook.Milliseconds} milliseconds.");
            Console.WriteLine($"Eggs started at {eggsTook.StartTime.ToString(ProcessConstants.DateTimeFormatString)} and took {eggsTook.Seconds} seconds and {eggsTook.Milliseconds} milliseconds.");
            Console.WriteLine($"Bacon started at {baconTook.StartTime.ToString(ProcessConstants.DateTimeFormatString)} and took {baconTook.Seconds} seconds and {baconTook.Milliseconds} milliseconds.");
            Console.WriteLine($"Toast started at {toastTook.StartTime.ToString(ProcessConstants.DateTimeFormatString)} and took {toastTook.Seconds} seconds and {toastTook.Milliseconds} milliseconds.");
            Console.WriteLine($"Juice started at {juiceTook.StartTime.ToString(ProcessConstants.DateTimeFormatString)} and took {juiceTook.Seconds} seconds and {juiceTook.Milliseconds} milliseconds.");

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



        private static async Task<Toast> ToastBreadAsync(int slices)
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



        private static async Task<Toast> MakeToastWithButterAndJamAsync(int number)
        {
            var toast = await ToastBreadAsync(number);
            ApplyButter(toast);
            ApplyJam(toast);

            return toast;
        }



        private static async Task<Bacon> FryBaconAsync(int slices)
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



        private static async Task<Egg> FryEggsAsync(int howMany)
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
