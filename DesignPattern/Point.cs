using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern
{
    public class Point
    {
        private double x, y;

        private Point(double x, double y)
        {
            this.x = x;
            this.y = y;

        }



        public override string ToString()
        {
            return "x " + x.ToString() + " y " + y.ToString();

        }


        public  class Factory
        {
            public static Point NewCartesianPoint(double x, double y)
            {
                return new Point(x, y);
            }

            public static Point NewPolarPoint(double rho, double theta)
            {
                return new Point(rho * Math.Cos(theta), rho * Math.Sin(theta));
            }

        }

    }



        public class Demo
        {
            //static void Main()
            //{
            //    var point = Point.Factory.NewPolarPoint(1, Math.PI / 2);
            //    Console.WriteLine(point);
            //    Console.ReadKey();
            //}
        }
    }

