using FluentValidation;

namespace Pizzeria.Rest.Input.GetOrderDetail;


public class GetOrderDetailInput
{
    /// <summary>
    /// ID Заказа
    /// </summary>
    public Ulid OrderId { get; set; }


    public class Validator : AbstractValidator<GetOrderDetailInput>
    {
        public Validator()
        {
            RuleFor(x => x.OrderId).NotEmpty();
        }
    }
}
