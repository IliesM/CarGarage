using System.Collections.Generic;
using System.Threading.Tasks;

namespace CarGarage.Services
{
    public interface ICarGarageService<T>
    {
        Task<T> Get(int id);
        Task<List<T>> GetAll();
        Task<bool> Add(T value);
        Task<bool> Remove(int id);
        Task<bool> Update(T value);
    }
}