using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Text;

namespace QASystem.Models.Context
{
    public class QASystemDbContextFactory : IDesignTimeDbContextFactory<QASystemDbContext>
    {
        public QASystemDbContext CreateDbContext(string[] args)
        {
            
            var dbContextOptionsBuilder = new DbContextOptionsBuilder<QASystemDbContext>();

            dbContextOptionsBuilder.UseSqlServer(@"Server=.;Database=QASystem;Trusted_Connection=True;",
                optionsBuilder => optionsBuilder.MigrationsAssembly(typeof(QASystemDbContext).GetTypeInfo().Assembly.GetName().Name));

            return new QASystemDbContext(dbContextOptionsBuilder.Options);
        }
    }
}
