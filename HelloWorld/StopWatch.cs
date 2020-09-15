using System;
namespace HelloWorld
{
    public class StopWatch
    {
        private DateTime _startTime;
        private DateTime _stopTime;
        private bool _started;

        public void Start()
        {
            if (this._started)
            {
                throw new InvalidOperationException("you need to stop first");
            }
            this._startTime = DateTime.Now;
            this._started = true;
        }

        public void Stop()
        {
            if (!this._started)
            {
                throw new InvalidOperationException("you need to start first");

            }
            this._stopTime = DateTime.Now;
            this._started = false;
        }

        public TimeSpan Duration()
        {
            Console.WriteLine(this._stopTime - this._startTime);
            return this._stopTime - this._startTime;
        }

    }
}




//We call the start method first, and the stop method next.
//Then we ask the stopwatch about the duration between start and stop. Display the duration on the console.
//We should also be able to use a stopwatch multiple times.So we may start and stop it and then
//start and stop it again. Make sure the duration value each time is calculated properly.
//We should not be able to start a stopwatch twice in a row (because that may overwrite the initial
//start time). So the class should throw an InvalidOperationException if its started twice. 