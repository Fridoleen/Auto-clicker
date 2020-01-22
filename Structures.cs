using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

}
