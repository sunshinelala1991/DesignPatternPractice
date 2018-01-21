 using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern3
{
    public class Person
    {
        public string StreetAddress, Postcode, City;
        public string CompanyName, Position;

        public int AnnualIncome;

        public override string ToString()
        {
            return $"{nameof(StreetAddress)}:{StreetAddress}, {nameof(Postcode)}:{Postcode}";
        }
    }


    public class PersonBuilder //facade
    {
        protected Person person = new Person();

        public PersonJobBuilder Works => new PersonJobBuilder(person);
        public static implicit operator Person(PersonBuilder pb)
        {
            return pb.person;
        }

    }


    public class PersonJobBuilder : PersonBuilder
    {
        public PersonJobBuilder(Person person)
        {
            this.person = person;
        }


        public PersonJobBuilder At(string company)
        {
            person.CompanyName = company;
            return this;
        }

        public PersonJobBuilder AsA(string position)
        {
            person.Position = position;
            return this;
        }

        public PersonJobBuilder Earning(int amount)
        {
            person.AnnualIncome = amount;
            return this;
        }
    }



    class FacetedBuilder
    {

        //static void main()
        //{
        //    var pb = new PersonBuilder();
        //    Person person = pb.Works.At("bnb").AsA("developer").Earning(18283);
        //}
    }
}
