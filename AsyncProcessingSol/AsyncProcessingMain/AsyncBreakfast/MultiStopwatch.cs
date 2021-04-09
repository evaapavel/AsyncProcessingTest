using System;
using System.Collections.Generic;



namespace AsyncProcessingMain.AsyncBreakfast
{



    public class MultiStopwatch
    {



        private IDictionary<string, Stopwatch> stopwatches;



        public MultiStopwatch()
        {
            this.stopwatches = new Dictionary<string, Stopwatch>();
        }



        public void Start(string id)
        {
            Stopwatch stopwatch = null;
            if (stopwatches.ContainsKey(id))
            {
                stopwatch = stopwatches[id];
            }
            else
            {
                stopwatch = new Stopwatch();
                stopwatches.Add(id, stopwatch);
            }
            stopwatch.Start();
        }



        public Stopwatch Stop(string id)
        {
            if (!stopwatches.ContainsKey(id))
            {
                throw new ArgumentException($"Stopwatch \'{id}\' not found.", "id");
            }
            Stopwatch stopwatch = stopwatches[id];
            stopwatch.Stop();
            return stopwatch;
        }



        public TimeSpan StopAndGetTook(string id)
        {
            return Stop(id).Took;
        }



        public Stopwatch Get(string id)
        {
            if ( ! stopwatches.ContainsKey(id) )
            {
                throw new ArgumentException($"Stopwatch \'{id}\' not found.", "id");
            }
            Stopwatch stopwatch = stopwatches[id];
            if ( stopwatch.IsRunning )
            {
                throw new InvalidOperationException($"Stopwatch \'{id}\' is running. You cannot access it until you stop it.");
            }
            return stopwatch;
        }



    }



}
