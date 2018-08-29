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
            Line myLine = new Line();
            myLine.A =0;
            myLine.B = 0;
            myLine.C = 67;
            Console.WriteLine(myLine.isValid());
            //Console.WriteLine(myLine.A);
            Console.WriteLine(myLine.ReturnX(3));
            Console.WriteLine(myLine.ReturnY(11));

            Console.WriteLine(myLine.ReturnSlope());

            Line myLineB = new Line();
            myLineB.A = 34;
            myLineB.B = 0;
            myLineB.C = 101;
            Console.WriteLine(myLine.CompareParallel(myLineB));
            Console.WriteLine(myLine.ComparePerpindicular(myLineB));
        }
    }

    
}
