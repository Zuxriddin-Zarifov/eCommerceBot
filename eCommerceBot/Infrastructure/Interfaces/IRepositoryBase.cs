using eCommerceBot.Domains;
using Microsoft.EntityFrameworkCore;

namespace eCommerceBot.Infrastructure.Interfaces;

public interface IRepositoryBase<T> where T : ModelBase 
{
    public DbSet<T> DbSet();
    public ValueTask<IEnumerable<T>> GetAllAsync();
    public ValueTask<T> GetByIdAsync(long id);
    public ValueTask<T> CreatAsync(T data);
    public ValueTask<T> UpdateAsync(T data);
    public ValueTask<T> DeleteAsync(long id);
}