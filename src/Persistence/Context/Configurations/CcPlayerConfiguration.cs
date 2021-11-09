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
    public partial class CcPlayerConfiguration : IEntityTypeConfiguration<CcPlayer>
    {
        public void Configure(EntityTypeBuilder<CcPlayer> entity)
        {
            entity.HasKey(e => e.UserId)
                .HasName("PRIMARY");

            entity.ToTable("CC_players");

            entity.Property(e => e.UserId)
                .HasColumnType("smallint(4) unsigned zerofill")
                .ValueGeneratedNever()
                .HasColumnName("user_id");

            entity.Property(e => e.Team)
                .IsRequired()
                .HasMaxLength(50)
                .HasColumnName("team");

            OnConfigurePartial(entity);
        }

        partial void OnConfigurePartial(EntityTypeBuilder<CcPlayer> entity);
    }
}
