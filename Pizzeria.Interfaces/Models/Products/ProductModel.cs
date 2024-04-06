namespace Pizzeria.Interfaces.Models.Products;


/// <summary>
/// Товар
/// </summary>
public record ProductModel
{
    /// <summary> 
    /// Ид. продукта 
    /// </summary>
    public Ulid ProductId { get; set; }

    /// <summary> 
    /// наименование 
    /// </summary>
    public required string Name { get; set; }

    /// <summary> 
    /// Описание 
    /// </summary>
    public required string Description { get; set; }

    /// <summary> 
    /// Описание 
    /// </summary>
    public required decimal Price { get; set; }
}
