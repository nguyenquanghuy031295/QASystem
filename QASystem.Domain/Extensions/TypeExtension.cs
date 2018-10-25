using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

namespace QASystem.Models.Extensions
{
    static class TypeExtension
    {
        public static MethodInfo GetGenericMethod(this Type type, string name, Type[] parameterTypes)
        {
            foreach (var method in type.GetMethods().Where(m => m.Name == name))
            {
                var parameters = method.GetParameters();

                if (parameters.Length == parameterTypes.Length && parameters.Join(parameterTypes, p => p.ParameterType.Name, t => t.Name, (p, t) => 1).Count() == parameters.Length)
                {
                    return method;
                }
            }

            return null;
        }
    }
}
