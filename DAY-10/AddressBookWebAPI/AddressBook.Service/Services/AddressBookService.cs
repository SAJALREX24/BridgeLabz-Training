using AddressBookWeb.Models;
using AddressBookWeb.Repository.Repositories;

namespace AddressBookWeb.Service.Services
{
    public class AddressBookService : IAddressBookService
    {
        private readonly IAddressBookRepository _repository;

        public AddressBookService(IAddressBookRepository repository)
        {
            _repository = repository;
        }

        public async Task<IEnumerable<AddressBookEntry>> GetAllAsync()
        {
            return await _repository.GetAllAsync();
        }

        public async Task<AddressBookEntry?> GetByIdAsync(int id)
        {
            return await _repository.GetByIdAsync(id);
        }

        public async Task<AddressBookEntry> AddAsync(AddressBookEntry entry)
        {
            return await _repository.AddAsync(entry);
        }

        public async Task<AddressBookEntry?> UpdateAsync(AddressBookEntry entry)
        {
            return await _repository.UpdateAsync(entry);
        }

        public async Task<bool> DeleteAsync(int id)
        {
            return await _repository.DeleteAsync(id);
        }
    }
}