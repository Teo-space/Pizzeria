namespace Pizzeria.Models.Shops;


/// <summary>
/// Магазин
/// </summary>
public sealed record ShopModel : OutputModel
{
    /// <summary>
    /// ID магазина
    /// </summary>
    public required int ShopId { get; init; }

    /// <summary>
    /// наименование
    /// </summary>
    public required string Name { get; init; }

    /// <summary>
    /// Адрес офиса
    /// </summary>
    public required ShopAddressModel Address { get; init; }
}
