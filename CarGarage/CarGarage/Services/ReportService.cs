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

        public Task<Report> GetById()
        {
            throw new NotImplementedException();
        }

        public Task<List<Report>> GettAll()
        {
            throw new NotImplementedException();
        }
    }
}