using eCommerceBot.Domains.Entities;
using eCommerceBot.Infrastructure.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace eCommerceBot.Infrastructure.Repositories;

public class CategoryRepository :RepositoryBase<Category>,ICategoryRepository
{
    public CategoryRepository(DbContext context) : base(context)
    {
    }
}