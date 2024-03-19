using Microsoft.EntityFrameworkCore;

namespace VehicleTable;

public partial class ApplicationContext : DbContext
{
    private readonly string _connectionString = "Server=.; DATABASE=VehiclesDbTemp; Integrated Security=True; MultipleActiveResultSets=True; TrustServerCertificate=true";

    public ApplicationContext()
    {
    }

    public ApplicationContext(DbContextOptions<ApplicationContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Vehicle> Vehicles { get; set; }

    //Здесь я осознанно захардкодил строку, хотя лучше было бы использовать механизм настроек через appsettings
    //или виртуальные переменные окружения среды(dotenv)
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) => optionsBuilder.UseSqlServer(_connectionString);
}
