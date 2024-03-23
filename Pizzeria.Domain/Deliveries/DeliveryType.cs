namespace Pizzeria.Domain.Deliveries;


/// <summary>
/// тип доставки
/// </summary>
//[Table("DELIVERY_TYPE")]
[PrimaryKey(nameof(DeliveryTypeId))]
public class DeliveryType : Entity
{
    private DeliveryType() { }
    public DeliveryType(string name, decimal price)
    {
        DeliveryTypeId = Ulid.NewUlid().ToGuid();
        Name = name;
        Price = price;
    }
    /// <summary>
    /// ID типа доставки
    /// </summary>
    //[Column("DELIVERY_TYPE_ID")]
    public Guid DeliveryTypeId { get; private set; }

    /// <summary>
    /// наименование
    /// </summary>
    //[Column("NAME")]
    public string Name { get; private set; }

    /// <summary>
    /// Цена
    /// </summary>
    //[Column("PRICE")]
    public decimal Price { get; private set; }

    /// <summary>
    /// Доставка бесплатно с суммы заказа
    /// </summary>
    //[Column("DELIVERY_FREE_ORDER")]
    public decimal DeliveryFreeOrder { get; private set; }



}
