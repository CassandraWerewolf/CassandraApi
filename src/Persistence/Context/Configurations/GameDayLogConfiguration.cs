// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore;
using Persistence.Context;
using Persistence;
using System;

#nullable disable

namespace Persistence.Context.Configurations
{
    public partial class GameDayLogConfiguration : IEntityTypeConfiguration<GameDayLog>
    {
        public void Configure(EntityTypeBuilder<GameDayLog> entity)
        {
            entity.ToTable("Game_day_log");

            entity.Property(e => e.Id)
                .HasColumnType("int(11)")
                .ValueGeneratedNever()
                .HasColumnName("id");

            entity.Property(e => e.ChangeTime)
                .HasColumnType("datetime")
                .HasColumnName("change_time");

            entity.Property(e => e.Day)
                .HasColumnType("int(11)")
                .HasColumnName("day");

            entity.Property(e => e.GameId)
                .HasColumnType("int(11)")
                .HasColumnName("game_id");

            entity.Property(e => e.Phase)
                .IsRequired()
                .HasColumnType("enum('day','night')")
                .HasColumnName("phase")
                .HasDefaultValueSql("'night'");

            OnConfigurePartial(entity);
        }

        partial void OnConfigurePartial(EntityTypeBuilder<GameDayLog> entity);
    }
}
