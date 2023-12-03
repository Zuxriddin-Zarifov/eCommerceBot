using System.ComponentModel.DataAnnotations.Schema;

namespace eCommerceBot.Domains.Entities;

public class Product : ModelBase
{
    [Column(nameof(Name))] public string Name { get; set; }
    [Column(nameof(PhotoUrl))] public string PhotoUrl { get; set; }
    [Column(nameof(ImageId))] public string ImageId { get; set; }
    [Column(nameof(Price))] public decimal Price { get; set; }
    [Column(nameof(Count))] public int Count { get; set; }
    [Column(nameof(CategoryId))] public long CategoryId { get; set; }
    [ForeignKey(nameof(CategoryId))] public Category Category { get; set; }
    [Column(nameof(OwnerId))] public long OwnerId { get; set; }
    [ForeignKey(nameof(OwnerId))] public User Owner { get; set; }
}