namespace Persistence.Context
{
    public class ApplicationDbContext : DbContext, IApplicationDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        public DbSet<Product> Products => Set<Product>();

        public override async Task<int> SaveChangesAsync(CancellationToken cancellationToken = new CancellationToken()) => await base.SaveChangesAsync(cancellationToken);
    }
}
