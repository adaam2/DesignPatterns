using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpDesignPatterns.Creational.Prototype
{
    class ConcretePrototype1 : Prototype
    {
        public ConcretePrototype1(int id) : base(id)
        {

        }

        // Returns a shallow copy
        public override Prototype Clone()
        {
            return (Prototype)this.MemberwiseClone();
        }
    }

    /// <summary>
    /// A 'ConcretePrototype' class 
    /// </summary>
    class ConcretePrototype2 : Prototype
    {
        // Constructor
        public ConcretePrototype2(int id) : base(id)
        {

        }

        // Returns a shallow copy
        public override Prototype Clone()
        {
            return (Prototype)this.MemberwiseClone();
        }
    }
}
