namespace Pizzeria.Interfaces.Services;

using Pizzeria.Interfaces.Models.Products;

public interface IProductsService
{
    public Task<IReadOnlyCollection<ProductTypeModel>> GetProductTypes();
}
