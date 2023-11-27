using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace HealthTrackerApp.Models
{
    public class Health
    {
        [Key]
        public int HealthEntryId { get; set; }
        public DateTime Date { get; set; }
        public float Weight { get; set; }
        public float Height { get; set; }
        public int Steps { get; set; }
        public int SleepDuration { get; set; }
        public int WaterIntake { get; set; }
    }
}