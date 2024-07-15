using ApplicationCore.Entities;
using ApplicationCore.Interfaces.Repository;
using Infrastructure.Data;

namespace Infrastructure.Repository;

public class CustomerRepositoryAsync:BaseRepositoryAsync<Customer>, ICustomerRepositoryAsync
{
    public CustomerRepositoryAsync(EShopDbContext db) : base(db)
    { 
    }
}