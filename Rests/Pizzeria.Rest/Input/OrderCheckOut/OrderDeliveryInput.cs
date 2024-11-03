namespace Pizzeria.Rest.Input.OrderCheckOut;

public class OrderDeliveryInput
{
    /// <summary>
    /// ID типа доставки
    /// </summary>
    public required int DeliveryTypeId { get; set; }

    /// <summary>
    /// Адрес доставки
    /// </summary>
    public OrderDeliveryAddressInput Address { get; set; }
}
