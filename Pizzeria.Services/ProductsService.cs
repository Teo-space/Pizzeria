using Mapster;
using Microsoft.EntityFrameworkCore;
using Pizzeria.Interfaces.Models.Products;
using Pizzeria.Interfaces.Repositories;
using Pizzeria.Interfaces.Services;

namespace Pizzeria.Services;

internal class ProductsService(IReadOnlyRepository readOnlyRepository) : IProductsService
{
    public async Task<IReadOnlyCollection<ProductTypeModel>> GetProductTypes()
    {
        return await readOnlyRepository
            .ProductTypes
            .Include(x => x.Products)
            .ProjectToType<ProductTypeModel>()
            .ToListAsync();
    }
}
