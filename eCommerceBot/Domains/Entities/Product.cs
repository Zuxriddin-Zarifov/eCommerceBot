using System.ComponentModel.DataAnnotations.Schema;

namespace eCommerceBot.Domains.Entities;

[Table("products",Schema = "ecommerce")]
public class Product : ModelBase
{
    [Column("name")] public string Name { get; set; }
    [Column("photo_url")] public string PhotoUrl { get; set; }
    [Column("image_id")] public string ImageId { get; set; }
    [Column("price")] public decimal Price { get; set; }
    [Column("count")] public int Count { get; set; }
    [Column("category_id")] public long CategoryId { get; set; }
    [ForeignKey(nameof(CategoryId))] public Category Category { get; set; }
    [Column("owner_id")] public long OwnerId { get; set; }
    [ForeignKey(nameof(OwnerId))] public User Owner { get; set; }
}