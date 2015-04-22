using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSharpDesignPatterns.Behavioral.Observer;
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

            CreateSection("Observer pattern");

            var bookSubject = new BookSubject("Gone Girl","True Crime");

            bookSubject.Attach(new ConcreteObserver("The Librarian"));

            bookSubject.SubjectType = "Horror";
            bookSubject.SubjectType = "Romance";

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
