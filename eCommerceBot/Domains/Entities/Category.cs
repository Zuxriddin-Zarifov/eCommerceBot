namespace eCommerceBot.Domains.Entities;

public class Category : ModelBase
{
    public string Name { get; set; }
    public string? Icon { get; set; } = null;
}