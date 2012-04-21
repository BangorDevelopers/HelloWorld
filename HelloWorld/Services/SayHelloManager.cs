using System;
using System.Collections.Generic;
using System.Linq;
using HelloWorld.ServiceInterfaces;

namespace HelloWorld.Services
{
    public class SayHelloManager
    {
        public IEnumerable<ISayHello> GetSayHelloProviders()
        {
            foreach (Type t in TypesImplementingInterface(typeof(ISayHello)))
            {
                var provider = (ISayHello) Activator.CreateInstance(t);
                yield return provider;
            }
        }

        private static bool DoesTypeSupportInterface(Type type, Type inter)
        {
            if (type.IsAbstract || type.IsInterface) return false;
            if (inter.IsAssignableFrom(type)) return true;
            if (type.GetInterfaces().Any(i => i.IsGenericType && i.GetGenericTypeDefinition() == inter))
                return true;
            return false;
        }

        private static IEnumerable<Type> TypesImplementingInterface(Type desiredType)
        {
            return AppDomain
                .CurrentDomain
                .GetAssemblies()
                .SelectMany(assembly => assembly.GetTypes())
                .Where(type => DoesTypeSupportInterface(type, desiredType));
        }
    }


}