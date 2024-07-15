using ApplicationCore.Models.Request;
using ApplicationCore.Models.Response;

namespace ApplicationCore.Interfaces.Services;

public interface ICustomerServiceAsync
{

    public Task<int> InsertCustomerAsync(CustomerRequestModel customer);
    public Task<int> UpdateCustomerAsync(CustomerRequestModel model, int id);
    public Task<IEnumerable<CustomerResponseModel>> GetAllCustomersAsync();
    public Task<int> DeleteCustomerAsync(int id);
    public Task<CustomerResponseModel> GetCustomerByIdAsync(int id);
}