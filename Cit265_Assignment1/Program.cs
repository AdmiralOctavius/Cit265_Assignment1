using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cit265_Assignment1
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }

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

        //Six different methods
        double ReturnX(double y)
        {

            double tempB = y * B;
            double tempC = C - tempB;
            double x = tempC / A;
            return x;
        }
    }
}
