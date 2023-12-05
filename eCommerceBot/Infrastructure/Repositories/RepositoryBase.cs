using System.Diagnostics;
using eCommerceBot.Domains;
using eCommerceBot.Infrastructure.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace eCommerceBot.Infrastructure.Repositories;

public class RepositoryBase<T> : IRepositoryBase<T> where T : ModelBase
{
    private readonly DbContext _context;

    public RepositoryBase(DbContext context)
    {
        _context = context;
    }

    public DbSet<T> DbSet()
    {
        return _context.Set<T>();
    }

    public async ValueTask<IEnumerable<T>> GetAllAsync()
    {
        return await this.DbSet().ToListAsync();
    }

    public async ValueTask<T> GetByIdAsync(long id) => await this.DbSet().FirstOrDefaultAsync(x => x.Id == id);

    public async ValueTask<T> CreatAsync(T data)
    {
        var entity = await this.DbSet().AddAsync(data);
        await _context.SaveChangesAsync();
        return entity.Entity;
    }

    public async ValueTask<T> UpdateAsync(T data)
    {
        var entity = this.DbSet().Update(data);
        await _context.SaveChangesAsync();
        return entity.Entity;
    }

    public async ValueTask<T> DeleteAsync(long id)
    {
        var data = await this.GetByIdAsync(id);
        var entity = this.DbSet().Remove(data);
        await _context.SaveChangesAsync();
        return entity.Entity;
    }
}