namespace Pizzeria.Interfaces.Models.Orders.OrderCheckOut.Input;

public class OrderDeliveryInputModel
{
    /// <summary>
    /// ID типа доставки
    /// </summary>
    public required int DeliveryTypeId { get; set; }

    /// <summary>
    /// Адрес доставки
    /// </summary>
    public OrderDeliveryAddressInputModel Address { get; set; }
}
