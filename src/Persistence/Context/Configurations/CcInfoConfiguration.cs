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
    public partial class CcInfoConfiguration : IEntityTypeConfiguration<CcInfo>
    {
        public void Configure(EntityTypeBuilder<CcInfo> entity)
        {
            entity.HasKey(e => e.GameId)
                .HasName("PRIMARY");

            entity.ToTable("CC_info");

            entity.Property(e => e.GameId)
                .HasColumnType("smallint(4) unsigned zerofill")
                .ValueGeneratedNever()
                .HasColumnName("game_id");

            entity.Property(e => e.ChallengerId)
                .HasColumnType("smallint(4)")
                .HasColumnName("challenger_id");

            entity.Property(e => e.ClaimTime)
                .HasColumnType("datetime")
                .HasColumnName("claim_time");

            entity.Property(e => e.DescError)
                .HasColumnType("text")
                .HasColumnName("desc_error");

            entity.Property(e => e.TypeError)
                .HasColumnType("enum('game','player')")
                .HasColumnName("type_error");

            entity.Property(e => e.UserId)
                .HasColumnType("smallint(3) unsigned zerofill")
                .HasColumnName("user_id");

            OnConfigurePartial(entity);
        }

        partial void OnConfigurePartial(EntityTypeBuilder<CcInfo> entity);
    }
}