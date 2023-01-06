using AloTaxi.Domain.Entities.Base;

namespace AloTaxi.Domain.Interfaces.User;

public interface IUserGenericRepository<T> where T : UserBaseEntity
{
    public Task<List<T>> GetAllAsList();

    public Task<T?> GetById(string id);

    public Task Add(T entity);

    public Task Update(T entity);

    public Task<bool> Delete(T entity);
    public Task<bool> Delete(string id);

    public Task Save();
}