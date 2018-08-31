/**
Name: Isaac Bennett
Class: CIT265
Assignment: Assignment 1
**/
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

            //Testing some base values here
            Line myLine = new Line();
            myLine.A = -1;
            myLine.B = 5;
            myLine.C = 12;
            Console.WriteLine(myLine.isValid());
            Console.WriteLine(myLine.ReturnX(3));
            Console.WriteLine(myLine.ReturnY(11));
            Console.WriteLine(myLine.ReturnSlope());

            Line myLineB = new Line();
            myLineB.A = 5;
            myLineB.B = 1;
            myLineB.C = 8;
            //Testing perpindicular and parallel comparison
            Console.WriteLine(myLine.CompareParallel(myLineB));
            Console.WriteLine(myLine.ComparePerpindicular(myLineB));

            //Checking if intersecting
            myLine.CompareIntersect(myLineB);


            ////
            //Checking to see if Parallel function works with a set of parallel lines
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
