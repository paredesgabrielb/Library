using Library.Domain.Shared;
using Library.Infraestructure.Abstractions;
using Library.Infraestructure.Shared;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Library.Infraestructure.Base
{
    public abstract class CommonEntityRepository<TEntity, TId> : IDisposable, ICommonEntityRepository<TEntity, TId> where TEntity : class, IEntity<TId>, new() where TId : IEquatable<TId>
    {
        private readonly GenericRepositoryContext context;

        protected CommonEntityRepository(GenericRepositoryContext context)
        {
            this.context = context;
        }

        public virtual IQueryable<TEntity> GetQueryAble(bool noTracking = false)
        {
            return noTracking
                ? this.CreateQuery().AsNoTracking()
                : this.CreateQuery();
        }

        public virtual int Count()
        {
            return this.CreateQuery()
                .Select(entity => entity.Id)
                .Count();
        }

        public virtual async Task<int> CountAsync()
        {

            return await this.CreateQuery()
                .Select(entity => entity.Id)
                .CountAsync()
                .ConfigureAwait(false);
        }

        public void Dispose()
        {
            this.context?.Dispose();
            GC.SuppressFinalize(this);
        }

        protected IQueryable<TEntity> BuildIncludes(params Expression<Func<TEntity, object>>[] includes)
        {
            var query = this.CreateQuery();

            return includes.Aggregate(query, (current, include) => current.Include(include));
        }

        protected IQueryable<TEntity> CreateQuery()
        {
            return this.context.Set<TEntity>().AsQueryable();
        }
    }
}
