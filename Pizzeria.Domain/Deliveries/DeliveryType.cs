namespace Pizzeria.Domain.Deliveries;


/// <summary>
/// тип доставки
/// </summary>
[Table("DELIVERY_TYPES")]
[PrimaryKey(nameof(DeliveryTypeId))]
public class DeliveryType : Entity
{
    private DeliveryType() { }
    public DeliveryType(string name, decimal price)
    {
        DeliveryTypeId = Ulid.NewUlid();
        Name = name;
        Price = price;
    }
    /// <summary>
    /// ID типа доставки
    /// </summary>
    public Ulid DeliveryTypeId { get; private set; }

    /// <summary>
    /// наименование
    /// </summary>
    public string Name { get; private set; }

    /// <summary>
    /// Цена
    /// </summary>
    public decimal Price { get; private set; }

    /// <summary>
    /// Доставка бесплатно с суммы заказа
    /// </summary>
    public decimal DeliveryFreeOrder { get; private set; }



}
