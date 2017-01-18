using System;
using System.Collections.Generic;

namespace PacifistInfrastructure.Extensions
{
    public static class CollectionExtensions
    {
        public static ICollection<T>AddMany<T>(
            this ICollection<T> enumerable, 
            Type toAdd, 
            int number) where T : class
        {
            for (var i = 0; i < number; i++)
                enumerable.Add(Activator.CreateInstance(toAdd) as T);
            return enumerable;
        }
    }
}
