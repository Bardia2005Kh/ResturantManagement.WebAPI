using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ResturantManagement.Data;
using ResturantManagement.Models.Entities;
using ResturantManagement.Repository.Interfaces;

namespace ResturantManagement.Repository
{
    public class CustomerRepository : ICustomerRepository
    {
        private readonly ResturantDbContext dbContext;

        public CustomerRepository(ResturantDbContext dbContext)
        {
            this.dbContext = dbContext;
        }


        
        public async Task<Customer> CreateAsync(Customer customer)
        {
            await dbContext.AddAsync(customer);
            await dbContext.SaveChangesAsync();
            return (customer);
        }

        public async Task<Customer?> DeleteAsync(int id)
        {
            var existingCustomer = await dbContext.Customers.FirstOrDefaultAsync(x => x.Id == id);
            if (existingCustomer == null)
            {
                return null;
            }
            dbContext.Customers.Remove(existingCustomer);
            await dbContext.SaveChangesAsync();
            return (existingCustomer);
        }

        public async Task<Customer?> GetByIdAsync(int id)
        {
            return await dbContext.Customers.FirstOrDefaultAsync(c => c.Id == id);
        }

        public async Task<List<Customer>> GrtAllAsync()
        {
            return await dbContext.Customers.ToListAsync();
        }

        public async Task<Customer?> UpdateAsync(int id, Customer customer)
        {
            var existingCustomer = await dbContext.Customers.FirstOrDefaultAsync(c => c.Id==id);
            if (existingCustomer == null)
            {
                return null;
            }

            existingCustomer.Name = customer.Name;
            existingCustomer.Phone = customer.Phone;
            existingCustomer.Address = customer.Address;

            await dbContext.SaveChangesAsync();

            return existingCustomer;

        }
    }
}
