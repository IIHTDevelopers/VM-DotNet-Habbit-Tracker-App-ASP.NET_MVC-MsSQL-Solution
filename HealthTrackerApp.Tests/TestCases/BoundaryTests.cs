

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
    public class BoundaryTests
    {
        private readonly ITestOutputHelper _output;
        private readonly IHealthTrackerService _healthService;
        public readonly Mock<IHealthTrackerRepository> healthservice = new Mock<IHealthTrackerRepository>();

        private readonly Health _health;

        private static string type = "Boundary";

        public BoundaryTests(ITestOutputHelper output)
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
        public async Task<bool> Testfor_Weight_NotEmpty()
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
                var actualLength = _health.Weight.ToString().Length;
                if (result.Weight.ToString().Length == actualLength)
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
        public async Task<bool> Testfor_Health_EntryId_NotEmpty()
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
                var actualLength = _health.HealthEntryId.ToString().Length;
                if (result.HealthEntryId.ToString().Length == actualLength)
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
        public async Task<bool> Testfor_Date_NotEmpty()
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
                var actualLength = _health.Date.ToString().Length;
                if (result.Date.ToString().Length == actualLength)
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
        public async Task<bool> Testfor_Height_NotEmpty()
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
                var actualLength = _health.Height.ToString().Length;
                if (result.Height.ToString().Length == actualLength)
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
        public async Task<bool> Testfor_Steps_NotEmpty()
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
                var actualLength = _health.Steps.ToString().Length;
                if (result.Steps.ToString().Length == actualLength)
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
        public async Task<bool> Testfor_SleepDuration_NotEmpty()
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
                var actualLength = _health.SleepDuration.ToString().Length;
                if (result.SleepDuration.ToString().Length == actualLength)
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
        public async Task<bool> Testfor_WaterIntake_NotEmpty()
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
                var actualLength = _health.WaterIntake.ToString().Length;
                if (result.WaterIntake.ToString().Length == actualLength)
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