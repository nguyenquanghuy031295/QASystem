using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using QASystem.Domain.DomainModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace QASystem.Models.DomainModels
{
    public class Question : Entity
    {
        protected Question(Guid id) : base(id)
        {
        }

        public string Title { get; set; }

        public string Content { get; set; }

        public Guid AuthorId { get; set; }
        public virtual Member Author { get; set; }

        public DateTime DateOfQuestion { get; set; }

        public ICollection<QuestionTag> QuestionTags { get; set; }
    }

    public partial class QASystemDbContext
    {
        public DbSet<Question> Questions { get; set; }
    }

    public class QuestionConfiguration : IEntityTypeConfiguration<Question>
    {
        public void Configure(EntityTypeBuilder<Question> builder)
        {
            builder.HasKey(n => n.Id);
            builder.Property(n => n.Title).IsRequired();

            builder.ToTable("Question", Constant.Schema);
        }
    }
}
