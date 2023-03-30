using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicketBooking.Data;
using TicketBooking.Repository.Interfaces;

namespace TicketBooking.Repository.Classes
{
    public class GenericTicketBookingRepository<TEntity> : IGenericTicketBookingRepository<TEntity> where TEntity : class
    {
        private TicketManagemetContext _context;
        private DbSet<TEntity> _dbSet;
        public GenericTicketBookingRepository(TicketManagemetContext context) {
            _context = context;
            _dbSet = context.Set<TEntity>();
        }
        public async virtual Task<int> Delete(object id)
        {
            TEntity? entity = await _dbSet.FindAsync(id);
            if (entity != null)
            {
                _dbSet.Remove(entity);
                return 1;
            }
            return 0;
        }

        public async virtual Task<TEntity?> Find(object id)
        {
            return await _dbSet.FindAsync(id);
        }

        public async virtual Task<IEnumerable<TEntity>> GetAll()
        {
            return await _dbSet.ToListAsync();
        }

        public async virtual void Insert(TEntity entity)
        {
            _context.Entry(entity).State = EntityState.Added;
        }

        public async virtual void Update(TEntity entity)
        {
            _dbSet.Update(entity);
        }

        public async Task<int> Save()
        {
            return _context.SaveChanges();
        }
    }
}
