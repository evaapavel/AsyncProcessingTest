using System;



namespace AsyncProcessingMain.AsyncBreakfast
{



    public class Stopwatch
    {



        private DateTime start;
        private DateTime done;
        private TimeSpan took;



        public Stopwatch()
        {
        }



        public void Start()
        {
            start = DateTime.Now;
        }



        public void Stop()
        {
            done = DateTime.Now;
            took = done.Subtract(start);
        }



        public TimeSpan Took => this.took;
        //public TimeSpan Took
        //{
        //    get => this.took;
        //    set => this.took = value;
        //}
        //public TimeSpan Took { get => this.took; }


    }



}
