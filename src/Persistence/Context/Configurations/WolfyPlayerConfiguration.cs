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
    public partial class WolfyPlayerConfiguration : IEntityTypeConfiguration<WolfyPlayer>
    {
        public void Configure(EntityTypeBuilder<WolfyPlayer> entity)
        {
            entity.HasKey(e => new { e.AwardId, e.UserId, e.Year })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0, 0 });

            entity.ToTable("Wolfy_players");

            entity.Property(e => e.AwardId)
                .HasColumnType("int(2) unsigned zerofill")
                .HasColumnName("award_id");

            entity.Property(e => e.UserId)
                .HasColumnType("int(3) unsigned zerofill")
                .HasColumnName("user_id");

            entity.Property(e => e.Year)
                .HasColumnType("int(4)")
                .HasColumnName("year");

            entity.Property(e => e.AwardPost)
                .HasColumnType("int(10)")
                .HasColumnName("award_post");

            OnConfigurePartial(entity);
        }

        partial void OnConfigurePartial(EntityTypeBuilder<WolfyPlayer> entity);
    }
}
