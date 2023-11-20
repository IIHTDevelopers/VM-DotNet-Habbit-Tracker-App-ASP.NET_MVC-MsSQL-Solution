using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HabitTrackerApp.Models
{
    public class Habit
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public string HabitName { get; set; }
        public bool IsCompleted { get; set; }
        public string Notes { get; set; }
    }

}