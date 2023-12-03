using System.ComponentModel.DataAnnotations.Schema;

namespace eCommerceBot.Domains.Entities;

[Table("categories", Schema = "ecommerce")]
public class Category : ModelBase
{
    [Column("name")] public string Name { get; set; }
    [Column("icon")] public string? Icon { get; set; } = null;
}