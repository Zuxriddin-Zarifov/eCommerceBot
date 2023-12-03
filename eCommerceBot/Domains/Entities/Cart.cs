using System.ComponentModel.DataAnnotations.Schema;

namespace eCommerceBot.Domains.Entities;

[Table("carts",Schema = "ecommerce")]
public class Cart : ModelBase
{
    [ForeignKey(nameof(ProductId))] private List<Product>? Products { get; set; }
    [Column("product_id")] public List<long>? ProductId { get; set; }
    [ForeignKey(nameof(OwnerId))] public User Owner { get; set; }
    [Column("owner_id")] public long OwnerId { get; set; }
    [Column("balance")] public decimal Balance { get; set; }
}