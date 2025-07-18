using FluentValidation;
using Pizzeria.Domain.Enums;

namespace Pizzeria.Rest.Input.OrderCheckOut;

/// <summary>
/// Оформление заказа
/// </summary>
public sealed record OrderCheckOutInput
{
    /// <summary>
    /// Информация о клиенте
    /// </summary>
    public required OrderClientInput Client { get; init; }
    /// <summary>
    /// Информация о магазине
    /// </summary>
    public required OrderShopInput Shop { get; init; }
    /// <summary>
    /// Информация о доставке
    /// </summary>
    public required OrderDeliveryInput Delivery { get; init; }
    /// <summary>
    /// Тип оплаты
    /// </summary>
    public required PaymentTypes PaymentType { get; init; }
    /// <summary>
    /// Позиции заказа
    /// </summary>
    public required IReadOnlyCollection<OrderBasketPositionInput> Positions { get; init; } = Array.Empty<OrderBasketPositionInput>();

    public class Validator : AbstractValidator<OrderCheckOutInput>
    {
        public Validator()
        {
            RuleFor(x => x.Client).NotNull().NotEmpty();
            RuleFor(x => x.Client.Phone).NotEmpty();
            RuleFor(x => x.Client.Email).NotEmpty();
            RuleFor(x => x.Client.Name).NotEmpty();
            RuleFor(x => x.Client.SurName).NotEmpty();
            RuleFor(x => x.Client.Patronymic).NotEmpty();

            RuleFor(x => x.Shop).NotNull().NotEmpty();
            RuleFor(x => x.Shop.ShopId).NotEmpty();

            RuleFor(x => x.Delivery).NotNull().NotEmpty();
            RuleFor(x => x.Delivery.DeliveryTypeId).NotEmpty();
            RuleFor(x => x.Delivery.Address).NotNull().NotEmpty();
            RuleFor(x => x.Delivery.Address.City).NotEmpty();
            RuleFor(x => x.Delivery.Address.Street).NotEmpty();
            RuleFor(x => x.Delivery.Address.House).NotEmpty();
            RuleFor(x => x.Delivery.Address.Apartment).NotEmpty();
            RuleFor(x => x.Delivery.Address.Entrance).NotEmpty();
            RuleFor(x => x.Delivery.Address.Floor).NotEmpty();

            RuleFor(x => x.PaymentType).NotEmpty();

            RuleFor(x => x.Positions).NotEmpty();
            RuleForEach(x => x.Positions).ChildRules(position =>
            {
                position.RuleFor(x => x.ProductId).NotNull().NotEmpty();
                position.RuleFor(x => x.Quantity).GreaterThan(0);
            });
        }
    }
}
