using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using JetBrains.Annotations;
using QASystem.Models.DomainModels;
using QASystem.Models.Extensions;
using QASystem.Domain.DomainModels;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;

namespace QASystem.Models.Context
{
    public partial class QASystemDbContext : IdentityDbContext<SystemUser, IdentityRole<Guid>, Guid>
    {

        public QASystemDbContext(DbContextOptions<QASystemDbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyBuilderConfigurations();
        }
    }
}
