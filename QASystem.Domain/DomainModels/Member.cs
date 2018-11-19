using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using QASystem.Models;
using QASystem.Models.DomainModels;
using System;

namespace QASystem.Domain.DomainModels
{
    public class Member : Entity
    {
        protected Member(Guid id) : base(id)
        {
        }

        public string Username { get; set; }

        public DateTime DOB { get; set; }

        public string Email { get; set; }

        public Guid AspNetUserId { get; set; }
        public virtual SystemUser AspNetUser { get; set; }
    }

    public partial class QASystemDbContext
    {
        public DbSet<Member> Members { get; set; }
    }

    public class MemberConfiguration : IEntityTypeConfiguration<Member>
    {
        public void Configure(EntityTypeBuilder<Member> builder)
        {
            builder.HasKey(n => n.Id);
            builder.HasAlternateKey(n => n.Email);

            builder.ToTable("Member", Constant.Schema);
        }
    }
}