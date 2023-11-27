using HealthTrackerApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthTrackerApp.DAL.Interrfaces
{
    public interface IHealthTrackerService
    {
        List<Health> GetAllHealths();
        Task<Health> CreateHealth(Health expense);
        Task<Health> GetHealthById(long id);
        Task<bool> DeleteHealthById(long id);
        Task<Health> UpdateHealth(Health model);
    }
}
