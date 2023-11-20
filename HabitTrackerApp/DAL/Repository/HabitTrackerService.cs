using HabitTrackerApp.DAL.Interface;
using HabitTrackerApp.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace HabitTrackerApp.DAL.Repository
{
    public class HabitTrackerService : IHabitTrackerInterface
    {
        private IHabitTrackerRepository _repo;
        public HabitTrackerService(IHabitTrackerRepository repo)
        {
            this._repo = repo;
        }

        public int DeleteHabit(int HabitId)
        {
            var res= _repo.DeleteHabit(HabitId);
            return res;
        }

        public Habit GetHabitByID(int HabitId)
        {
            return _repo.GetHabitByID(HabitId);
        }
        public void Save()
        {
            _repo.Save();
        }


        IEnumerable<Habit> IHabitTrackerInterface.GetHabits()
        {
            return _repo.GetHabits();
        }

        Habit IHabitTrackerInterface.InsertHabit(Habit Habit)
        {
            return _repo.InsertHabit(Habit);
        }

        bool IHabitTrackerInterface.UpdateHabit(Habit Habit)
        {
            return _repo.UpdateHabit(Habit);
        }
    }
}