

using HealthTrackerApp.DAL.Interrfaces;
using HealthTrackerApp.DAL.Services;
using HealthTrackerApp.DAL.Services.Repository;
using HealthTrackerApp.Models;
using HealthTrackerApp.Models;
using Moq;
using System;
using System.Threading.Tasks;
using Xunit;
using Xunit.Abstractions;

namespace HealthTrackerApp.Tests.TestCases
{
    public class FunctionalTests
    {
        private readonly ITestOutputHelper _output;
        private readonly IHealthTrackerService _healthService;
        public readonly Mock<IHealthTrackerRepository> healthservice = new Mock<IHealthTrackerRepository>();

        private readonly Health _health;

        private static string type = "Functional";

        public FunctionalTests(ITestOutputHelper output)
        {
            _healthService = new HealthTrackerService(healthservice.Object);
            _output = output;

            _health = new Health
            {
                HealthEntryId = 1,
                Date = DateTime.Now,
                Weight = 70.5f,
                Height = 175.0f,
                Steps = 8000,
                SleepDuration = 7,
                WaterIntake = 1500
            };
        }


        [Fact]
        public async Task<bool> Testfor_Create_Health()
        {
            //Arrange
            var res = false;
            string testName; string status;
            testName = CallAPI.GetCurrentMethodName();

            //Action
            try
            {
                healthservice.Setup(repos => repos.CreateHealth(_health)).ReturnsAsync(_health);
                var result = await _healthService.CreateHealth(_health);
                //Assertion
                if (result != null)
                {
                    res = true;
                }
            }
            catch (Exception)
            {
                //Assert
                status = Convert.ToString(res);
                _output.WriteLine(testName + ":Failed");
                await CallAPI.saveTestResult(testName, status, type);
                return false;
            }
            status = Convert.ToString(res);
            if (res == true)
            {
                _output.WriteLine(testName + ":Passed");
            }
            else
            {
                _output.WriteLine(testName + ":Failed");
            }
            await CallAPI.saveTestResult(testName, status, type);
            return res;
        }


        [Fact]
        public async Task<bool> Testfor_Update_Health()
        {
            //Arrange
            bool res = false;
            string testName; string status;
            testName = CallAPI.GetCurrentMethodName();

            //Action
            try
            {
                healthservice.Setup(repos => repos.UpdateHealth(_health)).ReturnsAsync(_health);
                var result = await _healthService.UpdateHealth(_health);
                if (result != null)
                {
                    res = true;
                }
            }
            catch (Exception)
            {
                //Assert
                status = Convert.ToString(res);
                _output.WriteLine(testName + ":Failed");
                await CallAPI.saveTestResult(testName, status, type);
                return false;
            }
            status = Convert.ToString(res);
            if (res == true)
            {
                _output.WriteLine(testName + ":Passed");

            }
            else
            {
                _output.WriteLine(testName + ":Failed");
            }
            await CallAPI.saveTestResult(testName, status, type);
            return res;
        }

        [Fact]
        public async Task<bool> Testfor_GetHealthById()
        {
            //Arrange
            var res = false;
            int id = 1;
            string testName; string status;
            testName = CallAPI.GetCurrentMethodName();

            //Action
            try
            {
                healthservice.Setup(repos => repos.GetHealthById(id)).ReturnsAsync(_health);
                var result = await _healthService.GetHealthById(id);
                //Assertion
                if (result != null)
                {
                    res = true;
                }
            }
            catch (Exception)
            {
                //Assert
                status = Convert.ToString(res);
                _output.WriteLine(testName + ":Failed");
                await CallAPI.saveTestResult(testName, status, type);
                return false;
            }
            status = Convert.ToString(res);
            if (res == true)
            {
                _output.WriteLine(testName + ":Passed");
            }
            else
            {
                _output.WriteLine(testName + ":Failed");
            }
            await CallAPI.saveTestResult(testName, status, type);
            return res;
        }

        [Fact]
        public async Task<bool> Testfor_DeleteHealthById()
        {
            //Arrange
            var res = false;
            int id = 1;
            bool response = true;
            string testName; string status;
            testName = CallAPI.GetCurrentMethodName();

            //Action
            try
            {
                healthservice.Setup(repos => repos.DeleteHealthById(id)).ReturnsAsync(response);
                var result = await _healthService.DeleteHealthById(id);
                //Assertion
                if (result != null)
                {
                    res = true;
                }
            }
            catch (Exception)
            {
                //Assert
                status = Convert.ToString(res);
                _output.WriteLine(testName + ":Failed");
                await CallAPI.saveTestResult(testName, status, type);
                return false;
            }
            status = Convert.ToString(res);
            if (res == true)
            {
                _output.WriteLine(testName + ":Passed");
            }
            else
            {
                _output.WriteLine(testName + ":Failed");
            }
            await CallAPI.saveTestResult(testName, status, type);
            return res;
        }

    }
}