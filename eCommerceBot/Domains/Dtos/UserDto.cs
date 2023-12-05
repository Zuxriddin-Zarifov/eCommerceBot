using eCommerceBot.Domains.Enums;

namespace eCommerceBot.Domains.Dtos;

public class UserDto
{
    public long  Id { get; set; }
    public string Fio { get; set; }
    public string PhoneNumber { get; set; }
    public string Password { get; set; }
    public UserStatus Status { get; set; }
}