using FluentAssertions;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Pizzeria.Domain.Deliveries;
using Pizzeria.Domain.Payments;
using Pizzeria.Domain.Products;
using Pizzeria.Domain.Shops;
using Pizzeria.Persistence;
using Pizzeria.Persistence.DbContexts;
using Pizzeria.Persistence.SeedWork;
using Pizzeria.Services;
using Pizzeria.Services.Interfaces.Services;
using Pizzeria.Services.Models.Orders.OrderCheckOut.Input;

namespace Pizzeria.Tests.Services.OrdersServiceTests.OrderCheckOutTests;



internal class OrderCheckOutTests
{
    PizzeriaDbContext pizzeriaDbContext { get; set; }
    IServiceScope serviceScope { get; set; }
    IOrdersService ordersService { get; set; }

    [SetUp]
    public void Setup()
    {
        serviceScope = new ServiceCollection()
            .AddTestInfrastructure()
            .AddTestServices()
            .AddLogging()
            .BuildServiceProvider(validateScopes: true)
            .CreateScope();

        pizzeriaDbContext = serviceScope.ServiceProvider.GetRequiredService<PizzeriaDbContext>();

        ApplySeedsToContext.ApplySeeds(pizzeriaDbContext);

        InitData(pizzeriaDbContext);

        ordersService = serviceScope.ServiceProvider.GetRequiredService<IOrdersService>();
    }

    [TearDown]
    public void Dispose()
    {
        serviceScope?.Dispose();
        pizzeriaDbContext?.Dispose();
    }

    void InitData(PizzeriaDbContext pizzeriaDbContext)
    {
        var productType = new ProductType
        {
            Name = "Пицца",
            Description = "Вкуснейшая пицца",
            NeedCooking = true
        };
        pizzeriaDbContext.ProductTypes.Add(productType);
        pizzeriaDbContext.SaveChanges();
        ProductTypeId = productType.ProductTypeId;

        var product = new Product
        {
            ProductTypeId = productType.ProductTypeId,
            Name = "Гавайская пицца",
            Description = "куриное филе, ветчина, ананасы консервированные, соус коктейль, сыр моцарелла, грибы шампиньоны",
            Price = 850
        };

        pizzeriaDbContext.Products.Add(product);
        pizzeriaDbContext.SaveChanges();
        ProductId = product.ProductId;
    }

    Ulid ProductTypeId;
    Ulid ProductId;
    int ShopId = (int)MainShops.Main;
    int DeliveryTypeId = (int)DeliveryTypes.CourierDelivery;



    [Test]
    public async Task OkTest()
    {
        var input = new OrderInputModel()
        {
            Client = new OrderClientInputModel()
            {
                Phone = +7_908_123_4567,
                Email = "name.surname.city@gmail.com",
                Name = "Иван",
                SurName = "Иванов",
                Patronymic = "Иванович",
            },

            Shop = new OrderShopInputModel()
            {
                ShopId = ShopId,
            },

            Delivery = new OrderDeliveryInputModel()
            {
                DeliveryTypeId = DeliveryTypeId,
                Address = new OrderDeliveryAddressInputModel()
                {
                    City = "Москва",
                    Street = "Ленинская",
                    House = "52",
                    Apartment = "201"
                }
            },

            PaymentType = PaymentTypes.CardToCourier,

            Positions = new[]
            {
                new OrderBasketPositionInputModel()
                {
                    ProductId = ProductId,
                    Quantity = 1,
                }
            }
        };

        var orderId = await ordersService.OrderCheckOut(input);

        var order = pizzeriaDbContext.Orders
            .AsNoTracking()
            .Where(x => x.OrderId == orderId)
            .Include(x => x.Positions)
            .First();

        order.Positions.Should().NotBeNullOrEmpty();
        order.Positions.Should().HaveCount(1);
    }



}
