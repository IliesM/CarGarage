using System.Collections.Generic;
using System.Threading.Tasks;

namespace CarGarage.Services
{
    public interface ICarGarageService<T>
    {
        Task<T> Get();
        Task<List<T>> GetAll();
        Task<bool> Add();
        Task<bool> Remove();
        Task<bool> Update();
    }
}