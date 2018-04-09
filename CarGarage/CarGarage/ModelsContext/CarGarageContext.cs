using CarGarage.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace CarGarage.ModelsContext
{
    public class CarGarageDbContext : DbContext
    {
     
        public DbSet<Client> Clients { get; set; }
        public DbSet<Appointment> Appointments { get; set; }
        public DbSet<Report> Reports { get; set; }
        public DbSet<Worker> Workers { get; set; }

        CarGarageDbContext() : base("CarGarage")
        {
            Database.SetInitializer<CarGarageDbContext>(new CreateDatabaseIfNotExists<CarGarageDbContext>());
        }
    }
}