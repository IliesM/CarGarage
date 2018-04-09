using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using static CarGarage.Types.RepairState;

namespace CarGarage.Models
{
    public class Appointment
    {
        [Key]
        public int AppointmentId { get; set; }
        [Required]
        public DateTime StartDate { get; set; }
        [Required]
        public Client ClientId { get; set; }
        [Required]
        public ERepairState RepairState { get; set; }
    }
}