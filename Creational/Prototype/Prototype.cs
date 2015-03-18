using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpDesignPatterns.Creational.Prototype
{
    abstract class Prototype
    {
        private int _id;

        public Prototype(int id)
        {
            this._id = id;
        }

        public int Id
        {
            get { return _id; }
        }

        public abstract Prototype Clone();
    }
}
