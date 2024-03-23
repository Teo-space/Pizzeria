using Pizzeria.Domain.Products;
using System.ComponentModel.DataAnnotations;

namespace Pizzeria.Domain.Orders;

/// <summary>
/// позиция заказа
/// </summary>
[Table("ORDER_POSITION")]
[PrimaryKey(nameof(OrderPositionId))]
[Index(nameof(OrderId))]
[Index(nameof(OrderId), nameof(ProductVariantId), IsUnique = true)]
public class OrderPosition : Entity
{
    private OrderPosition() { }
    public OrderPosition(Order order, ProductVariant productVariant, int quantity)
    {
        OrderPositionId = Ulid.NewUlid().ToGuid();
        OrderId = order.OrderId;
        ProductVariantId = productVariant.ProductVariantId;
        ProductId = productVariant.ProductId;
        ProductTypeId = productVariant.ProductTypeId;
        Price = productVariant.Price;

        Quanity = quantity;
    }

    /// <summary>
    /// ID позиции заказа
    /// </summary>
    public Guid OrderPositionId { get; private set; }

    /// <summary>
    /// ID заказа
    /// </summary>
    [Required]
    public Guid OrderId { get; private set; }
    public Order Order { get; private set; }

    /// <summary>
    /// Ид. варианта продукта
    /// </summary>
    [Required]
    public Guid ProductVariantId { get; private set; }
    public ProductVariant ProductVariant { get; private set; }

    /// <summary>
    /// Ид. продукта
    /// </summary>
    [Required]
    public Guid ProductId { get; private set; }
    public Product Product { get; private set; }

    /// <summary>
    /// Ид. типа продукта
    /// </summary>
    [Required]
    public Guid ProductTypeId { get; private set; }
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
