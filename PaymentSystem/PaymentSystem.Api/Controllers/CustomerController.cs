using AutoMapper;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using PaymentSystem.Api.DTOs;
using PaymentSystem.Domain.Abstractions;
using PaymentSystem.Domain.Models;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace PaymentSystem.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CustomerController : ControllerBase
    {
        private readonly IMapper _mapper;
        private readonly ICustomerRepository _customerRepo;
        public CustomerController(IMapper mapper, ICustomerRepository customerRepo)
        {
            _customerRepo = customerRepo;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> AllCustomers()
        {
            var customers = await _customerRepo.AllCustomerAsync();
            var getCustomers = _mapper.Map<List<CustomerResponseDTO>>(customers);
            return Ok(getCustomers);
        }



        [HttpGet]
        [Route("{nationalId}")]
        public async Task<IActionResult> CustomerByNationalId(string nationalId)
        {
            var customer = await _customerRepo.CustomerByNationalIdAsync(nationalId);

            if(customer == null)
            {
                return NotFound($"No customer found with the national id{nationalId}");
            }
            var getCustomer = _mapper.Map<CustomerResponseDTO>(customer);
            return Ok(getCustomer);
        }

        [HttpPost]
        [Route("addCustomer")]
        public async Task<IActionResult> AddBusiness([FromBody] CustomerRequestDTO customerRequestdto)
        {
             
            var customer = _mapper.Map<Customer>(customerRequestdto);
            await _customerRepo.AddCustomerAsync(customer);
            var getCustomer = _mapper.Map<CustomerResponseDTO>(customer);
            
            return CreatedAtAction(nameof(CustomerByNationalId),
               new { nationalId = customer.NationalId }, customer);
        }

        [HttpPut]
        [Route("{nationalId}")]
        public async Task<IActionResult> UpdateCustomer([FromBody] CustomerUpdateRequestDTO customerUpdateRequestDTO, string nationalId)
        {
            var toUpdate = _mapper.Map<Customer>(customerUpdateRequestDTO);
            toUpdate.NationalId = nationalId;
            await _customerRepo.UpdateCustomerAsync(toUpdate);
            return NoContent();
        }

        [HttpDelete]
        [Route("{nationalId}")]
        public async Task<IActionResult> DeleteCustomer(string nationalId)
        {
            var customer = await _customerRepo.DeleteCustomerAsync(nationalId);
            if (customer == null)
            {
                return NotFound($"No merchant found with the number{nationalId}");
            }
            return NoContent();
        }
    }
}
