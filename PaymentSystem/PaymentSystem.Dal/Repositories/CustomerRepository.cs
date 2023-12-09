using Microsoft.EntityFrameworkCore;
using PaymentSystem.Domain.Abstractions;
using PaymentSystem.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaymentSystem.Dal.Repositories
{
    public class CustomerRepository : ICustomerRepository
    {
        private readonly DatabaseContext _context;
        public CustomerRepository(DatabaseContext context)
        {
            _context = context;
        }
        public async Task<Customer> AddCustomerAsync(Customer customer)
        {
            _context.Customers.Add(customer);
            await _context.SaveChangesAsync();
            return customer;
        }

        public async Task<List<Customer>> AllCustomerAsync()
        {
            return await _context.Customers.ToListAsync();
        }

        public async Task<Customer> CustomerByNationalIdAsync(string nationalId)
        {
            var customer = await _context.Customers.FirstOrDefaultAsync(c => c.NationalId == nationalId);

            if (customer == null)
            {
                return null;
            }
            return customer;
        }

        public  async Task<Customer> DeleteCustomerAsync(string nationalId)
        {
            var customer = await _context.Customers.FirstOrDefaultAsync(b =>
           b.NationalId == nationalId);
            if (customer == null)
            {
                return null;
            }
            _context.Customers.Remove(customer);
            _context.SaveChanges();
            return customer;
        }

        public async Task<Customer> UpdateCustomerAsync(Customer updatedCustomer)
        {
            _context.Customers.Update(updatedCustomer);
            await _context.SaveChangesAsync();
            return updatedCustomer;
        }
    }
}
