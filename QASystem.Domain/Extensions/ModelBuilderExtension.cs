using Microsoft.EntityFrameworkCore;
using QASystem.Models.Context;
using System;
using System.Linq;
using System.Reflection;

namespace QASystem.Models.Extensions
{
    internal static class ModelBuilderExtension
    {
        public static void ApplyBuilderConfigurations(this ModelBuilder modelBuilder)
        {
            var types = typeof(QASystemDbContext).Assembly
                .GetTypes()
                .Where(n => n.GetInterfaces()
                    .Any(m => m.IsGenericType && m.Name.Equals(typeof(IEntityTypeConfiguration<>).Name))
                    );

            var genericMethod = typeof(ModelBuilder)
                .GetGenericMethod("ApplyConfiguration", new Type[] { typeof(IEntityTypeConfiguration<>) });

            foreach (var type in types)
            {
                var interfaceType = type
                    .GetInterfaces()
                    .Single(n => n.Name.Equals(typeof(IEntityTypeConfiguration<>).Name));
                if (interfaceType == null)
                {
                    throw new Exception("Invalid type of IEntityTypeConfiguration");
                }
                var classType = interfaceType.GetGenericArguments().First();
                MethodInfo method;
                if(genericMethod.ContainsGenericParameters)
                {
                    method = genericMethod.MakeGenericMethod(classType);
                }
                else
                {
                    method = genericMethod;
                }
                var instance = Activator.CreateInstance(type);
                method.Invoke(modelBuilder, new object[] { instance });
            }
        }
    }
}