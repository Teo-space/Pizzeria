namespace Pizzeria.Domain.Orders;

/// <summary>
/// позиция заказа
/// </summary>
[Table("ORDER_POSITION")]
[PrimaryKey(nameof(OrderPositionId))]
[Index(nameof(OrderId))]
[Index(nameof(OrderId), nameof(ProductId), IsUnique = true)]
public class OrderPosition : Entity
{
    private OrderPosition() { }
    public OrderPosition(Order order, Product product, int quantity)
    {
        OrderPositionId = Ulid.NewUlid();
        OrderId = order.OrderId;

        ProductId = product.ProductId;
        ProductTypeId = product.ProductTypeId;
        Price = product.Price;

        Quanity = quantity;
    }

    /// <summary>
    /// ID позиции заказа
    /// </summary>
    public Ulid OrderPositionId { get; private set; }

    /// <summary>
    /// ID заказа
    /// </summary>
    [Required]
    public Ulid OrderId { get; private set; }
    public Order Order { get; private set; }

    /// <summary>
    /// Ид. продукта
    /// </summary>
    [Required]
    public Ulid ProductId { get; private set; }
    public Product Product { get; private set; }

    /// <summary>
    /// Ид. типа продукта
    /// </summary>
    [Required]
    public Ulid ProductTypeId { get; private set; }
    public ProductType ProductType { get; private set; }

    /// <summary>
    /// количество
    /// </summary>
    [Required]
    public int Quanity { get; private set; }
    /// <summary>
    /// Цена
    /// </summary>
    [Required]
    public decimal Price { get; private set; }
    /// <summary>
    /// Сумма
    /// </summary>
    [NotMapped]
    public decimal Sum { get => Quanity * Price; }

    /// <summary>
    /// Готовность
    /// </summary>
    [Required]
    public bool IsReady { get; internal set; }

    /// <summary>
    /// Требует приготовления
    /// </summary>
    [Required]
    public bool NeedCooking { get; private set; }

    public void MarkAsReady()
    {
        this.IsReady = true;
    }

}
