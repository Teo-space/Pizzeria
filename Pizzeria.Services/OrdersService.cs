using Microsoft.EntityFrameworkCore;
using Pizzeria.Domain.Deliveries;
using Pizzeria.Domain.Orders;
using Pizzeria.Services.Interfaces.Repositories;
using Pizzeria.Services.Interfaces.Services;
using Pizzeria.Services.Models.Orders.OrderCreate.Input;

namespace Pizzeria.Services;


internal class OrdersService(
    IRepository repository, 
    IReadOnlyRepository readOnlyRepository, 
    IUnitOfWork unitOfWork)
    : IOrdersService
{

    public async Task<Ulid> OrderCheckOut(OrderInputModel inputModel)
    {
        var positionsIds = inputModel.Positions.Select(x => x.ProductId).ToList();

        var products = await readOnlyRepository.Products
            .Include(x => x.ProductType)
            .Where(x => positionsIds.Contains(x.ProductId))
            .ToListAsync();

        if(!products.All(x => positionsIds.Contains(x.ProductId)))
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
            TypeId = inputModel.Delivery.TypeId,
            Status = DeliveryStatus.Pending,
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



}
