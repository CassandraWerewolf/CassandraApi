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
    public partial class ChatMessageActionConfiguration : IEntityTypeConfiguration<ChatMessageAction>
    {
        public void Configure(EntityTypeBuilder<ChatMessageAction> entity)
        {
            entity.ToTable("Chat_message_actions");

            entity.Property(e => e.Id)
                .HasColumnType("int(11)")
                .ValueGeneratedNever()
                .HasColumnName("id");

            entity.Property(e => e.MessageId)
                .HasColumnType("int(11)")
                .HasColumnName("message_id");

            entity.Property(e => e.Misc)
                .IsRequired()
                .HasColumnType("text")
                .HasColumnName("misc");

            entity.Property(e => e.TargetId)
                .HasColumnType("int(11)")
                .HasColumnName("target_id");

            entity.Property(e => e.TypeId)
                .HasColumnType("int(11)")
                .HasColumnName("type_id");

            OnConfigurePartial(entity);
        }

        partial void OnConfigurePartial(EntityTypeBuilder<ChatMessageAction> entity);
    }
}
