﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore;
using Persistence.Context;
using Persistence;
using System;

#nullable disable

namespace Persistence.Context.Configurations
{
    public partial class RoleConfiguration : IEntityTypeConfiguration<Role>
    {
        public void Configure(EntityTypeBuilder<Role> entity)
        {
            entity.Property(e => e.Id)
                .HasColumnType("int(2) unsigned zerofill")
                .ValueGeneratedNever()
                .HasColumnName("id");

            entity.Property(e => e.Type)
                .IsRequired()
                .HasMaxLength(50)
                .HasColumnName("type")
                .HasDefaultValueSql("''");

            OnConfigurePartial(entity);
        }

        partial void OnConfigurePartial(EntityTypeBuilder<Role> entity);
    }
}