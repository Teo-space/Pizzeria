using FluentAssertions;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Pizzeria.Domain.Deliveries;
using Pizzeria.Domain.Payments;
using Pizzeria.Domain.Shops;
using Pizzeria.Interfaces.Params.Orders.OrderCheckOut;
using Pizzeria.Interfaces.Services;
using Pizzeria.Persistence;
using Pizzeria.Persistence.DbContexts;
using Pizzeria.Persistence.SeedWork;
using Pizzeria.Services;

namespace Pizzeria.Tests.Services.OrdersServiceTests;



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

        ordersService = serviceScope.ServiceProvider.GetRequiredService<IOrdersService>();

        var product = pizzeriaDbContext.Products.First();
        ProductId = product.ProductId;
    }

    [TearDown]
    public void Dispose()
    {
        serviceScope?.Dispose();
        pizzeriaDbContext?.Dispose();
    }


    Ulid ProductId;
    int ShopId = (int)MainShops.Main;
    int DeliveryTypeId = (int)DeliveryTypes.CourierDelivery;



    [Test]
    public async Task OkTest()
    {
        var input = new OrderParam()
        {
            Client = new OrderClientParam()
            {
                Phone = +7_908_123_4567,
                Email = "name.surname.city@gmail.com",
                Name = "Иван",
                SurName = "Иванов",
                Patronymic = "Иванович",
            },

            Shop = new OrderShopParam()
            {
                ShopId = ShopId,
            },

            Delivery = new OrderDeliveryParam()
            {
                DeliveryTypeId = DeliveryTypeId,
                Address = new OrderDeliveryAddressParam()
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
                new OrderBasketPositionParam()
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
