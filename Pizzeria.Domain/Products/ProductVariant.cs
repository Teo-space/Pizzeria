using System.ComponentModel.DataAnnotations;

namespace Pizzeria.Domain.Products;


[Table("PRODUCT_VARIANTS")]
[PrimaryKey(nameof(ProductVariantId))]
[Index(nameof(ProductId))]
[Index(nameof(Name), IsUnique = true)]
public class ProductVariant : Entity
{
    private ProductVariant() { }
    public ProductVariant(ProductType productType, Product product, string name, string description, decimal price)
    {
        ProductVariantId = Ulid.NewUlid().ToGuid();
        ProductTypeId = productType.ProductTypeId;
        ProductId = product.ProductId;
        Name = name;
        Description = description;
        Price = price;
    }
    /// <summary>
    /// Ид. варианта продукта
    /// </summary>
    [Column("PRODUCT_VARIANT_ID")]
    public Guid ProductVariantId { get; private set; }

    /// <summary>
    /// Ид. продукта
    /// </summary>
    [Column("PRODUCT_ID")]
    public Guid ProductId { get; private set; }
    public Product Product { get; private set; }

    /// <summary>
    /// Ид. типа продукта
    /// </summary>
    [Column("PRODUCT_TYPE_ID")]
    public Guid ProductTypeId { get; private set; }
    public ProductType ProductType { get; private set; }

    /// <summary>
    /// наименование
    /// </summary>
    [Column("NAME"), StringLength(100)]
    public string Name { get; private set; }

    /// <summary>
    /// Описание
    /// </summary>
    [Column("DESCRIPTION"), StringLength(100)]
    public required string Description { get; set; }

    /// <summary>
    /// Цена
    /// </summary>
    [Column("PRICE")]
    public required decimal Price { get; set; }

}
