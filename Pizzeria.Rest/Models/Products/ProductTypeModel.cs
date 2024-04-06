namespace Pizzeria.Rest.Models.Products;

/// <summary>
/// Тип товара
/// типы товара могут требовать приготовления 'NeedCooking'
/// Такие типы товара формируют 'Cooking' при их заказе
/// </summary>
public record ProductTypeModel
{
    /// <summary>
    /// Ид. типа продукта
    /// </summary>
    public Ulid ProductTypeId { get; set; }

    /// <summary>
    /// наименование
    /// </summary>
    public required string Name { get; set; }

    /// <summary>
    /// Описание
    /// </summary>
    public required string Description { get; set; }

    /// <summary>
    /// требуется ли приготовление
    /// </summary>
    public required bool NeedCooking { get; set; }

    /// <summary>
    /// Продукты данного типа
    /// </summary>
    public List<ProductModel> Products { get; private set; } = new List<ProductModel>();
}
