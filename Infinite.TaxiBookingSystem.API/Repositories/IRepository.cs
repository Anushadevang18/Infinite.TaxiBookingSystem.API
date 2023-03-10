using Infinite.TaxiBookingSystem.API.Models;
using System.Collections.Generic;
using System.Threading.Tasks;


namespace Infinite.TaxiBookingSystem.API.Repositories
{
    public interface IGetRepository<T> where T : class
    {
        IEnumerable<T> GetAll();
        Task<T> GetById(int id);
    }
    public interface IRepository<T> where T : class
    {
        Task Create(T obj);

        Task<T> Update(int id, T obj);
        Task<T> Delete(int id);
       
    }
    public interface IBookingRepository
    {
        Task<IEnumerable<Booking>> SearchByTaxi(string taxiModel);
    }
  
}


