


using HealthTrackerApp.DAL.Interrfaces;
using HealthTrackerApp.DAL.Services;
using HealthTrackerApp.DAL.Services.Repository;
using HealthTrackerApp.Models;
using Moq;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using Xunit.Abstractions;

namespace HealthTrackerApp.Tests.TestCases
{
    public class ExceptionalTests
    {
        private readonly ITestOutputHelper _output;
        private readonly IHealthTrackerService _healthService;
        public readonly Mock<IHealthTrackerRepository> healthservice = new Mock<IHealthTrackerRepository>();

        private readonly Health _health;

        private static string type = "Exception";

        public ExceptionalTests(ITestOutputHelper output)
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
        public async Task<bool> Testfor_Validate_ifInvalidHealthIdIsPassed()
        {
            //Arrange
            bool res = false;
            _health.HealthEntryId = 10;
            string testName; string status;
            testName = CallAPI.GetCurrentMethodName();

            //Action
            try
            {
                healthservice.Setup(repo => repo.CreateHealth(_health)).ReturnsAsync(_health);
                var result = await _healthService.CreateHealth(_health);
                if (result != null || result.HealthEntryId != 0)
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
        public async Task<bool> Testfor_Validate_ifInvalidWeightIsPassed()
        {
            //Arrange
            bool res = false;
            _health.Weight = 60;
            string testName; string status;
            testName = CallAPI.GetCurrentMethodName();

            //Action
            try
            {
                healthservice.Setup(repo => repo.CreateHealth(_health)).ReturnsAsync(_health);
                var result = await _healthService.CreateHealth(_health);
                if (result != null || result.Weight > 0)
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
        public async Task<bool> Testfor_Validate_ifInvalidHealthDateIsPassed()
        {
            //Arrange
            bool res = false;
            string testName; string status;
            testName = CallAPI.GetCurrentMethodName();

            //Action
            try
            {
                healthservice.Setup(repo => repo.CreateHealth(_health)).ReturnsAsync(_health);
                var result = await _healthService.CreateHealth(_health);
                if (result != null || result.Date <= DateTime.Now)
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
        public async Task<bool> Testfor_Validate_ifInvalidHeightIsPassed()
        {
            //Arrange
            bool res = false;
            _health.Height = 10;
            string testName; string status;
            testName = CallAPI.GetCurrentMethodName();

            //Action
            try
            {
                healthservice.Setup(repo => repo.CreateHealth(_health)).ReturnsAsync(_health);
                var result = await _healthService.CreateHealth(_health);
                if (result != null || result.Height != null)
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