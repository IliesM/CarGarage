using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CarGarage.Models
{
    public class Client
    {
        [Key]
        public int CustomerId { get; set; }
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public DateTime RegisterDate { get; set; }

        public bool IsLogged { get; set; }

        //public virtual ICollection<Report> RelatedReports { get; set; }
    }
}