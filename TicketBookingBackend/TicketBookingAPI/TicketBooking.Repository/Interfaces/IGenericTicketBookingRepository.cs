using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketBooking.Repository.Interfaces
{
    public interface IGenericTicketBookingRepository<TEntity> where TEntity : class
    {
        Task<IEnumerable<TEntity>> GetAll();
        Task<TEntity?> Find(object id);
        void Insert(TEntity entity);
        void Update(TEntity entity);
        Task<int> Delete(object id);
        Task<int> Save();
    }
}
