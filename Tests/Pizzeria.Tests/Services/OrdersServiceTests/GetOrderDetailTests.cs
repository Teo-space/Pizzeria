using FluentAssertions;
using Microsoft.Extensions.DependencyInjection;
using Pizzeria.Domain.Enums;
using Pizzeria.Domain.Orders;
using Pizzeria.Interfaces.Services;
using Pizzeria.Persistence;
using Pizzeria.Persistence.DbContexts;
using Pizzeria.Persistence.SeedWork;
using Pizzeria.Rest.Input.GetOrderDetail;
using Pizzeria.Services;

namespace Pizzeria.Tests.Services.OrdersServiceTests;

internal class GetOrderDetailTests
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

    private void InitData(PizzeriaDbContext pizzeriaDbContext)
    {
        var product = pizzeriaDbContext.Products.First();

        orderClient = new OrderClient()
        {
            Phone = +7_908_123_4567,
            Email = "name.surname.city@gmail.com",
            Name = "Иван",
            SurName = "Иванов",
            Patronymic = "Иванович",
        };

        var shop = pizzeriaDbContext.Shops.First();
        orderShop = new OrderShop()
        {
            ShopId = shop.ShopId,
            Name = shop.Name,

            Address = new OrderShopAddress()
            {
                City = shop.Address.City,
                Street = shop.Address.Street,
                House = shop.Address.House,
                Building = shop.Address.Building,
                Office = shop.Address.Office,
            }
        };

        orderDelivery = new OrderDelivery()
        {
            TypeId = DeliveryTypeId,
            Status = DeliveryStatuses.Pending,
            Start = DateTime.Now.AddHours(-6),
            End = DateTime.Now.AddHours(-3),

            Address = new OrderDeliveryAddress()
            {
                City = "Москва",
                Street = "Ленинская",
                House = "52",
                Apartment = "201"
            }
        };

        orderPayment = new OrderPayment()
        {
            Type = PaymentTypes.CashToCourier,
        };

        order = new Order(orderClient, orderShop, orderDelivery, orderPayment);
        orderPosition = order.AddPosition(product, 5);

        pizzeriaDbContext.Orders.Add(order);
        pizzeriaDbContext.SaveChanges();
        OrderId = order.OrderId;
    }

    int ShopId = (int)MainShops.Main;
    int DeliveryTypeId = (int)DeliveryTypes.CourierDelivery;
    Ulid OrderId;

    Order order;
    OrderPosition orderPosition;
    OrderClient orderClient;
    OrderShop orderShop;
    OrderDelivery orderDelivery;
    OrderPayment orderPayment;


    [Test]
    public async Task OkTest()
    {
        var input = new GetOrderDetailInput
        {
            OrderId = OrderId
        };

        var result = await ordersService.GetOrderDetail(input);
        result.Should().NotBeNull();

        //--------------------------------------------------------------------------------------
        result.Date.Should().NotBeNull();
        result.Date.Created.Should().Be(order.Date.Created.ToString());
        result.Date.Modified.Should().Be(order.Date.Modified.ToString());
        result.Date.Ready.Should().Be(order.Date.Ready.ToString());
        //--------------------------------------------------------------------------------------
        result.Client.Should().NotBeNull();
        result.Client.Phone.Should().Be(order.Client.Phone);
        result.Client.Email.Should().Be(order.Client.Email);
        result.Client.Name.Should().Be(order.Client.Name);
        result.Client.SurName.Should().Be(order.Client.SurName);
        result.Client.Patronymic.Should().Be(order.Client.Patronymic);
        //--------------------------------------------------------------------------------------
        result.Delivery.Should().NotBeNull();
        result.Delivery.Address.Should().NotBeNull();

        result.Delivery.TypeId.Should().Be(order.Delivery.TypeId);
        result.Delivery.Status.Should().Be(order.Delivery.Status);
        result.Delivery.Start.Should().Be(order.Delivery.Start.ToString());
        result.Delivery.End.Should().Be(order.Delivery.End.ToString());

        result.Delivery.Address.City.Should().Be(order.Delivery.Address.City);
        result.Delivery.Address.Street.Should().Be(order.Delivery.Address.Street);
        result.Delivery.Address.House.Should().Be(order.Delivery.Address.House);
        result.Delivery.Address.Apartment.Should().Be(order.Delivery.Address.Apartment);
        result.Delivery.Address.Entrance.Should().Be(order.Delivery.Address.Entrance);
        result.Delivery.Address.Floor.Should().Be(order.Delivery.Address.Floor);
        //--------------------------------------------------------------------------------------
        result.Payment.Type.Should().Be(order.Payment.Type);
        result.Payment.Sum.Should().Be(order.Payment.Sum);
        result.Payment.Payed.Should().Be(order.Payment.Payed.ToString());
        result.Payment.IsPayed.Should().Be(order.Payment.IsPayed);
        //--------------------------------------------------------------------------------------
        result.Shop.Should().NotBeNull();
        result.Shop.Address.Should().NotBeNull();

        result.Shop.ShopId.Should().Be(order.Shop.ShopId);
        result.Shop.Name.Should().Be(order.Shop.Name);

        result.Shop.Address.City.Should().Be(order.Shop.Address.City);
        result.Shop.Address.Street.Should().Be(order.Shop.Address.Street);
        result.Shop.Address.House.Should().Be(order.Shop.Address.House);
        result.Shop.Address.Building.Should().Be(order.Shop.Address.Building);
        result.Shop.Address.Office.Should().Be(order.Shop.Address.Office);
        //--------------------------------------------------------------------------------------
        //--------------------------------------------------------------------------------------
        var position = result.Positions.First();
        position.Should().NotBeNull();
        position.OrderPositionId.Should().Be(orderPosition.OrderPositionId);
        position.ProductName.Should().Be(orderPosition.Product.Name);
        position.Quanity.Should().Be(orderPosition.Quanity);
        position.Price.Should().Be(orderPosition.Price);
        //--------------------------------------------------------------------------------------

        Console.WriteLine(result);
        Console.WriteLine(position);
    }

}
