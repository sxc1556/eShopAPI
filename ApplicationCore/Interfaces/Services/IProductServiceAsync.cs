using ApplicationCore.Entities;
using ApplicationCore.Models.Request;
using ApplicationCore.Models.Response;

namespace ApplicationCore.Interfaces.Services;

public interface IProductServiceAsync
{
    public Task<int> InsertProductAsync(ProductRequestModel model);
    public Task<IEnumerable<ProductResponseModel>> GetAllProductsAsync();
}