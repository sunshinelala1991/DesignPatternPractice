using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern
{

    public class Document
    {

        private int number;
        private int count;


    }

    public interface IMachine
    {
        void Print(Document d);
        void Scan(Document d);
        void Fax(Document d);
    }

    public class MultiFunctionPrinter : IMachine
    {
        public void Fax(Document d)
        {
            //throw new NotImplementedException();
        }

        public void Print(Document d)
        {
           // throw new NotImplementedException();
        }

        public void Scan(Document d)
        {
           // throw new NotImplementedException();
        }
    }


    public class OldFashionPrinter : IMachine
    {
        public void Fax(Document d)
        {
            throw new NotImplementedException();
        }

        public void Print(Document d)
        {
            //throw new NotImplementedException();
        }

        public void Scan(Document d)
        {
            throw new NotImplementedException();
        }
    }

    class Demo4
    {
    }
}
