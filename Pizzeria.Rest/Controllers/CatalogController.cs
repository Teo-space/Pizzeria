using Api.Controllers;
using Mapster;
using Microsoft.AspNetCore.Mvc;
using Pizzeria.Interfaces.Services;
using Pizzeria.Rest.Models.Catalog;

namespace Pizzeria.Rest.Controllers;

/// <summary>
/// Каталог магазина
/// </summary>
[Route($"{Prefix}/[controller]")]
public class CatalogController(ICatalogService catalogService) : ApiBaseController
{
    /// <summary>
    /// Получение каталога
    /// </summary>
    [HttpGet]
    [ResponseCache(Duration = 60)]
    [Produces(typeof(CatalogModel))]
    public async Task<IActionResult> GetCatalog()
    {
        var model = await catalogService.GetCatalog();
        var result = model.Adapt<CatalogModel>();
        return Ok(result);
    }
}
