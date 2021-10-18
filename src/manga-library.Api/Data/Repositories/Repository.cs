using System.Linq;
using System.Threading.Tasks;
using manga_library.Api.Interfaces.Repositories;
using Microsoft.EntityFrameworkCore;

namespace manga_library.Api.Data.Repositories
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : class
    {
        internal readonly AppDbContext context;
        protected readonly DbSet<TEntity> DbSet;

        public Repository(AppDbContext context)
        {
            this.context = context;
            this.DbSet = this.context.Set<TEntity>();
        }
        
        public TEntity Add(TEntity entity)
        {
            DetachAllEntities();

            DbSet.Add(entity);
            context.SaveChanges();

            return entity;
        }

        public async Task<TEntity> AddAsync(TEntity entity)
        {
            DetachAllEntities();

            await DbSet.AddAsync(entity);
            await context.SaveChangesAsync().ConfigureAwait(false);

            return entity;
        }
        
        private void DetachAllEntities()
        {
            var tracking = context.ChangeTracker.Entries().ToList();

            foreach (var entry in tracking)
                entry.State = EntityState.Detached;
        }
    }
}