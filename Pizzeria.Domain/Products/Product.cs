﻿using System.ComponentModel.DataAnnotations;

namespace Pizzeria.Domain.Products;


[Table("PRODUCTS")]
[PrimaryKey(nameof(ProductId))]
[Index(nameof(ProductTypeId))] 
[Index(nameof(Name), IsUnique = true)]
public class Product : Entity
{
    private Product() { }
    public Product(ProductType productType, string name, string description)
    {
        ProductId = Ulid.NewUlid().ToGuid();
        ProductTypeId = productType.ProductTypeId;
        Name = name;
        Description = description;
    }
    /// <summary>
    /// Ид. продукта
    /// </summary>
    [Column("PRODUCT_ID")]
    public Guid ProductId { get; private set; }

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
    [Column("DESCRIPTION"), StringLength(1000)]
    public required string Description { get; set; }

    /// <summary>
    /// Варианты продукта
    /// </summary>
    public List<ProductVariant> Variants { get; private set; } = new List<ProductVariant>();

}