using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace TLWebsite.Data.Interfaces
{
    public interface IBaseRepository<TEntity>
        where TEntity : class
    {
        TEntity Get(int id);

        IEnumerable<TEntity> GetAll();

        IEnumerable<TEntity> Find(Expression<Func<TEntity, bool>> predicate);

        void Add(TEntity entity);

        void BulkAdd(IEnumerable<TEntity> entities);

        void Remove(TEntity entity);

        void BulkRemove(IEnumerable<TEntity> entities);
    }
}
