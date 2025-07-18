using Mapster;
using Microsoft.EntityFrameworkCore;
using Pizzeria.Interfaces.Repositories;
using Pizzeria.Interfaces.Services;
using Pizzeria.Models.Products;

namespace Pizzeria.Services.Implementation;

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
