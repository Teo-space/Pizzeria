namespace Pizzeria.Models.Products;

/// <summary>
/// Тип товара
/// типы товара могут требовать приготовления 'NeedCooking'
/// Такие типы товара формируют 'Cooking' при их заказе
/// </summary>
public sealed record ProductTypeModel : OutputModel
{
    /// <summary>
    /// Ид. типа продукта
    /// </summary>
    public Ulid ProductTypeId { get; init; }

    /// <summary>
    /// наименование
    /// </summary>
    public required string Name { get; init; }

    /// <summary>
    /// Описание
    /// </summary>
    public required string Description { get; init; }

    /// <summary>
    /// требуется ли приготовление
    /// </summary>
    public required bool NeedCooking { get; init; }

    /// <summary>
    /// Продукты данного типа
    /// </summary>
    public List<ProductModel> Products { get; private init; } = new List<ProductModel>();
}
