using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exOOP
{
    class Tritangle
    {
        private MyPoint v1;
        private MyPoint v2;
        private MyPoint v3;

        public Tritangle(int x1,int y1,int x2,int y2,int x3,int y3)
        {
            this.v1 = new MyPoint(x1, y1);
            this.v2 = new MyPoint(x2, y2);
            this.v3 = new MyPoint(x3, y3);
        }
        public Tritangle(MyPoint v1, MyPoint v2, MyPoint v3)
        {
            this.v1 = v1;
            this.v2 = v2;
            this.v3 = v3;
        }
        public override string ToString()
        {
            return String.Format("My Triangle [v1=({0}),v2=({1}),v3=({2})]",
                this.v1,this.v2,this.v3);
        }
        public double GetPerimeter()
        {
            return this.v1.distanceMyPoint(this.v2) + this.v1.distanceMyPoint(v3) + this.v3.distanceMyPoint(v2);
        }
        public string Type()
        {
            string type;
            if (this.v1.distanceMyPoint(this.v2) == this.v1.distanceMyPoint(v3) 
                && this.v3.distanceMyPoint(v2) == this.v2.distanceMyPoint(v1))
            {
                return type = "Equilateral";
            }
            else if (this.v1.distanceMyPoint(this.v2) == this.v1.distanceMyPoint(v3))
            {
                return type = "Isosceles";
            }
            return type = "Scalene";
        }
    }
}
