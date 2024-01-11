using HabitTrackerApp.DAL.Interface;
using HabitTrackerApp.DAL.Repository;
using HabitTrackerApp.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace HabitTrackerApp.Controllers
{
    public class HabitTrackerController : Controller
    {
        private readonly IHabitTrackerInterface _Repository;
        public HabitTrackerController(IHabitTrackerInterface service)
        {
            _Repository = service;
        }
        public HabitTrackerController()
        {
            // Constructor logic, if needed
        }
        // GET: HabitTracker
        public ActionResult Index()
        {
            var Habits = from work in _Repository.GetHabits()
                        select work;
            return View(Habits);
        }

        public ViewResult Details(int id)
        {
            Habit Habit =   _Repository.GetHabitByID(id);
            return View(Habit);
        }

        public ActionResult Create()
        {
            return View(new Habit());
        }

        [HttpPost]
        public ActionResult Create(Habit Habit)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    _Repository.InsertHabit(Habit);
                    _Repository.Save();
                    return RedirectToAction("Index");
                }
            }
            catch (DataException)
            {
                ModelState.AddModelError("", "Unable to save changes. Try again, and if the problem persists see your system administrator.");
            }
            return View(Habit);
        }

        public ActionResult EditAsync(int id)
        {
            Habit Habit =  _Repository.GetHabitByID(id);
            return View(Habit);
        }
        [HttpPost]
        public ActionResult Edit(Habit Habit)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    _Repository.UpdateHabit(Habit);
                    _Repository.Save();
                    return RedirectToAction("Index");
                }
            }
            catch (DataException)
            {
                ModelState.AddModelError("", "Unable to save changes. Try again, and if the problem persists see your system administrator.");
            }
            return View(Habit);
        }

        public ActionResult Delete(int id, bool? saveChangesError)
        {
            if (saveChangesError.GetValueOrDefault())
            {
                ViewBag.ErrorMessage = "Unable to save changes. Try again, and if the problem persists see your system administrator.";
            }
            Habit Habit =  _Repository.GetHabitByID(id);
            return View(Habit);
        }

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            try
            {
                Habit Habit =  _Repository.GetHabitByID(id);
                _Repository.DeleteHabit(id);
                _Repository.Save();
            }
            catch (DataException)
            {
                return RedirectToAction("Delete",
                   new System.Web.Routing.RouteValueDictionary {
        { "id", id },
        { "saveChangesError", true } });
            }
            return RedirectToAction("Index");
        }
    }
}