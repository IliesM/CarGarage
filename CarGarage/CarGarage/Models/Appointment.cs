using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using static CarGarage.Types.RepairState;

namespace CarGarage.Models
{
    public class Appointment
    {
        public int AppointmentId { get; set; }
        public DateTime StartDate { get; set; }
        public Client ClientId { get; set; }
        public ERepairState RepairState { get; set; }
    }
}