using CarGarage.Models;
using CarGarage.ModelsContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace CarGarage.Services
{
    public class ReportService : ICarGarageService<Report>
    {
        private CarGarageDbContext _context;

        public ReportService(CarGarageDbContext context)
        {
            _context = context;
        }

        public Task<bool> Add(Report value)
        {
            throw new NotImplementedException();
        }

        public Task<Report> Get(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<Report>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<bool> Remove(int id)
        {
            throw new NotImplementedException();
        }

        public Task<bool> Update(Report value)
        {
            throw new NotImplementedException();
        }
    }
}