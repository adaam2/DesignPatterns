using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpDesignPatterns.Creational.Factory
{
    abstract class Creator
    {
        public abstract Product FactoryMethod();
    }
}
