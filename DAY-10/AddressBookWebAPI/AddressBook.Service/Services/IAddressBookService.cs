using AddressBookWeb.Models;

namespace AddressBookWeb.Service.Services
{
    public interface IAddressBookService
    {
        Task<IEnumerable<AddressBookEntry>> GetAllAsync();
        Task<AddressBookEntry?> GetByIdAsync(int id);
        Task<AddressBookEntry> AddAsync(AddressBookEntry entry);
        Task<AddressBookEntry?> UpdateAsync(AddressBookEntry entry);
        Task<bool> DeleteAsync(int id);
    }
}