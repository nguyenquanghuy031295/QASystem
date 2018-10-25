using System;
using QASystem.Domain.DomainModels;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace QASystem.Models.DomainModels
{
    public class Author : Member
    {
        protected Author(Guid id) : base(id)
        {
        }

        public int Age { get; set; }
    }

    public partial class QASystemDbContext
    {
        public DbSet<Author> Authors { get; set; }
    }

    public class AuthorConfiguration : IEntityTypeConfiguration<Author>
    {
        public void Configure(EntityTypeBuilder<Author> builder)
        {
            builder.HasBaseType<Member>();
        }
    }
}