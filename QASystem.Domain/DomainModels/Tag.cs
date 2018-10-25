using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace QASystem.Models.DomainModels
{
    public class Tag : Entity
    {
        protected Tag(Guid id) : base(id)
        {
        }

        public string Name { get; set; }

        public ICollection<QuestionTag> QuestionTags { get; set; }
    }

    public partial class QASystemDbContext
    {
        public DbSet<Tag> Tags { get; set; }
    }

    public class TagConfiguration : IEntityTypeConfiguration<Tag>
    {
        public void Configure(EntityTypeBuilder<Tag> builder)
        {
            builder.HasKey(n => n.Id);
            builder.Property(n => n.Name).IsRequired();

            builder.ToTable("Tag", Constant.Schema);
        }
    }

}
