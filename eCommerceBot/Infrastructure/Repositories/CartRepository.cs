using eCommerceBot.Domains.Entities;
using eCommerceBot.Infrastructure.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace eCommerceBot.Infrastructure.Repositories;

public class CartRepository : RepositoryBase<Cart>, ICartRepository
{
    public CartRepository(AppDataContext context) : base(context)
    {
    }
}