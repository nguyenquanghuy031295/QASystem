using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using QASystem.Domain.DomainModels;

namespace QASystem.Models.DomainModels
{
    public class Answer : Entity
    {
        protected Answer(Guid id) : base(id)
        {
        }

        public string Content { get; set; }

        public Guid AnswererId { get; set; }

        public Guid QuestionId { get; set; }
        public virtual Question Question { get; set; }

        public DateTime DateOfAnswer { get; set; }
    }

    public partial class QASystemDbContext
    {
        public DbSet<Answer> Answers { get; set; }
    }

    public class AnswerConfiguration : IEntityTypeConfiguration<Answer>
    {
        public void Configure(EntityTypeBuilder<Answer> builder)
        {
            builder.HasKey(n => n.Id);
            builder.Property(n => n.Content).IsRequired();

            builder.ToTable("Answer", Constant.Schema);
        }
    }
}