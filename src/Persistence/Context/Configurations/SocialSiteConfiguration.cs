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
    public partial class SocialSiteConfiguration : IEntityTypeConfiguration<SocialSite>
    {
        public void Configure(EntityTypeBuilder<SocialSite> entity)
        {
            entity.ToTable("Social_sites");

            entity.HasIndex(e => e.SiteName, "site_name")
                .IsUnique();

            entity.Property(e => e.Id)
                .HasColumnType("smallint(4) unsigned zerofill")
                .ValueGeneratedNever()
                .HasColumnName("id");

            entity.Property(e => e.Category)
                .IsRequired()
                .HasColumnType("enum('Chatting','Gaming','Social Media','Personal','Other')")
                .HasColumnName("category");

            entity.Property(e => e.Link)
                .HasMaxLength(200)
                .HasColumnName("link");

            entity.Property(e => e.SiteName)
                .IsRequired()
                .HasMaxLength(200)
                .HasColumnName("site_name");

            entity.Property(e => e.Url)
                .HasMaxLength(200)
                .HasColumnName("url");

            OnConfigurePartial(entity);
        }

        partial void OnConfigurePartial(EntityTypeBuilder<SocialSite> entity);
    }
}