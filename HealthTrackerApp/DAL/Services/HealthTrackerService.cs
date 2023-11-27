using HealthTrackerApp.DAL.Interrfaces;
using HealthTrackerApp.DAL.Services.Repository;
using HealthTrackerApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace HealthTrackerApp.DAL.Services
{
    public class HealthTrackerService : IHealthTrackerService
    {
        private readonly IHealthTrackerRepository _repository;

        public HealthTrackerService(IHealthTrackerRepository repository)
        {
            _repository = repository;
        }

        public Task<Health> CreateHealth(Health expense)
        {
            return _repository.CreateHealth(expense);
        }

        public Task<bool> DeleteHealthById(long id)
        {
            return _repository.DeleteHealthById(id);
        }

        public List<Health> GetAllHealths()
        {
            return _repository.GetAllHealths();
        }

        public Task<Health> GetHealthById(long id)
        {
            return _repository.GetHealthById(id); ;
        }

        public Task<Health> UpdateHealth(Health model)
        {
            return _repository.UpdateHealth(model);
        }
    }
}