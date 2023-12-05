namespace eCommerceBot.Domains.Dtos;

public class UserUpdateDto
{
    public long Id { get; set; }
    public string Fio { get; set; }
    public string PhoneNumber { get; set; }
    public string Password { get; set; }
}