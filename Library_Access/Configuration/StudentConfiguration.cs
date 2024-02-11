﻿using Library_Model.Entities.Tables;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;


namespace Library_Access.Configuration
{
    internal class StudentConfiguration : IEntityTypeConfiguration<Student>
    {
        public void Configure(EntityTypeBuilder<Student> builder)
        {
            builder.HasKey(I => I.Id);
            builder.Property(I => I.Id).UseIdentityColumn();
            builder.Property(I => I.Name).HasMaxLength(50).IsRequired();
            builder.Property(I => I.Surname).HasMaxLength(50).IsRequired();
        }
    }
}
