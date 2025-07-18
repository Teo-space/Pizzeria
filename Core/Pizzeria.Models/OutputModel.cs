using Microsoft.AspNetCore.Mvc;

namespace Pizzeria.Models;

public record OutputModel
{
    public static implicit operator ActionResult(OutputModel model) => new OkObjectResult(model);
}
