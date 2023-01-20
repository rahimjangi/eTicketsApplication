using eTickets.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace eTickets.Data.Services
{
    public interface IBaseService<T,U>
    {
        Task<IEnumerable<T>> GetAll();
        Task<T> GetById(U u);
        Task add(T t);
        Task<T> Update(U u, T actor);
        Task Delete(U u);
    }
}
