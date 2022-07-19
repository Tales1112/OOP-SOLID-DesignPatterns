using DesignPatterns._01___Creational._1._1___Abstract_Factory.Abstract_Factory3.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace DesignPatterns._01___Creational._1._1___Abstract_Factory.Abstract_Factory3
{
    public class PurchaseProviderFactoryProvider
    {
        private IEnumerable<Type> factories;


        public PurchaseProviderFactoryProvider()
        {
            factories = Assembly.GetAssembly(typeof(PurchaseProviderFactoryProvider))
                .GetTypes()
                .Where(t => typeof(IPurchaseProviderFactory).IsAssignableFrom(t));
        }

        public IPurchaseProviderFactory CreateFactoryFor(string name)
        {
            var factory = factories
                .Single(x => x.Name.ToLowerInvariant()
                .Contains(name.ToLowerInvariant()));

            var instance = (IPurchaseProviderFactory)Activator.CreateInstance(factory);

            return instance;
        }
    }
}
