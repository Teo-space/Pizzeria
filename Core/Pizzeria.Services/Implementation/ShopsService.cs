using Mapster;
using Microsoft.EntityFrameworkCore;
using Pizzeria.Interfaces.Repositories;
using Pizzeria.Interfaces.Services;
using Pizzeria.Models.Shops;

namespace Pizzeria.Services.Implementation;

internal class ShopsService(IReadOnlyRepository readOnlyRepository) : IShopsService
{
    public async Task<IReadOnlyCollection<ShopModel>> GetShops()
    {
        return await readOnlyRepository.PaymentTypes.ProjectToType<ShopModel>().ToListAsync();
    }
}
