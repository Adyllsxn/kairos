namespace Kairos.Infrastructure.Abstractions.DI;
public static class InfrastructureDI
{
    public static void AddInfrastructureDI (this IServiceCollection services, IConfiguration configuration)
    {
        #region </Repository>
            services.AddScoped<IUnitOfWork, UnitOfWork>();
            services.AddScoped<ITipoEventoRepository, TipoEventoRepository>();
        #endregion

        #region </DbConnection>
            var connectionDbSqlServer = configuration.GetConnectionString(ConnectionStringContext.ConnectionSQLServer);
            services.AddDbContext<AppDbContext>(opt => {
                opt.UseSqlServer(connectionDbSqlServer, 
                m => m.MigrationsAssembly(typeof(AppDbContext).Assembly.FullName));
            });
        #endregion
    }
}
