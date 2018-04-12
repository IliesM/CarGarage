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

        public Task<bool> Add(Client value)
        {
            if (value != null)
            {
                _context.Clients.Add(value);

               // return false;
            }

           // return false;
        }

        public async Task<Client> Get(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<List<Client>> GetAll()
        {
            throw new NotImplementedException();
        }

        public async Task<bool> Remove(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<bool> Update(Client value)
        {
            throw new NotImplementedException();
        }
    }
}