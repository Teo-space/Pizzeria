namespace Pizzeria.Domain.Shops;


/// <summary>
/// Магазин
/// </summary>
[Table("SHOP"), PrimaryKey(nameof(ShopId)), Index(nameof(Name), IsUnique = true)]
public class Shop : Entity
{
    private Shop() { }
    public Shop(string name)
    {
        ShopId = Ulid.NewUlid();
        Name = name;
    }

    /// <summary>
    /// ID магазина
    /// </summary>
    public Ulid ShopId { get; private set; }

    /// <summary>
    /// наименование
    /// </summary>
    public string Name { get; private set; }

    /// <summary>
    /// Адрес офиса
    /// </summary>
    [Required]
    public required ShopAddress Address { get; set; }
}
