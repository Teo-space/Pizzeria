namespace Pizzeria.Domain.Orders;

/// <summary>
/// Покупатель заказа
/// </summary>
[ComplexType, Index(nameof(Phone))]
public class OrderClient
{
    /// <summary>Номер телефона</summary>
    [Column(Order = 21), Required, Key]
    public required long Phone { get; set; }
    /// <summary>адрес эл. почты</summary>
    [Column(Order = 22)]
    public string Email { get; set; }
    /// <summary>Имя</summary>
    [Column(Order = 23), Required]
    public required string Name { get; set; }
    /// <summary>Фамилия</summary>
    [Column(Order = 24), Required] 
    public required string SurName { get; set; }
    /// <summary>Отчество</summary>

    [Column(Order = 25), Required] 
    public required string Patronymic { get; set; }
}
