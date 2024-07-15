using ApplicationCore.Interfaces.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ApplicationCore.Models.Request;
using Infrastructure.Services;

namespace eShopAPI.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private readonly ICustomerServiceAsync customerServiceAsync;

        public CustomerController(ICustomerServiceAsync customerServiceAsync)
        {
            this.customerServiceAsync = customerServiceAsync;
        }
        [HttpPost]
        public async Task<IActionResult> Post(CustomerRequestModel customerRequestModel)
        {
            var result=await customerServiceAsync.InsertCustomerAsync(customerRequestModel);
            if (result>0)
                return Ok();
            return BadRequest(result);
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            return Ok(await customerServiceAsync.GetAllCustomersAsync());
        }

        [HttpGet("{id:int}")]
        public async Task<IActionResult> GetById(int id)
        {
            return Ok(await customerServiceAsync.GetCustomerByIdAsync(id));
        }

        [HttpGet("{id:int}")]
        public async Task<IActionResult> Delete(int id)
        {
            return Ok(await customerServiceAsync.DeleteCustomerAsync(id));
        }

        [HttpPost]
        public async Task<IActionResult> Put(CustomerRequestModel model, int id)
        {
            return Ok(await customerServiceAsync.UpdateCustomerAsync(model, id));
        }
    }
}
