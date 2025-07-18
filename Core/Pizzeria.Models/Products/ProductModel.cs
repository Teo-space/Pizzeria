namespace Pizzeria.Models.Products;


/// <summary>
/// Товар
/// </summary>
public sealed record ProductModel : OutputModel
{
    /// <summary> 
    /// Ид. продукта 
    /// </summary>
    public Ulid ProductId { get; init; }

    /// <summary> 
    /// наименование 
    /// </summary>
    public required string Name { get; init; }

    /// <summary> 
    /// Описание 
    /// </summary>
    public required string Description { get; init; }

    /// <summary> 
    /// Описание 
    /// </summary>
    public required decimal Price { get; init; }
}
