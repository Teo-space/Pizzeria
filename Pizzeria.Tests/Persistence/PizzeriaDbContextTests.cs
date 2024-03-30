﻿namespace Pizzeria.Tests.Persistence;

using Pizzeria.Persistence.DbContexts;


[TestFixture]
internal class PizzeriaDbContextTests
{
    PizzeriaDbContext pizzeriaDbContext;

    [SetUp]
    public void Setup()
    {
        pizzeriaDbContext = DbContextFactory.GetPizzeriaDbContext();
    }

    [TearDown]
    public void TearDown()
    {
        pizzeriaDbContext.Dispose();
    }


    [Test]
    public async Task AEnsureCreated()
    {
        pizzeriaDbContext.Database.EnsureCreated();
    }

    [Test]
    public async Task TestDeliveryTypes()
    {
        pizzeriaDbContext.DeliveryTypes.Count();
        pizzeriaDbContext.DeliveryTypes.ToList();
    }

    [Test]
    public async Task TestOrders()
    {
        pizzeriaDbContext.Orders.Count();
        pizzeriaDbContext.Orders.ToList();
    }

     [Test]
    public async Task TestOrderPositions()
    {
        pizzeriaDbContext.OrderPositions.Count();
        pizzeriaDbContext.OrderPositions.ToList();
    }

    [Test]
    public async Task TestProductTypes()
    {
        pizzeriaDbContext.ProductTypes.Count();
        pizzeriaDbContext.ProductTypes.ToList();
    }

    [Test]
    public async Task TestProduct()
    {
        pizzeriaDbContext.Products.Count();
        pizzeriaDbContext.Products.ToList();
    }

    [Test]
    public async Task TestShops()
    {
        pizzeriaDbContext.Shops.Count();
        pizzeriaDbContext.Shops.ToList();
    }




}
