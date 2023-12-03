using eCommerceBot.Domains.Entities;
using eCommerceBot.Infrastructure.Interfaces;

namespace eCommerceBot.Infrastructure.Repositories;

public class UserRepository : RepositoryBase<User>, IUserRepository
{
    public UserRepository(AppDataContext context) : base(context)
    {
    }
}