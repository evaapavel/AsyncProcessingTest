using System;



namespace AsyncProcessingMain.AsyncBreakfast
{



    public class Stopwatch
    {



        private DateTime start;
        private DateTime done;
        private TimeSpan took;

        private bool isRunning;



        public Stopwatch()
        {
            isRunning = false;
        }



        public void Start()
        {
            if (isRunning)
            {
                throw new InvalidOperationException("This stopwatch is already running!");
            }
            start = DateTime.Now;
            isRunning = true;
        }



        public void Stop()
        {
            if ( ! isRunning )
            {
                throw new InvalidOperationException("This stopwatch was not running!");
            }
            done = DateTime.Now;
            took = done.Subtract(start);
            isRunning = false;
        }



        public TimeSpan Took => this.took;
        //public TimeSpan Took
        //{
        //    get => this.took;
        //    set => this.took = value;
        //}
        //public TimeSpan Took { get => this.took; }

        public int Seconds => this.took.Seconds;

        public int Milliseconds => this.took.Milliseconds;

        public DateTime StartTime => this.start;

        public DateTime DoneTime => this.done;

        public bool IsRunning => this.isRunning;


    }



}
