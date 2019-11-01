using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exOOP
{
    class MyPoint
    {
        private int x, y;

        public MyPoint()
        {
            x = 0;
            y = 0;
        }
        public MyPoint(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
        public int getX() { return this.x; }

        public void setX(int x) { this.x = x; }
        
        public int getY() { return this.y; }
        
        public void setY(int y) { this.y = y; }
        
        public int[] getXY()
        {
            return new int[] { this.x, this.y };
        }
        public void setXY(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
        public override string ToString()
        {
            return String.Format("{{{0},{1}}}", x, y);
        }
        public double distance(int x, int y)
        {
            return Math.Sqrt(Math.Pow(this.x - x, 2)
                + Math.Pow(this.y - y, 2));
        }
        public double distanceMyPoint(MyPoint point)
        {
            return distance(point.getX(), point.getY());
        }
        public double distance00()
        {
            return distance(0, 0);
        }
    }
}
