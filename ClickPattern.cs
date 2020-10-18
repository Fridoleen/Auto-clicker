using System;
using System.Collections.Generic;
using System.Linq;  
using System.Threading.Tasks;
using System.Threading;

namespace Auto_clicker
{

    class ClickPattern
    {
        private static readonly List<TimePoint> clPattern;

        public static CancellationTokenSource source = new CancellationTokenSource();
        private static CancellationToken universal_token = source.Token;

        public static int Period { get; set; }
        public static int Initial_delay { get; set; }

        static ClickPattern()
        {
            clPattern = new List<TimePoint>();
            Period = 0;
            Initial_delay = 0;
        }

        public static void AddPoint(int _x, int _y, int _t)
        {            
            TimePoint newP = new TimePoint(_x, _y, _t);
            clPattern.Add(newP);
            EventLog.RecordMessage($"New point added to the list ({_x}, {_y}, {_t})");
        }

        public static void ClearPattern()
        {
            clPattern.Clear();
            EventLog.RecordMessage("Point list for pattern is clear now");
        }



        public static void ClickOnce()
        {
            EventLog.RecordMessage("ClickOnce sequence initiated");

            if (clPattern.Count() > 0)
            {
                EventLog.RecordMessage("Clicking with coordinates");
                MouseSimulator.LClick(clPattern[0].x, clPattern[0].y);
                try
                {
                    for (int i = 1; i < clPattern.Count(); i++)
                    {
                        Task.Delay(clPattern[i - 1].t).ContinueWith(x =>
                             {
                                 EventLog.RecordMessage($"Left clicked {clPattern[i].x}, {clPattern[i].y}");

                                 MouseSimulator.LClick(clPattern[i].x, clPattern[i].y);
                             }, universal_token).Wait();
                    }
                }
                catch (AggregateException ae)
                {
                    EventLog.RecordMessage("Clicking canceled inside of pattern " + ae.Message);
                }
            }
            else
            {
                EventLog.RecordMessage("Just click without coordinates");

                MouseSimulator.LClick();
            }
        }



        public static void ClickUntilStopped()
        {       
            EventLog.RecordMessage("ClickingUntilStopped sequence initiated");
            
            ClickOnce();
            try
            {
                while (!universal_token.IsCancellationRequested)
                {
                    Task.Delay(Period).ContinueWith(x =>
                   {
                       ClickOnce();
                   }, universal_token).Wait();
                }
            }
            catch (AggregateException ae)
            {
                EventLog.RecordMessage("Unlimited clicking canceled " + ae.Message);
            }
        }



        public static void ClickNTimes(int count)
        {
            EventLog.RecordMessage("Clicking times : " + count + " sequence initiated");
            
            ClickOnce();
            try
            {
                for (int i = 1; i < count; i++)
                {
                    EventLog.RecordMessage(i + " pattern clicking initiated");

                    Task.Delay(Period * i).ContinueWith(x =>
                   {
                       ClickOnce();
                   }, universal_token).Wait();
                }
            }
            catch (AggregateException ae)
            {
                EventLog.RecordMessage("Numerical clicking canceled " + ae.Message);
            }

        }


    }
}
