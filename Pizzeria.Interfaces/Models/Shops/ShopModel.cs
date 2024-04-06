namespace Pizzeria.Interfaces.Models.Shops;


/// <summary>
/// Магазин
/// </summary>
public record ShopModel
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
    public required ShopAddressModel Address { get; set; }
}
