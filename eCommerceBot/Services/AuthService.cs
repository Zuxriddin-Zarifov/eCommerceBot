using eCommerceBot.Domains.Dtos;
using eCommerceBot.Domains.Entities;
using eCommerceBot.Domains.Enums;
using eCommerceBot.Infrastructure.Repositories;

namespace eCommerceBot.Services;

public class AuthService
{
    private readonly UserRepository _userRepository;

    public AuthService(UserRepository userRepository)
    {
        _userRepository = userRepository;
    }

    public async Task<UserDto> CreateAsync(UserCreateDto dto)
    {
        User user = new User
        {
            Fio = dto.Fio,
            PhoneNumber = dto.PhoneNumber,
            Password = dto.Password,
            Status = UserStatus.Client
        };
        user = await _userRepository.CreatAsync(user);
        UserDto result = MappingUserUserDto(user);
        return result;
    }

    public async Task<UserDto> UpdateAsync(UserUpdateDto dto)
    {
        User user = await _userRepository.GetByIdAsync(dto.Id);

        user.PhoneNumber = dto.PhoneNumber;
        user.Fio = dto.Fio;
        user.Password = user.Password;

        user = await _userRepository.UpdateAsync(user);

        UserDto result = MappingUserUserDto(user);
        return result;
    }

    public async Task<UserDto> Delete(long id)
    {
        var user = await _userRepository.DeleteAsync(id);
        UserDto result = MappingUserUserDto(user);
        return result;
    }

    private UserDto MappingUserUserDto(User user) => new UserDto
    {
        Id = user.Id,
        Fio = user.Fio,
        PhoneNumber = user.PhoneNumber,
        Password = user.Password,
        Status = user.Status
    };
}