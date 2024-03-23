namespace Pizzeria.Tests.Persistence;

using Microsoft.EntityFrameworkCore;
using Pizzeria.Persistence.DbContexts;


[TestFixture]
internal class PizzeriaDbContextTests
{
    PizzeriaDbContext pizzeriaDbContext;

    [SetUp]
    public void Setup()
    {
        var Options = new DbContextOptionsBuilder<PizzeriaDbContext>()
            //.UseSqlServer($@"Data Source=(LocalDb)\MSSQLLocalDB; Database=DbContext_{Guid.NewGuid()}").Options;
            //.UseSqlServer($@"Data Source=(LocalDb)\MSSQLLocalDB; Initial Catalog=DbContext_{Guid.NewGuid()}").Options;
            .UseSqlite("DataSource=file::memory:?cache=shared").Options;
            //.UseSqlite("DataSource=file.db").Options;

        pizzeriaDbContext = new PizzeriaDbContext(Options);
        //pizzeriaDbContext.Database.EnsureDeleted();
        //pizzeriaDbContext.Database.EnsureCreated();
    }

    [TearDown]
    public void TearDown()
    {
        pizzeriaDbContext.Dispose();
    }

    [Test]
    public async Task Test()
    {
        var result = pizzeriaDbContext.Orders.Count();
        Console.WriteLine(result);
    }
}
