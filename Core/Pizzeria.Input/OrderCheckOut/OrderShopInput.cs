namespace Pizzeria.Rest.Input.OrderCheckOut;


public sealed record OrderShopInput
{
    /// <summary>
    /// ID магазина
    /// </summary>
    public int ShopId { get; init; }
}
