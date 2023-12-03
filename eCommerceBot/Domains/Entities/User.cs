using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using eCommerceBot.Domains;
using eCommerceBot.Domains.Enums;

namespace eCommerceBot.Domains.Entities;

[Table("users", Schema = "ecommerce")]
public class User : ModelBase
{
    [Column("fio")] public string Fio { get; set; }
    [Column("phone_number")] public string PhoneNumber { get; set; }
    [Column("password")] public string Password { get; set; }
    [Column("status")] public UserStatus Status { get; set; }
}