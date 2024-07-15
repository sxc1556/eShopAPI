using ApplicationCore.Entities;
using ApplicationCore.Interfaces.Repository;
using ApplicationCore.Interfaces.Services;
using ApplicationCore.Models.Request;
using ApplicationCore.Models.Response;
using AutoMapper;

namespace Infrastructure.Services;

public class ProductServiceAsync:IProductServiceAsync
{
    private readonly IProductRepositoryAsync productRepositoryAsync;
    private readonly IMapper mapper;

    public ProductServiceAsync(IProductRepositoryAsync productRepositoryAsync, IMapper mapper)
    { 
        this.productRepositoryAsync = productRepositoryAsync;
        this.mapper = mapper;
    }
    public Task<int> InsertProductAsync(ProductRequestModel model)
    {
        // Product p = new Product();
        // p.Price = model.Price;
        // p.Discount = model.Discount;
        // p.Description = model.Description;
        // p.Name = model.Name;
        return productRepositoryAsync.InsertAsync(mapper.Map<Product>(model));
    }

    public async Task<IEnumerable<ProductResponseModel>> GetAllProductsAsync()
    {
        var result = await productRepositoryAsync.GetAllAsync();
        return mapper.Map<IEnumerable<ProductResponseModel>>(result);
    }
}