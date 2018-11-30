using System;
using System.Linq;
using System.Threading.Tasks;

using Library.Domain.Shared;

namespace Library.Infraestructure.Abstractions
{
    public interface IEntityRepository<TEntity, TId> :
        IReadEntityRepository<TEntity, TId>,
        IWriteEntityRepository<TEntity, TId>,
        ICommonEntityRepository<TEntity, TId> where TEntity : class, IEntity<TId>, new() where TId : IEquatable<TId>
    {

    }
}