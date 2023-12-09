using PaymentSystem.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaymentSystem.Domain.Abstractions
{
    public interface ICustomerRepository
    {
        Task<Customer> AddCustomerAsync(Customer customer);
        Task<Customer> CustomerByNationalIdAsync(string merchantNumber);
        Task<List<Customer>> AllCustomerAsync();
        Task<Customer> UpdateCustomerAsync(Customer updatedCustomer);
        Task<Customer> DeleteCustomerAsync(string nationalId);
    }
}
