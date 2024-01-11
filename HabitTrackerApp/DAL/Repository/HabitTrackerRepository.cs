using HabitTrackerApp.DAL.Interface;
using HabitTrackerApp.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace HabitTrackerApp.DAL.Repository
{
    public class HabitTrackerRepository : IHabitTrackerRepository
    {
        private HabitTrackerDbContext _context;
        public HabitTrackerRepository(HabitTrackerDbContext Context)
        {
            this._context = Context;
        }
        public IEnumerable<Habit> GetHabits()
        {
             return _context.Habits.ToList();
        }
        public Habit GetHabitByID(int id)
        {
            return _context.Habits.Find(id);
        }
        public Habit InsertHabit(Habit Habit)
        {
            return _context.Habits.Add(Habit);
        }
        public int DeleteHabit(int HabitID)
        {
            Habit Habit = _context.Habits.Find(HabitID);
            var res= _context.Habits.Remove(Habit);
            return res.Id;
        }
        public bool UpdateHabit(Habit Habit)
        {
            var res= _context.Entry(Habit).State = EntityState.Modified;
            return res.Equals("Habit");
        }
        public void Save()
        {
            _context.SaveChanges();
        }
        private bool disposed = false;
        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    _context.Dispose();
                }
            }
            this.disposed = true;
        }
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
