using AloTaxi.Domain.Entities.Base;

namespace AloTaxi.Domain.Interfaces;

public interface IGenericRepository<T> where T : BaseEntity
{
    public Task<List<T>> GetAllAsList();

    public IQueryable<T> GetAllAsQueryable();

    public Task<T?> GetById(long id);

    public Task Add(T entity);

    public Task Update(T entity);

    public Task<bool> Delete(T entity);
    public Task<bool> Delete(long id);

    public Task Save();
}