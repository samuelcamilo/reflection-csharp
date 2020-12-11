using Reflection.App.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

namespace Reflection.App._1___GetTypes
{
    public class GetTypesExample : IGetTypesExample<People>
    {
        public GetTypesExample() { }

        public Assembly GetAssemby(object obj)
            => obj.GetType().Assembly;

        public Module GetManifestInfo(object obj)
            => obj.GetType().Assembly.ManifestModule;

        public Type[] GetTypesClass(object obj)
            => obj.GetType().Assembly.GetTypes();

        public bool ExistsTypeImplemented()
            => typeof(People).Assembly.GetTypes().Where(x => x.Name == "GetTypesExample").Count() > 0 ? true : false;

        public Type[] GetClassWithGenericInteface(object obj)
            => obj.GetType().Assembly.GetTypes().Where(x => x.GetInterfaces().Any(x => x.IsGenericType && x.GetGenericTypeDefinition() == typeof(IGetTypesExample<>))).ToArray();
    }
}
