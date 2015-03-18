using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSharpDesignPatterns.Creational.Factory;
using CSharpDesignPatterns.Creational.Prototype;
using CSharpDesignPatterns.Creational.Singleton;

namespace CSharpDesignPatterns
{
    /// <summary>
    /// Main Tester class
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            CreateSection("Singletons");

            Singleton s1 = Singleton.Instance();
            Singleton s2 = Singleton.Instance();

            if (s1 == s2)
            {
                Console.WriteLine("Objects are the same instance.");
            }
            EndSection();

            CreateSection("Prototypes");

            var p1 = new ConcretePrototype1(1);

            Console.WriteLine("Original ID: {0}", p1.Id);

            var c1 = (ConcretePrototype1) p1.Clone();

            Console.WriteLine("Cloned ID: {0}", c1.Id);

            EndSection();

            /*
             * 
             * As an example consider the following: you need to load data from a DB, but you have one central DB for integration with lots of data, and one smaller one in memory on each dev-PC. In your code you ask a factory to get a DB-handle and the factory returns one of those depending on e.g. a configuration file.
             * 
             * The Factory Method pattern abstracts the decision-making process from the calling class. This has several advantages:

                Reuse. If I want to instantiate in many places, I don't have to repeat my condition, so when I come to add a new class, I don't run the risk of missing one.

                Unit-Testability. I can write 3 tests for the factory, to make sure it returns the correct types on the correct conditions, then my calling class only needs to be tested to see if it calls the factory and then the required methods on the returned class. It needs to know nothing about the implementation of the factory itself or the concrete classes.

                Extensibility. When someone decides we need to add a new class D to this factory, none of the calling code, neither unit tests or implementation, ever needs to be told. We simply create a new class D and extend our factory method. This is the very definition of Open-Closed Principle.

                You can even create a new factory class and make them hot-swappable, if the situation requires it -- for example, if you want to be able to switch class D on and off, while testing. I have run into this situation only once, but it was extremely useful.
             * 
             * 
             */
            CreateSection("Factory");

            var creators = new Creator[2];

            creators[0] = new ConcreteCreator();
            creators[1] = new ConcreteCreator2();

            foreach (Creator creator in creators)
            {
                Product product = creator.FactoryMethod();

                Console.WriteLine("Created {0}", product.GetType().Name);
            }

            EndSection();

            Console.ReadKey();
        }

        static void CreateSection(string sectionName)
        {
            Console.WriteLine(String.Format("-------- {0} --------", sectionName));
            Console.WriteLine(Environment.NewLine);
        }

        static void EndSection()
        {
            Console.WriteLine(Environment.NewLine);
            Console.WriteLine("----------------------------");
        }
    }
}
