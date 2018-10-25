using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace QASystem.Models.DomainModels
{
    public class QuestionTag
    {
        public Guid QuestionId { get; set; }
        public virtual Question Question { get; set; }

        public Guid TagId { get; set; }
        public virtual Tag Tag { get; set; }
    }

    public partial class QASystemDbContext
    {
        public DbSet<QuestionTag> QuestionTags { get; set; }
    }

    public class QuestionTagConfiguration : IEntityTypeConfiguration<QuestionTag>
    {
        public void Configure(EntityTypeBuilder<QuestionTag> builder)
        {
            builder.HasKey(n => new { n.QuestionId, n.TagId });

            builder.ToTable("QuestionTag", Constant.Schema);
        }
    }

}
