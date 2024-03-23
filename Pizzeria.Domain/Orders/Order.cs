using System.ComponentModel.DataAnnotations;

namespace Pizzeria.Domain.Orders;


/// <summary>
/// Заказ
/// </summary>
[Table("ORDER")]
[PrimaryKey(nameof(OrderId))]
public class Order : Aggregate
{
    private Order() { }
    public Order(OrderClient client, OrderShop shop, OrderDelivery delivery, OrderPayment payment
        //IReadOnlyCollection<BasketPosition> basketPositions
        )
    {
        OrderId = Ulid.NewUlid().ToGuid();
        Status = OrderStatus.Pending;

        Client = client;
        Shop = shop;
        Delivery = delivery;
        Payment = payment;

        Date.Created = DateTime.Now;
        Date.Modified = Date.Created;

        /*
        foreach (var basketPosition in basketPositions)
        {
            var position = new OrderPosition(this, basketPosition);
            this.Positions.Add(position);
        }
        */
        //Очистка корзины
    }

    /// <summary>
    /// ID Заказа
    /// </summary>
    [Column("ORDER_ID", Order = 1)]
    public Guid OrderId { get; private set; }

    /// <summary>
    /// Статус заказа
    /// </summary>
    [Column("ORDER_STATUS", Order = 2)]
    public OrderStatus Status { get; private set; }

    /// <summary>
    /// Даты создания, изменения и готовности
    /// </summary>
    [Required]
    public required Date Date { get; set; } = new Date();

    /// <summary>
    /// Информация о клиенте
    /// </summary>
    [Required]
    public OrderClient Client { get; private set; }

    /// <summary>
    /// Информация о доставке
    /// </summary>
    [Required]
    public OrderDelivery Delivery { get; private set; }
    /// <summary>
    /// Оплата
    /// </summary>
    [Required]
    public OrderPayment Payment { get; private set; }
    /// <summary>
    /// информация о магазине
    /// </summary>
    [Required]
    public OrderShop Shop { get; private set; }



    [NotMapped]
    public bool IsReady { get => Positions.All(x => x.IsReady); }


    /*
    /// <summary>
    /// Сумма заказа
    /// </summary>
    public decimal Sum()
    {
        var positionsSum = Positions.Sum(position => position.Sum);
        if(positionsSum >= Delivery.DeliveryType.DeliveryFreeOrder)
        {
            return positionsSum;
        }
        return positionsSum + Delivery.DeliveryType.Price;
    }
    */

    /// <summary>
    /// Позиции заказа
    /// </summary>
    public HashSet<OrderPosition> Positions { get; private set; } = new HashSet<OrderPosition>();


    /*
    /// <summary>
    /// Все позиции готовы
    /// </summary>
    public void MarkAsReady()
    {
        foreach (var position in Positions)
        {
            position.IsReady = true;
        }
        Date.Modified = DateTime.Now;
        Date.Ready = DateTime.Now;
    }

    /// <summary>
    /// Подтвержден менеджером
    /// </summary>
    public void SetAprove()
    {
        if (Status != OrderStatus.Pending)
        {
            throw new OrderDomainException($"Необходим статус '{OrderStatus.Pending}'");
        }
        this.Status = OrderStatus.Aproved;
        Date.Modified = DateTime.Now;
    }

    /// <summary>
    /// Отклонен менеджером
    /// </summary>
    public void SetDisaprove()
    {
        if (Status != OrderStatus.Pending)
        {
            throw new OrderDomainException($"Необходим статус '{OrderStatus.Pending}'");
        }
        this.Status = OrderStatus.Disaproved;
        Date.Modified = DateTime.Now;
    }

    /// <summary>
    /// Взят в работу
    /// </summary>
    public void SetInWork()
    {
        if (Status != OrderStatus.Aproved)
        {
            throw new OrderDomainException($"Необходим статус '{OrderStatus.Aproved}'");
        }
        this.Status = OrderStatus.InWork;
        Date.Modified = DateTime.Now;
        //Если требует приготовления то
        //SetTransferToKitchen()
        //Иначе
        //SetCollectingOrder()
    }

    /// <summary>
    /// Передан на кухню (в случае если в составе есть товары требующие приготовления
    /// </summary>
    public void SetTransferToKitchen()
    {
        if (Status != OrderStatus.InWork)
        {
            throw new OrderDomainException($"Необходим статус '{OrderStatus.InWork}'");
        }
        this.Status = OrderStatus.CookingPending;
        Date.Modified = DateTime.Now;
        //Create Cooking
    }
    /// <summary>
    /// Готовится на кухне
    /// </summary>
    public void SetCooking()
    {
        if (Status != OrderStatus.CookingPending)
        {
            throw new OrderDomainException($"Необходим статус '{OrderStatus.CookingPending}'");
        }
        this.Status = OrderStatus.Cooking;
        Date.Modified = DateTime.Now;
    }
    /// <summary>
    /// Приготовлен на кухне
    /// </summary>
    public void SetCookingReady()
    {
        if (Status != OrderStatus.Cooking)
        {
            throw new OrderDomainException($"Необходим статус '{OrderStatus.Cooking}'");
        }
        this.Status = OrderStatus.CookingReady;
        Date.Modified = DateTime.Now;
    }
    /// <summary>
    /// Передан наборщикам
    /// </summary>
    public void SetCollectingOrder()
    {
        if (Status != OrderStatus.CookingReady)
        {
            throw new OrderDomainException($"Необходим статус '{OrderStatus.CookingReady}'");
        }
        this.Status = OrderStatus.CollectingOrder;
        Date.Modified = DateTime.Now;
    }
    /// <summary>
    /// Передан в доставку
    /// </summary>
    public void SetTransferredToDelivery()
    {
        if (Status != OrderStatus.CollectingOrder)
        {
            throw new OrderDomainException($"Необходим статус '{OrderStatus.CollectingOrder}'");
        }
        this.Status = OrderStatus.DeliveryPending;
        Date.Modified = DateTime.Now;
    }
    /// <summary>
    /// В процессе доставки
    /// </summary>
    public void SetDelivering()
    {
        if (Status != OrderStatus.DeliveryPending)
        {
            throw new OrderDomainException($"Необходим статус '{OrderStatus.DeliveryPending}'");
        }
        this.Status = OrderStatus.Delivering;
        Date.Modified = DateTime.Now;
    }
    /// <summary>
    /// Доставлен
    /// </summary>
    public void SetDelivered()
    {
        if (Status != OrderStatus.Delivering)
        {
            throw new OrderDomainException($"Необходим статус '{OrderStatus.Delivering}'");
        }
        this.Status = OrderStatus.Delivered;
        Date.Modified = DateTime.Now;
    }

    */


}
