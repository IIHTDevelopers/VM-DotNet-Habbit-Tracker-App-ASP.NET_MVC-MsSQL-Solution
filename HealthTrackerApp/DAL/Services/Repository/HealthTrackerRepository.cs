using HealthTrackerApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace HealthTrackerApp.DAL.Services.Repository
{
    public class HealthTrackerRepository : IHealthTrackerRepository
    {
        private readonly DatabaseContext _dbContext;
        public HealthTrackerRepository(DatabaseContext dbContext)
        {
            _dbContext = dbContext;
        }


        public async Task<Health> CreateHealth(Health expense)
        {
            try
            {
                var result =  _dbContext.Healths.Add(expense);
                await _dbContext.SaveChangesAsync();
                return expense;
            }
            catch (Exception ex)
            {
                throw (ex);
            }
        }

        public async Task<bool> DeleteHealthById(long id)
        {
            try
            {
                _dbContext.Healths.Remove(_dbContext.Healths.Single(a => a.HealthEntryId == id));
                _dbContext.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                throw (ex);
            }
        }

        public List<Health> GetAllHealths()
        {
            try
            {
                var result = _dbContext.Healths.ToList();
                return result;
            }
            catch (Exception ex)
            {
                throw (ex);
            }
        }

        public async Task<Health> GetHealthById(long id)
        {
            try
            {
                return await _dbContext.Healths.FindAsync(id);
            }
            catch (Exception ex)
            {
                throw (ex);
            }
        }

      
        

        public async Task<Health> UpdateHealth(Health model)
        {
            var ex = await _dbContext.Healths.FindAsync(model.HealthEntryId);
            try
            {
                await _dbContext.SaveChangesAsync();
                return ex;
            }
            catch (Exception exc)
            {
                throw (exc);
            }
        }
    }
}