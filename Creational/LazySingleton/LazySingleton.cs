using System;

namespace CSharpDesignPatterns.Creational.LazySingleton
{
    public sealed class LazySingleton
    {
        /// <summary>
        /// Pass delegate to the lazy t constructor using lambda expression
        /// </summary>
        private static readonly Lazy<LazySingleton> lazy = new Lazy<LazySingleton>(() => new LazySingleton());

        /// <summary>
        /// Instance property returns the inner value of the System.Lazy T var
        /// </summary>
        public static LazySingleton Instance { get { return lazy.Value; } }

        private LazySingleton()
        {
            // private constructor
        }
    }
}
