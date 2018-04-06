using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using static CarGarage.Types.Result;

namespace CarGarage.Models
{
    public class Report
    {
        public int ReportId { get; set; }
        public DateTime StartDate { get; set; }
        public decimal RepairTime { get; set; }
        public decimal Price { get; set; }
        public Worker WorkerId { get; set; }
        public Client ClientId { get; set; }
        public EResult Result { get; set; }
    }
}