using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern
{
    public interface IHotDrink
    {
        void Consume();

    }

    internal class Tea : IHotDrink
    {
        public void Consume()
        {
            Console.WriteLine("tea is nice");
        }
    }


    class Program
    {
        static void Main()
        {

        }
    }
}
