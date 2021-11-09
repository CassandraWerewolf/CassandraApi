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
    public partial class VoteConfiguration : IEntityTypeConfiguration<Vote>
    {
        public void Configure(EntityTypeBuilder<Vote> entity)
        {
            entity.HasIndex(e => e.Valid, "valid");

            entity.Property(e => e.Id)
                .HasColumnType("int(11)")
                .ValueGeneratedNever()
                .HasColumnName("id");

            entity.Property(e => e.ArticleId)
                .HasColumnType("int(11)")
                .HasColumnName("article_id");

            entity.Property(e => e.Day)
                .HasColumnType("int(11)")
                .HasColumnName("day");

            entity.Property(e => e.Edited).HasColumnName("edited");

            entity.Property(e => e.GameId)
                .HasColumnType("int(11)")
                .HasColumnName("game_id");

            entity.Property(e => e.Misc)
                .HasColumnType("text")
                .HasColumnName("misc");

            entity.Property(e => e.Type)
                .IsRequired()
                .HasMaxLength(20)
                .HasColumnName("type");

            entity.Property(e => e.Valid)
                .IsRequired()
                .HasColumnName("valid")
                .HasDefaultValueSql("'1'");

            entity.Property(e => e.Votee)
                .HasColumnType("int(11)")
                .HasColumnName("votee");

            entity.Property(e => e.Voter)
                .HasColumnType("int(11)")
                .HasColumnName("voter");

            OnConfigurePartial(entity);
        }

        partial void OnConfigurePartial(EntityTypeBuilder<Vote> entity);
    }
}