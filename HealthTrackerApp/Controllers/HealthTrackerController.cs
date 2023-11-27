using HealthTrackerApp.DAL.Interrfaces;
using HealthTrackerApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;

namespace HealthTrackerApp.Controllers
{
    public class HealthController : ApiController
    {
        private readonly IHealthTrackerService _service;
        public HealthController(IHealthTrackerService service)
        {
            _service = service;
        }
        public HealthController()
        {
            // Constructor logic, if needed
        }
        [HttpPost]
        [Route("api/Health/CreateHealth")]
        [AllowAnonymous]
        public async Task<IHttpActionResult> CreateHealth([FromBody] Health model)
        {
            var leaveExists = await _service.GetHealthById(model.HealthEntryId);
            var result = await _service.CreateHealth(model);
            return Ok(new Response { Status = "Success", Message = "Health created successfully!" });
        }


        [HttpPut]
        [Route("api/Health/UpdateHealth")]
        public async Task<IHttpActionResult> UpdateHealth([FromBody] Health model)
        {
            var result = await _service.UpdateHealth(model);
            return Ok(new Response { Status = "Success", Message = "Health updated successfully!" });
        }


        [HttpDelete]
        [Route("api/Health/DeleteHealth")]
        public async Task<IHttpActionResult> DeleteHealth(long id)
        {
            var result = await _service.DeleteHealthById(id);
            return Ok(new Response { Status = "Success", Message = "Health deleted successfully!" });
        }


        [HttpGet]
        [Route("api/Health/GetHealthById")]
        public async Task<IHttpActionResult> GetHealthById(long id)
        {
            var expense = await _service.GetHealthById(id);
            return Ok(expense);
        }


        [HttpGet]
        [Route("api/Health/GetAllHealths")]
        public async Task<IEnumerable<Health>> GetAllHealths()
        {
            return _service.GetAllHealths();
        }
    }
}
