namespace Pizzeria.Interfaces.Params.Orders.OrderCheckOut;

public class OrderDeliveryParam
{
    /// <summary>
    /// ID типа доставки
    /// </summary>
    public required int DeliveryTypeId { get; set; }

    /// <summary>
    /// Адрес доставки
    /// </summary>
    public OrderDeliveryAddressParam Address { get; set; }
}
