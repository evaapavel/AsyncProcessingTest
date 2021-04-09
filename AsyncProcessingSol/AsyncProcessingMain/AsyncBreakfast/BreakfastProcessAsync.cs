﻿using System;
using System.Threading.Tasks;



namespace AsyncProcessingMain.AsyncBreakfast
{



    public class BreakfastProcessAsync
    {



        public static async Task MakeBreakfastAsync()
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
            clock.Stop("Egg");


            Bacon bacon = await baconTask;
            Console.WriteLine("bacon is ready");
            // ***
            clock.Stop("Bacon");


            Toast toast = await toastTask;
            //ApplyButter(toast);
            //ApplyJam(toast);
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



        private static async Task<Toast> ToastBreadAsync(int slices)
        {
            for (int slice = 0; slice < slices; slice++)
            {
                Console.WriteLine("Putting a slice of bread in the toaster");
            }
            Console.WriteLine("Start toasting...");
            //Task.Delay(3000).Wait();
            await Task.Delay(3000);
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
            //Task.Delay(3000).Wait();
            await Task.Delay(3000);
            for (int slice = 0; slice < slices; slice++)
            {
                Console.WriteLine("flipping a slice of bacon");
            }
            Console.WriteLine("cooking the second side of bacon...");
            //Task.Delay(3000).Wait();
            await Task.Delay(3000);
            Console.WriteLine("Put bacon on plate");

            return new Bacon();
        }



        private static async Task<Egg> FryEggsAsync(int howMany)
        {
            Console.WriteLine("Warming the egg pan...");
            //Task.Delay(3000).Wait();
            await Task.Delay(3000);
            Console.WriteLine($"cracking {howMany} eggs");
            Console.WriteLine("cooking the eggs...");
            //Task.Delay(3000).Wait();
            await Task.Delay(3000);
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
