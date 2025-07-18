using Api.Controllers;
using Microsoft.AspNetCore.Mvc;
using Pizzeria.Interfaces.Services;
using Pizzeria.Models.Catalog;

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
    [HttpGet, Produces(typeof(CatalogModel))]
    [ResponseCache(Duration = 60)]
    public async Task<ActionResult> GetCatalog() => await catalogService.GetCatalog();

}
