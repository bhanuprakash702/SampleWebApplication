using System.Linq.Expressions;

namespace WebApplication1.Data
{
    public interface IGenericRepository<TEntity> where TEntity : class
    {
        Task<List<TEntity>> GetAll();
        //Task<List<TEntity>> GetAllByFilter(Expression<Func<TEntity, bool>> filter);

        //Task<TEntity> GetById(Expression<Func<TEntity, bool>> filter);

        Task Create(TEntity entity);

        //Task Update(int id, TEntity entity);

        //Task Delete(Expression<Func<TEntity, bool>> filter);
    }
}
