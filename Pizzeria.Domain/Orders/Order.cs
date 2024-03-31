namespace Pizzeria.Domain.Orders;


/// <summary>
/// Заказ
/// </summary>
public partial class Order : Aggregate
{
    private Order() { }
    public Order(OrderClient client, OrderShop shop, OrderDelivery delivery, OrderPayment payment)
    {
        OrderId = Ulid.NewUlid();
        Status = OrderStatus.Pending;

        Client = client;
        Shop = shop;
        Delivery = delivery;
        Payment = payment;

        Date = new OrderDate()
        {
            Created = DateTime.Now,
            Modified = DateTime.Now,
        };
    }

    /// <summary>
    /// ID Заказа
    /// </summary>
    public Ulid OrderId { get; private set; }

    /// <summary>
    /// Статус заказа
    /// </summary>
    public OrderStatus Status { get; private set; }

    [NotMapped]
    public bool IsReady { get => Positions.All(x => x.IsReady); }

    /// <summary>
    /// Даты создания, изменения и готовности
    /// </summary>
    [Required]
    public OrderDate Date { get; private set; }
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


    /// <summary>
    /// Позиции заказа
    /// </summary>
    public HashSet<OrderPosition> Positions { get; set; } = new HashSet<OrderPosition>();


    public OrderPosition AddPosition(Product product, int quantity)
    {
        var position = new OrderPosition(this, product, quantity);
        Positions.Add(position);
        return position;
    }

    /// <summary>
    /// Сумма заказа
    /// </summary>
    public decimal Sum()
    {
        var positionsSum = Positions.Sum(position => position.Sum);
        return positionsSum;
        //Добавить сумму доставки
    }


}
