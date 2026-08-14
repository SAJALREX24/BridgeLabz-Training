using Microsoft.EntityFrameworkCore;
using AddressBookWeb.Models;
using AddressBookWeb.Repository.Data;

namespace AddressBookWeb.Repository.Repositories
{
    public class AddressBookRepository : IAddressBookRepository
    {
        private readonly AppDbContext _context;

        public AddressBookRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<AddressBookEntry>> GetAllAsync()
        {
            return await _context.Addressbooks.ToListAsync();
        }

        public async Task<AddressBookEntry?> GetByIdAsync(int id)
        {
            return await _context.Addressbooks.FindAsync(id);
        }

        public async Task<AddressBookEntry> AddAsync(AddressBookEntry entry)
        {
            await _context.Addressbooks.AddAsync(entry);
            await _context.SaveChangesAsync();
            return entry;
        }

        public async Task<AddressBookEntry?> UpdateAsync(AddressBookEntry entry)
        {
            var existing = await _context.Addressbooks.FindAsync(entry.Id);
            if (existing == null) return null;

            existing.Name = entry.Name;
            existing.PhoneNumber = entry.PhoneNumber;
            existing.Email = entry.Email;
            existing.Address = entry.Address;
            existing.City = entry.City;
            existing.State = entry.State;
            existing.ZipCode = entry.ZipCode;

            _context.Addressbooks.Update(existing);
            await _context.SaveChangesAsync();
            return existing;
        }

        public async Task<bool> DeleteAsync(int id)
        {
            var entity = await _context.Addressbooks.FindAsync(id);
            if (entity == null) return false;

            _context.Addressbooks.Remove(entity);
            await _context.SaveChangesAsync();
            return true;
        }
    }
}