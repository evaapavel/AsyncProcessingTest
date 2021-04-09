﻿using System;
using System.Threading.Tasks;



namespace AsyncProcessingMain.AsyncBreakfast
{



    public class BreakfastProcess
    {



        public static void MakeBreakfast()
        {

            //DateTime breakfastStart = DateTime.Now;
            MultiStopwatch clock = new MultiStopwatch();

            clock.Start("Breakfast");
            // ***


            clock.Start("Coffee");
            // ***
            Coffee cup = PourCoffee();
            Console.WriteLine("coffee is ready");
            // ***
            //TimeSpan coffeeTook = clock.StopAndGetTook("Coffee");
            //Stopwatch coffeeTook = clock.Stop("Coffee");
            clock.Stop("Coffee");


            clock.Start("Egg");
            // ***
            Egg eggs = FryEggs(2);
            Console.WriteLine("eggs are ready");
            // ***
            //TimeSpan eggsTook = clock.StopAndGetTook("Egg");
            //Stopwatch eggsTook = clock.Stop("Egg");
            clock.Stop("Egg");


            clock.Start("Bacon");
            // ***
            Bacon bacon = FryBacon(3);
            Console.WriteLine("bacon is ready");
            // ***
            //TimeSpan baconTook = clock.StopAndGetTook("Bacon");
            //Stopwatch baconTook = clock.Stop("Bacon");
            clock.Stop("Bacon");


            clock.Start("Toast");
            // ***
            Toast toast = ToastBread(2);
            ApplyButter(toast);
            ApplyJam(toast);
            Console.WriteLine("toast is ready");
            // ***
            //TimeSpan toastTook = clock.StopAndGetTook("Toast");
            //Stopwatch toastTook = clock.Stop("Toast");
            clock.Stop("Toast");


            clock.Start("Juice");
            // ***
            Juice oj = PourOJ();
            Console.WriteLine("oj is ready");
            // ***
            //TimeSpan juiceTook = clock.StopAndGetTook("Juice");
            //Stopwatch juiceTook = clock.Stop("Juice");
            clock.Stop("Juice");


            Console.WriteLine("Breakfast is ready!");
            // ***
            //Stopwatch breakfastTook = clock.Stop("Breakfast");
            clock.Stop("Breakfast");

            ////DateTime breakfastDone = DateTime.Now;
            ////TimeSpan breakfastTook = breakfastDone.Subtract(breakfastStart);
            ////Console.WriteLine($"Breakfast took {breakfastTook.Seconds} seconds and {breakfastTook.Milliseconds} milliseconds.");
            ////Console.WriteLine($"Breakfast started at {breakfastStart.ToString(ProcessConstants.DateTimeFormatString)} and took {breakfastTook.Seconds} seconds and {breakfastTook.Milliseconds} milliseconds.");
            //Console.WriteLine($"Breakfast started at {breakfastTook.StartTime.ToString(ProcessConstants.DateTimeFormatString)} and took {breakfastTook.Seconds} seconds and {breakfastTook.Milliseconds} milliseconds.");
            //// ***
            ////Console.WriteLine($"Coffee took {coffeeTook.Seconds} seconds and {coffeeTook.Milliseconds} milliseconds.");
            ////Console.WriteLine($"Eggs took {eggsTook.Seconds} seconds and {eggsTook.Milliseconds} milliseconds.");
            ////Console.WriteLine($"Bacon took {baconTook.Seconds} seconds and {baconTook.Milliseconds} milliseconds.");
            ////Console.WriteLine($"Toast took {toastTook.Seconds} seconds and {toastTook.Milliseconds} milliseconds.");
            ////Console.WriteLine($"Juice took {juiceTook.Seconds} seconds and {juiceTook.Milliseconds} milliseconds.");
            //Console.WriteLine($"Coffee started at {coffeeTook.StartTime.ToString(ProcessConstants.DateTimeFormatString)} and took {coffeeTook.Seconds} seconds and {coffeeTook.Milliseconds} milliseconds.");
            //Console.WriteLine($"Eggs started at {eggsTook.StartTime.ToString(ProcessConstants.DateTimeFormatString)} and took {eggsTook.Seconds} seconds and {eggsTook.Milliseconds} milliseconds.");
            //Console.WriteLine($"Bacon started at {baconTook.StartTime.ToString(ProcessConstants.DateTimeFormatString)} and took {baconTook.Seconds} seconds and {baconTook.Milliseconds} milliseconds.");
            //Console.WriteLine($"Toast started at {toastTook.StartTime.ToString(ProcessConstants.DateTimeFormatString)} and took {toastTook.Seconds} seconds and {toastTook.Milliseconds} milliseconds.");
            //Console.WriteLine($"Juice started at {juiceTook.StartTime.ToString(ProcessConstants.DateTimeFormatString)} and took {juiceTook.Seconds} seconds and {juiceTook.Milliseconds} milliseconds.");

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
