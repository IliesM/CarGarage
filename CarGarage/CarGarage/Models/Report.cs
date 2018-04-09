using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using static CarGarage.Types.Result;

namespace CarGarage.Models
{
    public class Report
    {
        [Key]
        public int ReportId { get; set; }
        [Required]
        public DateTime StartDate { get; set; }
        [Required]
        public decimal RepairTime { get; set; }
        [Required]
        public decimal Price { get; set; }
        [Required]
        public Worker WorkerId { get; set; }
        [Required]
        public Client ClientId { get; set; }
        [Required]
        public EResult Result { get; set; }
    }
}