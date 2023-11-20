
using HabitTrackerApp.DAL;
using HabitTrackerApp.DAL.Interface;
using HabitTrackerApp.DAL.Repository;
using HabitTrackerApp.Models;
using Moq;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Xunit;
using Xunit.Abstractions;

namespace HabitTrackerApp.Tests.TestCases
{
    public class FunctionalTests
    {
        private readonly ITestOutputHelper _output;
        private readonly IHabitTrackerInterface _habitTrackerService;
        public readonly Mock<IHabitTrackerRepository> habittrackerservice = new Mock<IHabitTrackerRepository>();
        private readonly Habit _Habit;
        private readonly IEnumerable<Habit> HabitList;

        private static string type = "Functional";

        public FunctionalTests(ITestOutputHelper output)
        {
            _habitTrackerService = new HabitTrackerService(habittrackerservice.Object);
            _output = output;
            _Habit = new Habit
            {
                Id = 1,
                Date = DateTime.Now,
                HabitName = "Exercise",
                IsCompleted = true,
                Notes = "30 minutes of jogging in the park."
            };
             HabitList = new List<Habit>
        {
            new Habit
            {
               Id = 1,
                Date = DateTime.Now,
                HabitName = "Exercise",
                IsCompleted = true,
                Notes = "30 minutes of jogging in the park."
            },
            new Habit
            {
                Id = 1,
                Date = DateTime.Now,
                HabitName = "Exercise",
                IsCompleted = true,
                Notes = "30 minutes of jogging in the park."
            },
        };

        }

        [Fact]
        public async Task<bool> Testfor_Get_Habit()
        {
            //Arrange
            var res = false;
            string testName; string status;
            testName = CallAPI.GetCurrentMethodName();

            //Action
            try
            {
                 habittrackerservice.Setup(repos => repos.GetHabits()).Returns(HabitList);
                var result =  _habitTrackerService.GetHabits();
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
        public async Task<bool> Testfor_Get_Habit_ById()
        {
            //Arrange
            var res = false;
            string testName; string status;
            testName = CallAPI.GetCurrentMethodName();
            int id = 1;

            //Action
            try
            {
                habittrackerservice.Setup(repos => repos.GetHabitByID(_Habit.Id)).Returns(_Habit);
                var result = _habitTrackerService.GetHabitByID(_Habit.Id);
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
        public async Task<bool> Testfor_Update_Habit()
        {
            //Arrange
            var res = false;
            string testName; string status;
            testName = CallAPI.GetCurrentMethodName();
            int id = 1;

            //Action
            try
            {
                habittrackerservice.Setup(repos => repos.UpdateHabit(_Habit)).Returns(true);
                var result=_habitTrackerService.UpdateHabit(_Habit);
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
        public async Task<bool> Testfor_Delete_Habit()
        {
            //Arrange
            var res = false;
            string testName; string status;
            testName = CallAPI.GetCurrentMethodName();
            int id = 1;

            //Action
            try
            {
                habittrackerservice.Setup(repos => repos.DeleteHabit(_Habit.Id)).Returns(1);
                var result=_habitTrackerService.DeleteHabit(_Habit.Id);

                //Assertion
                if (result!= null)
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