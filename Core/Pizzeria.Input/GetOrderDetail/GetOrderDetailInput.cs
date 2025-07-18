using FluentValidation;

namespace Pizzeria.Rest.Input.GetOrderDetail;


public sealed record GetOrderDetailInput
{
    /// <summary>
    /// ID Заказа
    /// </summary>
    public Ulid OrderId { get; init; }


    public class Validator : AbstractValidator<GetOrderDetailInput>
    {
        public Validator()
        {
            RuleFor(x => x.OrderId).NotEmpty();
        }
    }
}
