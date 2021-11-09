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
    public partial class GameConfiguration : IEntityTypeConfiguration<Game>
    {
        public void Configure(EntityTypeBuilder<Game> entity)
        {
            entity.HasIndex(e => e.EndDate, "end_date_idx");

            entity.HasIndex(e => e.StartDate, "start_date_idx");

            entity.HasIndex(e => e.Status, "status_idx");

            entity.HasIndex(e => e.ThreadId, "thread_id")
                .IsUnique();

            entity.HasIndex(e => e.Winner, "winner_idx");

            entity.Property(e => e.Id)
                .HasColumnType("int(4) unsigned zerofill")
                .ValueGeneratedNever()
                .HasColumnName("id");

            entity.Property(e => e.AliasDisplay)
                .IsRequired()
                .HasColumnType("enum('None','Private','Public')")
                .HasColumnName("alias_display")
                .HasDefaultValueSql("'None'");

            entity.Property(e => e.AllowNightfall)
                .IsRequired()
                .HasColumnType("enum('Yes','No')")
                .HasColumnName("allow_nightfall")
                .HasDefaultValueSql("'Yes'");

            entity.Property(e => e.AllowNolynch)
                .IsRequired()
                .HasColumnType("enum('Yes','No')")
                .HasColumnName("allow_nolynch")
                .HasDefaultValueSql("'Yes'");

            entity.Property(e => e.AproxLength)
                .HasColumnType("int(11)")
                .HasColumnName("aprox_length");

            entity.Property(e => e.AutoDeadline)
                .HasColumnType("time")
                .HasColumnName("auto_deadline")
                .HasComment("if this is set dawn and dusk will be automatically posted by cassy.  This time is the mimimum length that day should last on day1 and if there is a delay posting a deadline.");

            entity.Property(e => e.AutoVt)
                .IsRequired()
                .HasColumnType("enum('No','lhv','lhlv')")
                .HasColumnName("auto_vt")
                .HasDefaultValueSql("'No'");

            entity.Property(e => e.AutomodId)
                .HasColumnType("int(11)")
                .HasColumnName("automod_id");

            entity.Property(e => e.AutomodNextdeadline)
                .HasColumnType("datetime")
                .HasColumnName("automod_nextdeadline")
                .HasComment("used by any game with auto dawn/dusk selected to indicate when the next one should be posted.");

            entity.Property(e => e.AutomodPhaseChange)
                .HasColumnType("datetime")
                .HasColumnName("automod_phase_change");

            entity.Property(e => e.AutomodRunning)
                .HasColumnType("datetime")
                .HasColumnName("automod_running");

            entity.Property(e => e.AutomodState)
                .HasMaxLength(50)
                .HasColumnName("automod_state");

            entity.Property(e => e.AutomodTimestamp)
                .HasColumnType("datetime")
                .HasColumnName("automod_timestamp");

            entity.Property(e => e.AutomodWeekend).HasColumnName("automod_weekend");

            entity.Property(e => e.CalendarId)
                .HasColumnType("text")
                .HasColumnName("calendar_id");

            entity.Property(e => e.Complex)
                .IsRequired()
                .HasColumnType("enum('','Newbie','Low','Medium','High','Extreme','Kima')")
                .HasColumnName("complex");

            entity.Property(e => e.DawnChatReset)
                .IsRequired()
                .HasColumnType("enum('No','Yes')")
                .HasColumnName("dawn_chat_reset")
                .HasDefaultValueSql("'No'");

            entity.Property(e => e.Day)
                .HasColumnType("int(11)")
                .HasColumnName("day");

            entity.Property(e => e.DayLength)
                .HasColumnType("time")
                .HasColumnName("day_length");

            entity.Property(e => e.DeadlineSpeed)
                .IsRequired()
                .HasColumnType("enum('Standard','Fast')")
                .HasColumnName("deadline_speed")
                .HasDefaultValueSql("'Standard'")
                .HasComment("If Standard then lynch_time and na_deadline should be set, if Fast then day_lenght and night_length should be set");

            entity.Property(e => e.Description)
                .HasColumnType("text")
                .HasColumnName("description");

            entity.Property(e => e.EndDate)
                .HasColumnType("datetime")
                .HasColumnName("end_date");

            entity.Property(e => e.Expired)
                .IsRequired()
                .HasColumnType("enum('0','1')")
                .HasColumnName("expired")
                .HasDefaultValueSql("'0'");

            entity.Property(e => e.GameOrder)
                .IsRequired()
                .HasColumnType("enum('off','on')")
                .HasColumnName("game_order")
                .HasDefaultValueSql("'off'");

            entity.Property(e => e.LynchTime)
                .HasColumnType("time")
                .HasColumnName("lynch_time");

            entity.Property(e => e.MaxPlayers)
                .HasColumnType("int(11)")
                .HasColumnName("max_players");

            entity.Property(e => e.MissingHr)
                .HasColumnType("int(3)")
                .HasColumnName("missing_hr")
                .HasComment("moderator will be notified if a player hasn't posted in x amount of hours");

            entity.Property(e => e.NaDeadline)
                .HasColumnType("time")
                .HasColumnName("na_deadline");

            entity.Property(e => e.NightLength)
                .HasColumnType("time")
                .HasColumnName("night_length");

            entity.Property(e => e.Number)
                .HasColumnType("int(4)")
                .HasColumnName("number");

            entity.Property(e => e.ParentGameId)
                .HasColumnType("int(4)")
                .HasColumnName("parent_game_id");

            entity.Property(e => e.Phase)
                .IsRequired()
                .HasColumnType("enum('day','night')")
                .HasColumnName("phase")
                .HasDefaultValueSql("'night'");

            entity.Property(e => e.PhysByAlias)
                .IsRequired()
                .HasColumnType("enum('No','Yes')")
                .HasColumnName("phys_by_alias")
                .HasDefaultValueSql("'No'");

            entity.Property(e => e.PhysItemLimit)
                .HasColumnType("tinyint(3) unsigned")
                .HasColumnName("phys_item_limit");

            entity.Property(e => e.PhysMoveLimit)
                .HasColumnType("tinyint(3) unsigned")
                .HasColumnName("phys_move_limit");

            entity.Property(e => e.PhysResetMoves)
                .IsRequired()
                .HasColumnType("enum('none','dawn','dusk')")
                .HasColumnName("phys_reset_moves")
                .HasDefaultValueSql("'none'");

            entity.Property(e => e.PlayerListId)
                .HasColumnType("int(11)")
                .HasColumnName("player_list_id");

            entity.Property(e => e.SeriesId)
                .HasColumnType("int(5)")
                .HasColumnName("series_id");

            entity.Property(e => e.StartDate)
                .HasColumnType("datetime")
                .HasColumnName("start_date")
                .HasDefaultValueSql("'0000-00-00 00:00:00'");

            entity.Property(e => e.Status)
                .IsRequired()
                .HasColumnType("enum('Finished','In Progress','Sign-up','Scheduled','Sub-Thread','Unknown')")
                .HasColumnName("status")
                .HasDefaultValueSql("'In Progress'");

            entity.Property(e => e.Swf)
                .IsRequired()
                .HasColumnType("enum('Yes','No')")
                .HasColumnName("swf")
                .HasDefaultValueSql("'No'")
                .HasComment("Used to specify that the game starts when full");

            entity.Property(e => e.ThreadId)
                .HasColumnType("int(7)")
                .HasColumnName("thread_id");

            entity.Property(e => e.Title)
                .IsRequired()
                .HasMaxLength(200)
                .HasColumnName("title")
                .HasDefaultValueSql("''");

            entity.Property(e => e.UpdatedTally).HasColumnName("updated_tally");

            entity.Property(e => e.VoteByAlias)
                .IsRequired()
                .HasColumnType("enum('No','Yes')")
                .HasColumnName("vote_by_alias")
                .HasDefaultValueSql("'No'");

            entity.Property(e => e.Winner)
                .IsRequired()
                .HasColumnType("enum('','Evil','Good','Other')")
                .HasColumnName("winner")
                .HasDefaultValueSql("''");

            OnConfigurePartial(entity);
        }

        partial void OnConfigurePartial(EntityTypeBuilder<Game> entity);
    }
}
