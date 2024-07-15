using ApplicationCore.Entities;
using ApplicationCore.Interfaces.Repository;
using Infrastructure.Data;

namespace Infrastructure.Repository;

public class ProductRepositoryAsync:BaseRepositoryAsync<Product>,IProductRepositoryAsync
{
    public ProductRepositoryAsync(EShopDbContext db) : base(db)
    {
        
    }
}