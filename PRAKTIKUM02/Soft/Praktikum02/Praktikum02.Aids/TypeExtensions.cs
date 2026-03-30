using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Praktikum02.Aids
{
    public static class TypeExtensions
    {
        public static IEnumerable<string> GetPropertyNames(this Type type)
        {
            return type
                .GetProperties(BindingFlags.Public | BindingFlags.Instance)
                .Select(p => p.Name);
        }
    }
}
