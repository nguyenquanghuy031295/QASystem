using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using JetBrains.Annotations;
using QASystem.Models.DomainModels;
using QASystem.Models.Extensions;
using QASystem.Domain.DomainModels;

namespace QASystem.Models.Context
{
    public partial class QASystemDbContext : DbContext
    {

        public QASystemDbContext(DbContextOptions<QASystemDbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyBuilderConfigurations();
            //modelBuilder.ApplyConfiguration(new MemberConfiguration());
            //modelBuilder.ApplyConfiguration(new AnswerConfiguration());
            //modelBuilder.ApplyConfiguration(new QuestionConfiguration());
            //modelBuilder.ApplyConfiguration(new TagConfiguration());
            //modelBuilder.ApplyConfiguration(new QuestionTagConfiguration());
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=.;Database=QASystem;Trusted_Connection=True;");
        }

    }
}
