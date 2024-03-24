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
            .UseSqlite("DataSource=file::memory:?cache=shared").Options;
            //.UseSqlite("DataSource=file.db").Options;

        pizzeriaDbContext = new PizzeriaDbContext(Options);
    }

    [TearDown]
    public void TearDown()
    {
        pizzeriaDbContext.Dispose();
    }

    [Test]
    public async Task Test()
    {
        pizzeriaDbContext.DeliveryTypes.Count();

        pizzeriaDbContext.Orders.Count();
        pizzeriaDbContext.OrderPositions.Count();

        pizzeriaDbContext.ProductTypes.Count();
        pizzeriaDbContext.Products.Count();

        pizzeriaDbContext.Shops.Count();

    }
}
