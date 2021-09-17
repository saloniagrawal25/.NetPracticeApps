using System;
using System.Collections.Generic;
using System.Text;

namespace StopWatch
{
    class Stopwatch
    {
        public DateTime StartTime
        {
            get; set;
        }

        public DateTime StopTime
        {
            get; set;
        }

        public bool isStarted
        {
            get; set;
        }
        public DateTime Start()
        {
            if (isStarted)
            {
                throw new InvalidOperationException();
            }
            else 
            { 
                isStarted = true; 
                StartTime = DateTime.Now; 
            }
            return StartTime;
        }

        public DateTime Stop()
        {
            isStarted = false;
            StopTime = DateTime.Now;
            return StopTime;
        }

        public TimeSpan Duration() => StopTime - StartTime;
    }
}
