using FluentAssertions;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Pizzeria.Domain.Deliveries;
using Pizzeria.Domain.Payments;
using Pizzeria.Domain.Products;
using Pizzeria.Domain.Shops;
using Pizzeria.Persistence;
using Pizzeria.Persistence.DbContexts;
using Pizzeria.Services;
using Pizzeria.Services.Interfaces.Services;
using Pizzeria.Services.Models.Orders.OrderCheckOut.Input;

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
            .BuildServiceProvider(validateScopes: true)
            .CreateScope();

        pizzeriaDbContext = serviceScope.ServiceProvider.GetRequiredService<PizzeriaDbContext>();
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
        var productType = new ProductType("Пицца", "Вкуснейшая пицца");
        pizzeriaDbContext.ProductTypes.Add(productType);
        pizzeriaDbContext.SaveChanges();

        var product = new Product(productType, "Гавайская пицца",
            "куриное филе, ветчина, ананасы консервированные, соус коктейль, сыр моцарелла, грибы шампиньоны") 
            {
                Price = 850
            };

        pizzeriaDbContext.Products.Add(product);
        pizzeriaDbContext.SaveChanges();

        var shop = new Shop("Пиццерия на улице Пролетарской")
        {
            Address = new ShopAddress()
            {
                City = "Москва",
                Street = "Пролетарская",
                House = "100",
                Building = "1В"
            }
        };
        pizzeriaDbContext.Shops.Add(shop);
        pizzeriaDbContext.SaveChanges();

        var deliveryType = new DeliveryType("Самовывоз", 0);
        pizzeriaDbContext.DeliveryTypes.Add(deliveryType);
        pizzeriaDbContext.SaveChanges();

        ProductTypeId = productType.ProductTypeId;
        ProductId = product.ProductId;
        ShopId = shop.ShopId;
        DeliveryTypeId = deliveryType.DeliveryTypeId;
    }

    Ulid ProductTypeId;
    Ulid ProductId;
    Ulid ShopId;
    Ulid DeliveryTypeId;



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
                TypeId = DeliveryTypeId,
                Address = new OrderDeliveryAddressInputModel()
                {
                    City = "Москва",
                    Street = "Ленинская",
                    House = "52",
                    Apartment = "201"
                }
            },
            PaymentType = PaymentType.CardInOffice,

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
