using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using eCommerceBot.Domains;
using eCommerceBot.Domains.Enums;

namespace eCommerceBot.Domains.Entities;

public class User : ModelBase
{
    [Column(nameof(Fio))] public string Fio { get; set; }
    [Column(nameof(PhoneNumber))] public string PhoneNumber { get; set; }
    [Column(nameof(Password))] public string Password { get; set; }
    [Column(nameof(Status))] public UserStatus Status { get; set; }
}