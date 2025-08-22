using ResturantManagement.Models.Entities;

namespace ResturantManagement.Repository.Interfaces
{
    public interface ICustomerRepository
    {
        Task<Customer> CreateAsync(Customer customer);

        Task<List<Customer>> GrtAllAsync();

        Task<Customer?> GetByIdAsync(int id);

        Task<Customer?> UpdateAsync(int id, Customer customer);

        Task<Customer?> DeleteAsync(int id);
    }
}
