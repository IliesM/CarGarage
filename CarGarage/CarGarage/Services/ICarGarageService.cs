using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarGarage.Services
{
    interface ICarGarageService<T>
    {
        Task<T> GetById();
        Task<List<T>> GettAll();
    }
}
