using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace Auto_clicker
{
    public struct Point
    {
        public int x, y;

        public Point(int nX, int nY)
        {
            x = nX;
            y = nY;
        }
    }

    public struct TimePoint
    {
        public int x, y, t;

        public TimePoint(int nX, int nY, int nT)
        {
            x = nX;
            y = nY;
            t = nT;
        }
    }

    class ClickPattern
    {
        private static List<TimePoint> clPattern;
        private static int _period;
        private static bool _isOn;
        private static int _pattern_duration;

        static ClickPattern()
        {
            clPattern = new List<TimePoint>();
            _period = 0;
            _isOn = false;
            _pattern_duration = 0; ;
        }

        public static void SetInterval(int t)
        {
            _period = t;
        }

        public static void SwitchOn()
        {
            if (!_isOn) _isOn = true;
        }

        public static void SwitchOff()
        {
            if (_isOn) _isOn = false;
            Console.WriteLine("Switched off");
        }

        public static bool OnStatus()
        {
            return _isOn;
        }

        public static void AddPoint(int _x, int _y, int _t)
        {
            
            TimePoint newP = new TimePoint(_x, _y, _t);
            clPattern.Add(newP);
            _pattern_duration += _t;
            Console.WriteLine("Point added: " + _x + ", " + _y + ", " + _t);
        }

        public static void ClearPattern()
        {
            clPattern.Clear();
            _pattern_duration = 0;
        }

        public static void ClickOnce()
        {

            Console.WriteLine("Clicking once, length is : " + clPattern.Count() + "... duration = " + _pattern_duration);
            if (clPattern.Count() > 0)
            {                
                Console.WriteLine("0 point");
                MouseSimulator.LClick(clPattern[0].x, clPattern[0].y);

                Timer _tmr = new Timer();
                _tmr.AutoReset = false;
                _tmr.Interval = clPattern[0].t;

                int i = 1;
                _tmr.Elapsed += (Object source, ElapsedEventArgs e) =>
                {
                    if (_isOn && i < clPattern.Count())
                    {
                        Console.WriteLine(i + " point");
                        MouseSimulator.LClick(clPattern[i].x, clPattern[i].y);
                        _tmr.Interval = clPattern[i].t;
                        _tmr.Enabled = true;
                        i++;
                    }
                    else 
                    {

                        if (!_isOn) Console.WriteLine("Pattern switched off");
                        if (i >= clPattern.Count()) Console.WriteLine("Clicked to the finish");
                        
                        //SwitchOff();
                        _tmr.Stop();                      
                    }
                };
                _tmr.Start();
            }
            else
            {
                MouseSimulator.LClick();
            }
        }

        public static void Click()
        {
            SwitchOn();
            Console.WriteLine("Clicking until stopped");
            ClickOnce();
            Timer _tmr = new Timer();
            _tmr.Interval = _period + _pattern_duration;
            _tmr.AutoReset = false;
            _tmr.Elapsed += (Object source, ElapsedEventArgs e) =>
            {
                ClickOnce();
                if (_isOn) _tmr.Enabled = true;
                else _tmr.Stop();
            };
            _tmr.Start();
        }


        public static void Click(int count)
        {
            SwitchOn();
            Console.WriteLine("Clicking times : " + count);
            ClickOnce();
            if(count > 1) 
            {                
                Timer _tmr = new Timer();
                _tmr.Interval = _period + _pattern_duration;
                _tmr.AutoReset = false;

                int i = 1;
                _tmr.Elapsed += (Object source, ElapsedEventArgs e) =>
                {
                    i++;
                    Console.WriteLine(i + " repeating of pattern, out of " + count);
                    ClickOnce();

                    if (_isOn)
                    {
                        if (i < count)
                        {
                            _tmr.Enabled = true;
                        }
                        else
                        {
                            Console.WriteLine("Clicking is done");
                            _tmr.Stop();
                        }
                    }
                    else Console.WriteLine("Clicking stopped in Click()");
                };
                _tmr.Start();
            }

            
        }


    }
}
