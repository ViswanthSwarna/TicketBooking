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
        public virtual void Delete(object id)
        {
            TEntity? entity = _dbSet.Find(id);
            if (entity != null)
            {
                _dbSet.Remove(entity);
            }
        }

        public virtual TEntity? Find(object id)
        {
            return _dbSet.Find(id);
        }

        public virtual IEnumerable<TEntity> GetAll()
        {
            return _dbSet.ToList();
        }

        public virtual void Insert(TEntity entity)
        {
            _context.Entry(entity).State = EntityState.Added;
        }

        public virtual void Update(TEntity entity)
        {
            _dbSet.Update(entity);
        }

        public int Save()
        {
            return _context.SaveChanges();
        }
    }
}
