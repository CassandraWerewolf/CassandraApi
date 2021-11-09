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
    public partial class WolfyAwardConfiguration : IEntityTypeConfiguration<WolfyAward>
    {
        public void Configure(EntityTypeBuilder<WolfyAward> entity)
        {
            entity.ToTable("Wolfy_awards");

            entity.Property(e => e.Id)
                .HasColumnType("int(2) unsigned zerofill")
                .ValueGeneratedNever()
                .HasColumnName("id");

            entity.Property(e => e.Award)
                .IsRequired()
                .HasMaxLength(50)
                .HasColumnName("award");

            OnConfigurePartial(entity);
        }

        partial void OnConfigurePartial(EntityTypeBuilder<WolfyAward> entity);
    }
}