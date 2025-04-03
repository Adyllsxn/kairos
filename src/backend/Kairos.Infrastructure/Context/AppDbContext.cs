namespace Kairos.Infrastructure.Context;
public class AppDbContext(DbContextOptions<AppDbContext> options) : DbContext(options)
{
    public DbSet<TipoEventoEntity> TipoEventos {get; set; } = null!;

    protected override void OnModelCreating(ModelBuilder modelBuilder) => modelBuilder.ApplyConfigurationsFromAssembly(typeof(InfrastructureDI).Assembly);
}
