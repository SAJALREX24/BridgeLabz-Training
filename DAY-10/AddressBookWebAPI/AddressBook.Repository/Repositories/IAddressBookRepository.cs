using AddressBookWeb.Models;

namespace AddressBookWeb.Repository.Repositories
{
    public interface IAddressBookRepository
    {
        Task<IEnumerable<AddressBookEntry>> GetAllAsync();
        Task<AddressBookEntry?> GetByIdAsync(int id);
        Task<AddressBookEntry> AddAsync(AddressBookEntry entry);
        Task<AddressBookEntry?> UpdateAsync(AddressBookEntry entry);
        Task<bool> DeleteAsync(int id);
    }
}