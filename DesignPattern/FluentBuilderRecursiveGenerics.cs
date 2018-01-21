using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern2
{
    public class Person
    {
        public string Name;
        public string Position;

        public class Builder : PersonJobBuilder<Builder>
        {

        }

        public static Builder New => new Builder();

        public override string ToString()
        {
            return $"{nameof(Name)}:{Name}, {nameof(Position)}:{Position}";
        }
    }

    public abstract class PersonBuilder
    {
        protected Person person = new Person();
        public Person Build()
        {
            return person;
        }
    }


    public class PersonInfoBuilder<Self>: PersonBuilder where Self : PersonInfoBuilder<Self>
    {
        

        public Self Called(string name)
        {
            person.Name = name;
            return (Self)this;
        }
    }

    public class PersonJobBuilder<Self> : PersonInfoBuilder<PersonJobBuilder<Self>> where Self: PersonJobBuilder<Self> 
    {
        public Self WorkAs(string position)
        {
            person.Position = position;
            return (Self)this;
        }
    }
    class FluentBuilderRecursiveGenerics
    {

        //static void Main()
        //{

        //    var me=Person.New.Called("john").WorkAs("developer")
        //        .Build();
        //    Console.WriteLine(me);

        //    Console.ReadKey();


        //}

    }
}
