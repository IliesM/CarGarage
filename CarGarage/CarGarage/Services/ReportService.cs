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

        public Task<bool> Add()
        {
            throw new NotImplementedException();
        }

        public Task<Report> Get()
        {
            throw new NotImplementedException();
        }

        public Task<List<Report>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<bool> Remove()
        {
            throw new NotImplementedException();
        }

        public Task<bool> Update()
        {
            throw new NotImplementedException();
        }
    }
}