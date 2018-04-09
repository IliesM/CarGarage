using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CarGarage.Models
{
    public class Worker
    {
        [Key]
        public int WorkerId { get; set; }
        [Required]
        public string Name { get; set; }
    }
}