namespace Pizzeria.Domain.Shops;


[ComplexType]
public class ShopAddress
{
    /// <summary>
    /// Город
    /// </summary>
    [Column(Order = 1), Required]
    public required string City { get; set; }
    /// <summary>
    /// Улица
    /// </summary>
    [Column(Order = 2), Required]
    public required string Street { get; set; }
    /// <summary>
    /// Дом
    /// </summary>
    [Column(Order = 3), Required]
    public required string House { get; set; }
    /// <summary>
    /// Корпус \ строение
    /// </summary>
    [Column(Order = 4), Required]
    public required string Building { get; set; }
    /// <summary>
    /// офис
    /// </summary>
    [Column(Order = 5)]
    public string Office { get; set; }
}
