using CarGarage.Models;
using CarGarage.ModelsContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace CarGarage.Services
{
    public class ClientService : ICarGarageService<Client>
    {
        private CarGarageDbContext _context;

        public ClientService(CarGarageDbContext context)
        {
            _context = context;
        }

        public Task<Client> GetById()
        {
            throw new NotImplementedException();
        }

        public Task<List<Client>> GettAll()
        {
            throw new NotImplementedException();
        }
    }
}