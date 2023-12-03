using System.ComponentModel.DataAnnotations.Schema;

namespace eCommerceBot.Domains.Entities;

public class Cart : ModelBase
{
    [ForeignKey(nameof(ProductId))] private List<Product>? Products { get; set; }
    [Column(nameof(ProductId))] public List<long>? ProductId { get; set; }
    [ForeignKey(nameof(OwnerId))] public User Owner { get; set; }
    [Column(nameof(OwnerId))] public long OwnerId { get; set; }
    [Column(nameof(Balance))] public decimal Balance { get; set; }
}