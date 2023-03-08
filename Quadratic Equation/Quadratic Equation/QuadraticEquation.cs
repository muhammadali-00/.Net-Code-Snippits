using System;
using System.Collections.Generic;
using System.Text;

namespace Quadratic_Equation
{
    class QuadraticEquation
    {
        private double a;
        private double b;
        private double c;

        public QuadraticEquation(double A,double B,double C)
        {
            this.a = A;
            this.b = B;
            this.c = C;
        }

        public double Get_a()
        { 
            return a;
                
        }

        public double Get_b()
        {
            
            return b;
            
        }
        public double Get_c()
        {
            
            return c;
            
        }

       

        

        public double getDiscriminant()
        {
            double dis = (Get_b() * Get_b()) - (4 * (Get_a() * Get_c()));
            return dis;
        }

        public double getRoot1()
        {
            if (getDiscriminant()==0)
            {
                
                return 0;
            }
            else
            {
                double r1 = (-(Get_b()) + (Math.Sqrt(getDiscriminant()))) / (2*(Get_a() * Get_c()));
                return r1;
            }
        }

        public double getRoot2()
        {
            if (getDiscriminant() == 0)
            {
                return 0;
            }
            else
            {
                double r2 = (-(Get_b()) - (Math.Sqrt(getDiscriminant()))) / (2 * (Get_a() * Get_c()));
                return r2;
            }
        }

        public void Roots()
        {
            Console.WriteLine("\n\t Root One: "+  getRoot1());
            Console.WriteLine("\n\t Root Two: " + getRoot2());
        }

    }
}
