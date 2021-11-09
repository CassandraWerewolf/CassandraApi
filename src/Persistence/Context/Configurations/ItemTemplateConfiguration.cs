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
    public partial class ItemTemplateConfiguration : IEntityTypeConfiguration<ItemTemplate>
    {
        public void Configure(EntityTypeBuilder<ItemTemplate> entity)
        {
            entity.ToTable("Item_templates");

            entity.HasIndex(e => e.GameId, "game_id");

            entity.Property(e => e.Id)
                .HasColumnType("int(5) unsigned zerofill")
                .ValueGeneratedNever()
                .HasColumnName("id");

            entity.Property(e => e.Description)
                .HasColumnType("text")
                .HasColumnName("description")
                .UseCollation("latin1_spanish_ci");

            entity.Property(e => e.GameId)
                .HasColumnType("int(4) unsigned zerofill")
                .HasColumnName("game_id");

            entity.Property(e => e.Mobility)
                .IsRequired()
                .HasColumnType("enum('fixed','heavy','mobile','nonphys')")
                .HasColumnName("mobility")
                .HasDefaultValueSql("'nonphys'");

            entity.Property(e => e.Name)
                .IsRequired()
                .HasMaxLength(60)
                .HasColumnName("name");

            entity.Property(e => e.RoomAlias)
                .HasMaxLength(50)
                .HasColumnName("room_alias");

            entity.Property(e => e.RoomColor)
                .HasMaxLength(7)
                .HasColumnName("room_color")
                .HasDefaultValueSql("'#000000'");

            entity.Property(e => e.RoomId)
                .HasColumnType("int(6)")
                .HasColumnName("room_id");

            entity.Property(e => e.Visibility)
                .IsRequired()
                .HasColumnType("enum('obvious','hide','conceal','invis')")
                .HasColumnName("visibility")
                .HasDefaultValueSql("'conceal'");

            OnConfigurePartial(entity);
        }

        partial void OnConfigurePartial(EntityTypeBuilder<ItemTemplate> entity);
    }
}
