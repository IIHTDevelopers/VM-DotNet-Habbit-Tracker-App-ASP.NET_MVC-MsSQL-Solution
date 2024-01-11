using HabitTrackerApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HabitTrackerApp.DAL.Interface
{
    public interface IHabitTrackerInterface 
    {
        IEnumerable<Habit> GetHabits();
        Habit GetHabitByID(int HabitId);
        Habit InsertHabit(Habit Habit);
        int DeleteHabit(int HabitId);
        bool UpdateHabit(Habit Habit);
        void Save();
    }
}