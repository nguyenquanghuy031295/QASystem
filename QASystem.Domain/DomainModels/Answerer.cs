using System;
using QASystem.Domain.DomainModels;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace QASystem.Models.DomainModels
{
    public enum AnswererTitle
    {
        Student = 0,
        Teacher = 1
    };

    public class Answerer : Member
    {
        protected Answerer(Guid id) : base(id)
        {
        }

        public AnswererTitle Title { get; set; }
    }

    public partial class QASystemDbContext
    {
        public DbSet<Answerer> Answerers { get; set; }
    }

    public class AnswererConfiguration : IEntityTypeConfiguration<Answerer>
    {
        public void Configure(EntityTypeBuilder<Answerer> builder)
        {
            builder.HasBaseType<Member>();
        }
    }
}