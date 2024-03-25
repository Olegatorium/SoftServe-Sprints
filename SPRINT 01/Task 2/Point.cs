using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SPRINT_01.Task_2
{
    class Point
    {
        private int x;
        private int y;

        public Point(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public int[] GetXYPair()
        {
            return new int[] { x, y };
        }

        protected internal double Distance(int x, int y)
        {
            return Math.Sqrt(Math.Pow(this.x - x, 2) + Math.Pow(this.y - y, 2));
        }

        protected internal double Distance(Point point)
        {
            return Math.Sqrt(Math.Pow(this.x - point.x, 2) + Math.Pow(this.y - point.y, 2));
        }

        public static explicit operator double(Point point)
        {
            return Math.Sqrt(Math.Pow(point.x, 2) + Math.Pow(point.y, 2));
        }
    }
}