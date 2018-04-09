using CarGarage.ModelsContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CarGarage.Services
{
    public class AppointmentService
    {
        private CarGarageDbContext _context;

        AppointmentService(CarGarageDbContext context)
        {
            _context = context;
        }
    }
}