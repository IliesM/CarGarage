using CarGarage.Models;
using CarGarage.ModelsContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace CarGarage.Services
{
    public class AppointmentService : ICarGarageService<Appointment>
    {
        private CarGarageDbContext _context;

        AppointmentService(CarGarageDbContext context)
        {
            _context = context;
        }

        public Task<bool> Add(Appointment value)
        {
            throw new NotImplementedException();
        }

        public Task<Appointment> Get(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<Appointment>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<bool> Remove(int id)
        {
            throw new NotImplementedException();
        }

        public Task<bool> Update(Appointment value)
        {
            throw new NotImplementedException();
        }
    }
}