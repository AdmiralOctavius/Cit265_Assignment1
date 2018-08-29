using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cit265_Assignment1
{
    class Line
    {
        private double a, b, c;
        public double A
        {
            get { return a; }
            set { a = value; }
        }
        public double B
        {
            get { return b; }
            set { b = value; }
        }
        public double C
        {
            get { return c; }
            set { c = value; }
        }

        public bool isValid()
        {
            if(A != 0 || B != 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        //Six different methods
        public double ReturnX(double y)
        {
 
                double tempB = y * B;
                double tempC = C - tempB;
                double x = tempC / A;
                return x;

        }

        public double ReturnY(double x)
        {
            double tempA = x * A;
            double tempC = C - tempA;
            double y = tempC / B;
            return y;
        }

        public double ReturnSlope()
        {
            double slope = 0;
            if (B != 0)
            {
                slope = (-1 * A) / B;
            }
            return slope;
        }

        public bool CompareParallel(Line lineA)
        {
            bool areParallel = false;

            if(lineA.B ==0 && B == 0)
            {
                areParallel = true;
            }
            else if(lineA.ReturnSlope() == ReturnSlope())
            {
                areParallel = true;
            }
            else
            {

            }

            return areParallel;
        }
        
        public bool ComparePerpindicular(Line lineA)
        {
            bool arePerpindicular = false;

            if(lineA.ReturnSlope() * this.ReturnSlope() == -1)
            {
                arePerpindicular = true;
            }
            else if(lineA.B == 0 && this.A == 0 || this.B == 0 && lineA.A == 0)
            {
                arePerpindicular = true;
            }
            else
            {

            }
                return arePerpindicular;

        }
        /*
        void CompareIntersect(Line lineA, Line lineB)
        {

        }*/
    }
}
