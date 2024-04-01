using Mapster;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Pizzeria.Domain.Deliveries;
using Pizzeria.Domain.Orders;
using Pizzeria.Services.Interfaces.Repositories;
using Pizzeria.Services.Interfaces.Services;
using Pizzeria.Services.Models.Orders.GetOrderDetail;
using Pizzeria.Services.Models.Orders.OrderCheckOut.Input;

namespace Pizzeria.Services;


internal class OrdersService(
    ILogger<OrdersService> logger,
    IRepository repository, 
    IReadOnlyRepository readOnlyRepository, 
    IUnitOfWork unitOfWork)
    : IOrdersService
{

    public async Task<Ulid> OrderCheckOut(OrderInputModel inputModel)
    {
        var positionsIds = inputModel.Positions.Select(x => x.ProductId).ToList();
        if(!positionsIds.Any())
        {
            throw new Exception("Список позиций пуст");
        }

        var products = await readOnlyRepository.Products
            .Include(x => x.ProductType)
            .Where(x => positionsIds.Contains(x.ProductId))
            .ToListAsync();

        if(!products.Any() || products.Count != positionsIds.Count)
        {
            throw new Exception("Некоторые позиции не были найдены");
        }
        var errors = products.Where(x => !positionsIds.Contains(x.ProductId));
        if (errors.Any())
        {
            throw new Exception("Товар не найден");
        }

        var shop = await readOnlyRepository.Shops
            .FirstOrDefaultAsync(x => x.ShopId == inputModel.Shop.ShopId)
            ?? throw new Exception($"Магазин '{inputModel.Shop.ShopId}' не найден");

        var orderClient = new OrderClient()
        {
            Phone = inputModel.Client.Phone,
            Email = inputModel.Client.Email,
            Name = inputModel.Client.Name,
            SurName = inputModel.Client.SurName,
            Patronymic = inputModel.Client.Patronymic,
        };
        
        var orderShop = new OrderShop()
        {
            ShopId = shop.ShopId,
            Name = shop.Name,

            Address = new Domain.Shops.OrderShopAddress()
            {
                City = shop.Address.City,
                Street = shop.Address.Street,
                House = shop.Address.House,
                Building = shop.Address.Building,
                Office = shop.Address.Office,
            }
        };

        var orderDelivery = new OrderDelivery()
        {
            TypeId = inputModel.Delivery.DeliveryTypeId,
            Status = DeliveryStatuses.Pending,
            Address = new OrderDeliveryAddress()
            {
                City = inputModel.Delivery.Address.City,
                Street = inputModel.Delivery.Address.Street,
                House = inputModel.Delivery.Address.House,
                Apartment = inputModel.Delivery.Address.Apartment,
            }
        };

        var orderPayment = new OrderPayment()
        {
            Type = inputModel.PaymentType,
        };

        var order = new Order(orderClient, orderShop, orderDelivery, orderPayment);

        foreach(var position in inputModel.Positions)
        {
            var product = products.First(x => x.ProductId == position.ProductId);
            order.AddPosition(product, position.Quantity);
        }

        repository.Orders.Add(order);
        await unitOfWork.SaveChangesAsync();

        return order.OrderId;
    }

    public async Task<OrderModel> GetOrderDetail(Ulid orderId)
    {
        var order = await readOnlyRepository.Orders
            .Where(x => x.OrderId == orderId)
            .Include(x => x.Positions)
            .ThenInclude(x => x.Product)
            .FirstOrDefaultAsync()
            ?? throw new Exception("Список позиций пуст");

        var orderModel = order.Adapt<OrderModel>();

        return orderModel;
    }

}
