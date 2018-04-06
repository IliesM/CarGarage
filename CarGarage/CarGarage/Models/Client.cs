using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CarGarage.Models
{
    public class Client
    {
        public int CustomerId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public DateTime RegisterDate { get; set; }

        //public virtual ICollection<Report> RelatedReports { get; set; }
    }
}