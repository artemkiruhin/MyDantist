namespace Infrastructure.Database.Repositories.Base
{
    public interface ICrudRepository<T>
    {
        Task<T?> GetById(Guid id);
        Task<IEnumerable<T>> GetAll();
        Task<bool> Add(T entity);
        Task<bool> Update(T entity);
        Task<bool> Delete(Guid id);
    }
}
