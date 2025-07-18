using Pizzeria.Models.Catalog;

namespace Pizzeria.Interfaces.Services;

public interface ICatalogService
{
    public Task<CatalogModel> GetCatalog();
}
