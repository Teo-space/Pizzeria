namespace Pizzeria.Domain.Products;


/// <summary>
/// Товар
/// </summary>
public sealed record Product : Entity
{
    /// <summary> 
    /// Ид. продукта 
    /// </summary>
    public Ulid ProductId { get; set; } = Ulid.NewUlid();

    /// <summary> 
    /// Ид. типа продукта 
    /// </summary>
    public required Ulid ProductTypeId { get; set; }
    public ProductType ProductType { get; set; }

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
