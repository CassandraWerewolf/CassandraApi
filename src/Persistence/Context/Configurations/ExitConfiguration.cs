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
    public partial class ExitConfiguration : IEntityTypeConfiguration<Exit>
    {
        public void Configure(EntityTypeBuilder<Exit> entity)
        {
            entity.Property(e => e.Id)
                .HasColumnType("int(5) unsigned zerofill")
                .ValueGeneratedNever()
                .HasColumnName("id");

            entity.Property(e => e.Comment)
                .HasColumnType("text")
                .HasColumnName("comment");

            entity.Property(e => e.Created)
                .HasColumnType("datetime")
                .HasColumnName("created");

            entity.Property(e => e.GameId)
                .HasColumnType("int(4) unsigned zerofill")
                .HasColumnName("game_id");

            entity.Property(e => e.Name)
                .IsRequired()
                .HasMaxLength(60)
                .HasColumnName("name");

            entity.Property(e => e.TemplateId)
                .HasColumnType("int(5) unsigned zerofill")
                .HasColumnName("template_id");

            entity.Property(e => e.TravelText)
                .HasColumnType("text")
                .HasColumnName("travel_text");

            OnConfigurePartial(entity);
        }

        partial void OnConfigurePartial(EntityTypeBuilder<Exit> entity);
    }
}