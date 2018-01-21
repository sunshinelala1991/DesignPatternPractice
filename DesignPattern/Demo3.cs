using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern
{
    public class Rectangle
    {
        public virtual int Width { get; set; }
        public virtual int Height { get; set; }


        public override string ToString()
        {
            return $"{nameof(Width)}:{Width},{nameof(Height)}:{Height}";
        }

    }

    public class Square : Rectangle
    {
        public override int Width { get => base.Width; set => base.Width= base.Height = value; }
        public override int Height { get => base.Height; set => base.Height= base.Width = value; }

    }

    class Demo3
    {
        static public int Area(Rectangle rec) => rec.Width * rec.Height;
        /*static void Main(string[] args)
        {
            Rectangle rc = new Rectangle { Width = 3, Height = 4 };
            Console.WriteLine($"{rc} has area {Area(rc)}");
            

            Rectangle sq = new Square { Width = 3 };
            Console.WriteLine($"{sq} has area {Area(sq)}");
            Console.ReadKey();

        }
        */


    }
}
