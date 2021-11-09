namespace Application.Common.Interfaces;

public interface IWerewolfContext
{
    Task<int> SaveChangesAsync(CancellationToken cancellationToken);

    DbSet<AmRole> AmRoles { get; set; }
    DbSet<AmTemplate> AmTemplates { get; set; }
    DbSet<AutoDusk> AutoDusks { get; set; }
    DbSet<Bio> Bios { get; set; }
    DbSet<CcInfo> CcInfos { get; set; }
    DbSet<CcPlayer> CcPlayers { get; set; }
    DbSet<ChatMessageAction> ChatMessageActions { get; set; }
    DbSet<ChatMessage> ChatMessages { get; set; }
    DbSet<ChatRoom> ChatRooms { get; set; }
    DbSet<ChatUser> ChatUsers { get; set; }
    DbSet<Exit> Exits { get; set; }
    DbSet<GameDayLog> GameDayLogs { get; set; }
    DbSet<GameOrder> GameOrders { get; set; }
    DbSet<Game> Games { get; set; }
    DbSet<GameSeries> GameSeries { get; set; }
    DbSet<ItemOrder> ItemOrders { get; set; }
    DbSet<Item> Items { get; set; }
    DbSet<ItemTemplate> ItemTemplates { get; set; }
    DbSet<Location> Locations { get; set; }
    DbSet<LocExit> LocExits { get; set; }
    DbSet<MiscUser> MiscUsers { get; set; }
    DbSet<Moderator> Moderators { get; set; }
    DbSet<MoveOrder> MoveOrders { get; set; }
    DbSet<PhysicsProcessing> PhysicsProcessings { get; set; }
    DbSet<Player> Players { get; set; }
    DbSet<PostCollectSlot> PostCollectSlots { get; set; }
    DbSet<Post> Posts { get; set; }
    DbSet<Replacement> Replacements { get; set; }
    DbSet<Role> Roles { get; set; }
    DbSet<SocialSite> SocialSites { get; set; }
    DbSet<SocialUser> SocialUsers { get; set; }
    DbSet<Stat> Stats { get; set; }
    DbSet<Tally> Tallies { get; set; }
    DbSet<Timezone> Timezones { get; set; }
    DbSet<UpdateCalendar> UpdateCalendars { get; set; }
    DbSet<User> Users { get; set; }
    DbSet<UsersNgram> UsersNgrams { get; set; }
    DbSet<Vote> Votes { get; set; }
    DbSet<WolfyAward> WolfyAwards { get; set; }
    DbSet<WolfyGame> WolfyGames { get; set; }
    DbSet<WolfyPlayer> WolfyPlayers { get; set; }
    DbSet<Wotw> Wotws { get; set; }
}
