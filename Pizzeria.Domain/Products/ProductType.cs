namespace Pizzeria.Domain.Products;

/// <summary>
/// Тип товара
/// типы товара могут требовать приготовления 'NeedCooking'
/// Такие типы товара формируют 'Cooking' при их заказе
/// </summary>
[Table("PRODUCT_TYPES")]
[PrimaryKey(nameof(ProductTypeId))] 
[Index(nameof(Name), IsUnique = true)]
public class ProductType : Entity
{
    private ProductType() { }
    public ProductType(string name, string description)
    {
        ProductTypeId = Ulid.NewUlid();
        Name = name;
        Description = description;
    }

    /// <summary>
    /// Ид. типа продукта
    /// </summary>
    [Column("PRODUCT_TYPE_ID")]
    public Ulid ProductTypeId { get; private set; }

    /// <summary>
    /// наименование
    /// </summary>
    [Column("NAME"), StringLength(100)]
    public string Name { get; private set; }

    /// <summary>
    /// Описание
    /// </summary>
    [Column("DESCRIPTION"), StringLength(1000)]
    public string Description { get; private set; }

    /// <summary>
    /// требуется ли приготовление
    /// </summary>
    [Column("NEED_COOKING")]
    public bool NeedCooking { get; private set; }

    /// <summary>
    /// Продукты
    /// </summary>
    public List<Product> Products { get; private set; } = new List<Product>();


    public ProductType SetNeedCooking(bool needCooking)
    {
        NeedCooking = needCooking;
        return this;
    }
}
