namespace Pizzeria.Domain.Shops;


/// <summary>
/// Магазин
/// </summary>
public class Shop : Entity
{
    /// <summary>
    /// ID магазина
    /// </summary>
    public required int ShopId { get; set; }

    /// <summary>
    /// наименование
    /// </summary>
    public required string Name { get; set; }

    /// <summary>
    /// Адрес офиса
    /// </summary>
    public required ShopAddress Address { get; set; }
}
