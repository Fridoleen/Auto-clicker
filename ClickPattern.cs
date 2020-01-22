using System;
using System.Collections.Generic;
using System.Linq;  
using System.Threading.Tasks;
using System.Threading;

namespace Auto_clicker
{

    class ClickPattern
    {
        private static List<TimePoint> clPattern;

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
        }

        public static void ClearPattern()
        {
            clPattern.Clear();
        }

        public static void ClickOnce()
        {
            Console.WriteLine("ClickOnce initiated");

            if (clPattern.Count() > 0)
            {
                Console.WriteLine("Clicking with coordinates");
                MouseSimulator.LClick(clPattern[0].x, clPattern[0].y);
                try
                {
                    for (int i = 1; i < clPattern.Count(); i++)
                    {
                        Task.Delay(clPattern[i - 1].t).ContinueWith(x =>
                             {
                                 Console.WriteLine(@"Left clicked {0}, {1}", clPattern[i].x, clPattern[i].y);
                                 MouseSimulator.LClick(clPattern[i].x, clPattern[i].y);
                             }, universal_token).Wait();
                    }
                }
                catch (AggregateException ae)
                {
                    Console.WriteLine("Clicking canceled inside of pattern");
                }
            }
            else
            {
                Console.WriteLine("Just click without coordinates");

                MouseSimulator.LClick();
            }
        }

        public static void Click()
        {       
            Console.WriteLine("Clicking_unlimited initiated");
            
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
                Console.WriteLine("Unlimited clicking canceled");
            }
        }

        public static void Click(int count)
        {
            Console.WriteLine("Clicking times : " + count + " initiated");
            
            ClickOnce();
            try
            {
                for (int i = 1; i < count; i++)
                {
                    Console.WriteLine(i + " pattern clicking initiated");

                    Task.Delay(Period * i).ContinueWith(x =>
                   {
                       ClickOnce();
                   }, universal_token).Wait();
                }
            }
            catch (AggregateException ae)
            {
                Console.WriteLine("Numerical clicking canceled");
            }

        }


    }
}
