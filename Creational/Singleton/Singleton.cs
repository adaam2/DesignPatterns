using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpDesignPatterns.Creational.Singleton
{
    /// <summary>
    /// Thread safe singleton 
    /// </summary>
    class Singleton
    {
        private static readonly Singleton _instance = new Singleton();

        /// <summary>
        /// Skeet: Note that the static constructor itself is still required if you require laziness.
        /// </summary>
        static Singleton()
        {
            
        }

        protected Singleton()
        {
            // Constructor logic here
        }
        /// <summary>
        /// Property to access the Singleton instance. Take note that instance is static
        /// </summary>
        /// <returns>The singleton instance</returns>
        public static Singleton Instance()
        {
            return _instance;
        }
    }
}
