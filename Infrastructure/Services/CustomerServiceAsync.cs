using ApplicationCore.Entities;
using ApplicationCore.Interfaces.Repository;
using ApplicationCore.Interfaces.Services;
using ApplicationCore.Models.Request;
using ApplicationCore.Models.Response;
using AutoMapper;

namespace Infrastructure.Services;

public class CustomerServiceAsync : ICustomerServiceAsync
{
    private readonly ICustomerRepositoryAsync customerRepository;
    private readonly IMapper mapper;

    public CustomerServiceAsync(ICustomerRepositoryAsync repo, IMapper mapper)
    {
        this.customerRepository = repo;
        this.mapper = mapper;
    }
    public async Task<int> InsertCustomerAsync(CustomerRequestModel customer)
    {
        var c = mapper.Map<Customer>(customer);
        return await customerRepository.InsertAsync(c);
    }

    public Task<int> UpdateCustomerAsync(CustomerRequestModel model, int id)
    {
        Customer c = mapper.Map<Customer>(model);
        c.Id = id;
        return customerRepository.UpdateAsync(c); 
    }

    public async Task<IEnumerable<CustomerResponseModel>> GetAllCustomersAsync()
    {
        var result = await customerRepository.GetAllAsync();
        return mapper.Map<IEnumerable<CustomerResponseModel>>(result);
    }

    public Task<int> DeleteCustomerAsync(int id)
    {
        return customerRepository.DeleteAsync(id);

    }

    public async Task<CustomerResponseModel> GetCustomerByIdAsync(int id)
    {
        var item = await customerRepository.GetAsync(id);
        if (item != null)
        {
            return mapper.Map<CustomerResponseModel>(item);
        } 

        return null;
    }

    public Task<int> InsertCustomerAsync(CustomerResponseModel customer)
    {
        throw new NotImplementedException();
    }
}