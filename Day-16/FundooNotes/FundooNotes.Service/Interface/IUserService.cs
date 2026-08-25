using FundooNotes.Models.DTOs;
using FundooNotes.Models.Entities;

namespace FundooNotes.Service.Interface
{
    public interface IUserService
    {
        Task<User> RegisterUserAsync(UserRegistrationDto registerDto);
        Task<User?> LoginUserAsync(UserLoginDto loginDto);
        string GenerateJwtToken(User user);
    }
}