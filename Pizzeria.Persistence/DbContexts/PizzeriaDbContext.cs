using Pizzeria.Persistence.DbContexts.Convertors;

namespace Pizzeria.Persistence.DbContexts;


internal class PizzeriaDbContext : DbContext
{
    public DbSet<DeliveryStatus> DeliveryStatuses { get; set; }
    public DbSet<DeliveryType> DeliveryTypes { get; set; }


    public DbSet<Order> Orders { get; set; }
    public DbSet<OrderPosition> OrderPositions { get; set; }


    public DbSet<PaymentType> PaymentTypes { get; set; }


    public DbSet<ProductType> ProductTypes { get; set; }
    public DbSet<Product> Products { get; set; }


    public DbSet<Shop> Shops { get; set; }



    public PizzeriaDbContext(DbContextOptions<PizzeriaDbContext> options) : base(options)
    {
        base.Database.EnsureCreated();
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        //optionsBuilder.UseUpperSnakeCaseNamingConvention();
        //optionsBuilder.EnableDetailedErrors();
        //optionsBuilder.EnableSensitiveDataLogging();
        optionsBuilder.LogTo(Console.WriteLine, minimumLevel: Microsoft.Extensions.Logging.LogLevel.Information);
    }

    protected override void ConfigureConventions(ModelConfigurationBuilder configurationBuilder)
    {
        configurationBuilder.Properties<Ulid>().HaveConversion<UlidToGuidConvertor>();
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
    }
}