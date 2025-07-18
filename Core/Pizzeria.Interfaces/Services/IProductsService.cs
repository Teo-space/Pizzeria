namespace Pizzeria.Interfaces.Services;

using Pizzeria.Models.Products;

public interface IProductsService
{
    public Task<IReadOnlyCollection<ProductTypeModel>> GetProductTypes();
}
