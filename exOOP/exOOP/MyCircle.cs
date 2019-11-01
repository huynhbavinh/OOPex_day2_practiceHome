using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exOOP
{
    class MyCircle
    {
        private MyPoint center = new MyPoint(0, 0);
        private int radius = 1;

        public MyCircle(int x, int y, int radius)
        {
            this.center = new MyPoint(x, y);
            this.radius = radius;
        }
        public MyCircle(int radius)
        {
            this.radius = radius;
        }
        public int GetRadius() { return this.radius; }
        public void SetRadius(int radius) { this.radius = radius; }
        public MyPoint GetCenter() { return this.center; }
        public void SetCenter(MyPoint center) { this.center = center; }
        public int GetCenterX() { return this.center.getX(); }
        public void SetCenterX(int x) { this.center.setX(x); }
        public int GetCenterY() { return this.center.getY(); }
        public void SetCenterY(int y) { this.center.setY(y); }
        public int[] GetCenterXY() { return this.center.getXY(); }
        public void SetCenterXY(int x, int y) { this.center.setXY(x, y); }
        public override string ToString()
        {
            return String.Format("My Circle[radius = {0}, Center = ({1}) ]", this.radius, this.center);
        }
        public double GetArea() { return Math.PI * Math.Pow(this.radius, 2); }
        public double GetCircumference() { return this.radius * 2 * Math.PI; }
        public double Distance(MyCircle another) { return this.center.distance(another.GetCenterX(), another.GetCenterY()); }

    }
}
