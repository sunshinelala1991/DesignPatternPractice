using System;
using System.Collections.Generic;
using System.Linq;
using static System.Console;


namespace DesignPattern
{
    public enum Relationship
    {
        Parent, 
        Child,
        Sibling
    }

    public class Person
    {
        public string Name;
        
    }

    public class Relationships:IRelationshipBrowser
    {
        private List<(Person, Relationship, Person)> relations
            = new List<(Person, Relationship, Person)>();


        public void AddParentAddChild(Person parent, Person child)
        {
            relations.Add((parent, Relationship.Parent, child));
            relations.Add((child, Relationship.Child, parent));
        }

        public IEnumerable<Person> FindAllChildrenOf(string name)
        {
            return  relations.
                Where(x => x.Item1.Name ==name && x.Item2 == Relationship.Parent).
            Select(r => r.Item3);
            
        }

        public List<(Person, Relationship, Person)> Relations => relations;
    }

    public interface IRelationshipBrowser
    {
        IEnumerable<Person> FindAllChildrenOf(string name);
    }

    public class Research
    {
        public Research(IRelationshipBrowser browser)
        {
            foreach(var p in browser.FindAllChildrenOf("john"))
            {
                Console.WriteLine($"john has a child called {p.Name}");
            }
        }
        /*public Research(Relationships relationships)
        {
            var relations = relationships.Relations;

            foreach(var r in relations.Where(x => x.Item1.Name == "john" && x.Item2 == Relationship.Parent))
            {
                Console.WriteLine($"john has a child called {r.Item3.Name}");
            }
        }*/

        /*static void Main(string[] args)
        {
            var parent = new Person { Name = "john" };
            var child1 = new Person { Name = "nick" };
            var child2 = new Person { Name = "fuck" };


            var relationships = new Relationships();

            relationships.AddParentAddChild(parent, child1);
            relationships.AddParentAddChild(parent, child2);

            Research r = new Research(relationships);

            Console.ReadKey();
        }
        */
    }

}
 