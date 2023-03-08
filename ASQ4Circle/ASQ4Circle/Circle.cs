using System;
using System.Collections.Generic;
using System.Text;

namespace ASQ4Circle
{
    interface GeometricObject
    {
        double getPerimter();
        double getArea();
    }
    class Circle : GeometricObject
    {
        protected double radius;

        public Circle(double r)
        {
            this.radius = r;
        }

        public virtual string toStrings()
        {
            return "Circle [Radius = " + radius + " ]";
        }

        public double getPerimter()
        {
            return 0;
        }

        public double getArea()
        {
            return 0;
        }
    }

    interface Resizable
    {
        void Resize(int percent);
    }
    class ResizeableCircle : Circle,Resizable
    {
        public ResizeableCircle(double r):base(r)
        {

        }
        public override string toStrings()
        {
            return "ResizeableCircle[" + base.toStrings() + "]";
        }

        public void Resize(int percent)
        {
            radius *= percent / 100;
        }

    }
}
