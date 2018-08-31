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
            myLine.A = -1;
            myLine.B = 5;
            myLine.C = 12;
            Console.WriteLine(myLine.isValid());
            //Console.WriteLine(myLine.A);
            Console.WriteLine(myLine.ReturnX(3));
            Console.WriteLine(myLine.ReturnY(11));

            Console.WriteLine(myLine.ReturnSlope());

            Line myLineB = new Line();
            myLineB.A = 5;
            myLineB.B = 1;
            myLineB.C = 8;
            Console.WriteLine(myLine.CompareParallel(myLineB));
            Console.WriteLine(myLine.ComparePerpindicular(myLineB));

            myLine.CompareIntersect(myLineB);


            ////

            Line myLineOne = new Line();
            Line myLineTwo = new Line();

            myLineOne.A = 2;
            myLineOne.B = 5;
            myLineOne.C = 11;

            myLineTwo.A = 2;
            myLineTwo.B = 5;
            myLineTwo.C = 16;

            Console.WriteLine(myLineOne.CompareParallel(myLineTwo));
        }
    }

    
}
