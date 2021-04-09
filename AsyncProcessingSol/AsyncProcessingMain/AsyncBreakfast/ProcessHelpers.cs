using System;



namespace AsyncProcessingMain.AsyncBreakfast
{



    public static class ProcessHelpers
    {



        public static void DisplayTimeStats(MultiStopwatch clock)
        {

            //Stopwatch coffeeTook = clock.Stop("Coffee");
            //Stopwatch eggsTook = clock.Stop("Egg");
            //Stopwatch baconTook = clock.Stop("Bacon");
            //Stopwatch toastTook = clock.Stop("Toast");
            //Stopwatch juiceTook = clock.Stop("Juice");
            //Stopwatch breakfastTook = clock.Stop("Breakfast");
            //Stopwatch coffeeTook = clock.Get("Coffee");
            //Stopwatch eggsTook = clock.Get("Egg");
            //Stopwatch baconTook = clock.Get("Bacon");
            //Stopwatch toastTook = clock.Get("Toast");
            //Stopwatch juiceTook = clock.Get("Juice");
            //Stopwatch breakfastTook = clock.Get("Breakfast");

            //Console.WriteLine($"Breakfast   started at {breakfastTook.StartTime.ToString(ProcessConstants.DateTimeFormatString)} and took {breakfastTook.Seconds} seconds and {breakfastTook.Milliseconds} milliseconds.");
            //// ***
            //Console.WriteLine($"Coffee      started at {coffeeTook.StartTime.ToString(ProcessConstants.DateTimeFormatString)} and took {coffeeTook.Seconds} seconds and {coffeeTook.Milliseconds} milliseconds.");
            //Console.WriteLine($"Eggs        started at {eggsTook.StartTime.ToString(ProcessConstants.DateTimeFormatString)} and took {eggsTook.Seconds} seconds and {eggsTook.Milliseconds} milliseconds.");
            //Console.WriteLine($"Bacon       started at {baconTook.StartTime.ToString(ProcessConstants.DateTimeFormatString)} and took {baconTook.Seconds} seconds and {baconTook.Milliseconds} milliseconds.");
            //Console.WriteLine($"Toast       started at {toastTook.StartTime.ToString(ProcessConstants.DateTimeFormatString)} and took {toastTook.Seconds} seconds and {toastTook.Milliseconds} milliseconds.");
            //Console.WriteLine($"Juice       started at {juiceTook.StartTime.ToString(ProcessConstants.DateTimeFormatString)} and took {juiceTook.Seconds} seconds and {juiceTook.Milliseconds} milliseconds.");

            DisplayLineOfTimeStats("Breakfast", clock);
            // ***
            DisplayLineOfTimeStats("Coffee", clock);
            //DisplayLineOfTimeStats("Eggs", clock);
            DisplayLineOfTimeStats("Egg", "Eggs", clock);
            DisplayLineOfTimeStats("Bacon", clock);
            DisplayLineOfTimeStats("Toast", clock);
            DisplayLineOfTimeStats("Juice", clock);

        }



        //private static void DisplayLineOfTimeStats(string taskName, Stopwatch taskTook)
        //private static void DisplayLineOfTimeStats(string taskName, MultiStopwatch clock)
        private static void DisplayLineOfTimeStats(string taskName, string taskDisplay, MultiStopwatch clock)
        {
            Stopwatch taskTook = clock.Get(taskName);
            //Console.WriteLine($"{taskName,11} started at {taskTook.StartTime.ToString(ProcessConstants.DateTimeFormatString)} and took {taskTook.Seconds,2} seconds and {taskTook.Milliseconds,4} milliseconds.");
            //Console.WriteLine($"{taskDisplay,11} started at {taskTook.StartTime.ToString(ProcessConstants.DateTimeFormatString)} and took {taskTook.Seconds,2} seconds and {taskTook.Milliseconds,4} milliseconds.");
            Console.WriteLine($"{taskDisplay,-11} started at {taskTook.StartTime.ToString(ProcessConstants.DateTimeFormatString)} and took {taskTook.Seconds,2} seconds and {taskTook.Milliseconds,4} milliseconds.");
        }



        private static void DisplayLineOfTimeStats(string taskName, MultiStopwatch clock)
        {
            DisplayLineOfTimeStats(taskName, taskName, clock);
        }



    }



}
