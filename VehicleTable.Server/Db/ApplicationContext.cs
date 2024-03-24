using Microsoft.EntityFrameworkCore;

namespace VehicleTable;

public partial class ApplicationContext : DbContext
{
    private readonly string _connectionString;

    public ApplicationContext(Config config)
    {
        _connectionString = config.ConnectionString;
    }

    public ApplicationContext(DbContextOptions<ApplicationContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Vehicle> Vehicles { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) => optionsBuilder.UseSqlServer(_connectionString);
}
