using CarGarage.Models;
using CarGarage.ModelsContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace CarGarage.Services
{
    public class WorkerService : ICarGarageService<Worker>
    {
        private CarGarageDbContext _context;

        public WorkerService(CarGarageDbContext context)
        {
            _context = context;
        }

        public Task<Worker> GetById()
        {
            throw new NotImplementedException();
        }

        public Task<List<Worker>> GettAll()
        {
            throw new NotImplementedException();
        }
    }
}