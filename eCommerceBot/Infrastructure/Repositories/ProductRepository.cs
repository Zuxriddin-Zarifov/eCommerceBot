using eCommerceBot.Domains.Entities;
using eCommerceBot.Infrastructure.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace eCommerceBot.Infrastructure.Repositories;

public class ProductRepository : RepositoryBase<Product>,IProductRepository
{
    public ProductRepository(DbContext context) : base(context)
    {
    }
}