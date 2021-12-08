using AdventOfCode2021.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;

namespace AdventOfCode2021
{
    [TestClass]
    public class UnitTestDay6
    {

        [TestMethod]
        public void Day6_ShouldGiveTotalFishes_True()
        {
            var demo = @"3,4,3,1,2";
            string? input = FileHelper.Read(demo).ToList().FirstOrDefault();
            var day = new Day6();
            day.Parse(input);
            var res = day.TimePassing(18);
            Assert.IsTrue(res == 26);
        }


        [TestMethod]
        public void Day6v2_ShouldGiveTotalFishes_True()
        {
            var demo = @"3,4,3,1,2";
            string? input = FileHelper.Read(demo).ToList().FirstOrDefault();
            var day = new Day6();
            day.Parse(input);
            var res = day.TimePassing(80);
            Assert.IsTrue(res == 5934);
        }

        [TestMethod]
        public void Day6v3_ShouldGiveTotalFishes_True()
        {
            var demo = @"3,4,3,1,2";
            string? input = FileHelper.Read(demo).ToList().FirstOrDefault();
            var day = new Day6();
            day.Parse(input);
            var res = day.TimePassing(256);
            Assert.IsTrue(res == 26984457539);
        }

        [TestMethod]
        public void Day6_ShouldGiveOutTheSolution_True()
        {
            var demo = @"5,1,1,3,1,1,5,1,2,1,5,2,5,1,1,1,4,1,1,5,1,1,4,1,1,1,3,5,1,1,1,1,1,1,1,1,1,4,4,4,1,1,1,1,1,4,1,1,1,1,1,5,1,1,1,4,1,1,1,1,1,3,1,1,4,1,4,1,1,2,3,1,1,1,1,4,1,2,2,1,1,1,1,1,1,3,1,1,1,1,1,2,1,1,1,1,1,1,1,4,4,1,4,2,1,1,1,1,1,4,3,1,1,1,1,2,1,1,1,2,1,1,3,1,1,1,2,1,1,1,3,1,3,1,1,1,1,1,1,1,1,1,3,1,1,1,1,3,1,1,1,1,1,1,2,1,1,2,3,1,2,1,1,4,1,1,5,3,1,1,1,2,4,1,1,2,4,2,1,1,1,1,1,1,1,2,1,1,1,1,1,1,1,1,4,3,1,2,1,2,1,5,1,2,1,1,5,1,1,1,1,1,1,2,2,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,4,1,1,1,1,1,3,1,1,5,1,1,1,1,5,1,4,1,1,1,4,1,3,4,1,4,1,1,1,1,1,1,1,1,1,3,5,1,3,1,1,1,1,4,1,5,3,1,1,1,1,1,5,1,1,1,2,2";
            string? input = FileHelper.Read(demo).ToList().FirstOrDefault();
            var day = new Day6();
            day.Parse(input);
            var res = day.TimePassing(80);
            Assert.IsTrue(res == 394994);
        }


        [TestMethod]
        public void Day66_ShouldGiveOutTheSolution_True()
        {
            var demo = @"5,1,1,3,1,1,5,1,2,1,5,2,5,1,1,1,4,1,1,5,1,1,4,1,1,1,3,5,1,1,1,1,1,1,1,1,1,4,4,4,1,1,1,1,1,4,1,1,1,1,1,5,1,1,1,4,1,1,1,1,1,3,1,1,4,1,4,1,1,2,3,1,1,1,1,4,1,2,2,1,1,1,1,1,1,3,1,1,1,1,1,2,1,1,1,1,1,1,1,4,4,1,4,2,1,1,1,1,1,4,3,1,1,1,1,2,1,1,1,2,1,1,3,1,1,1,2,1,1,1,3,1,3,1,1,1,1,1,1,1,1,1,3,1,1,1,1,3,1,1,1,1,1,1,2,1,1,2,3,1,2,1,1,4,1,1,5,3,1,1,1,2,4,1,1,2,4,2,1,1,1,1,1,1,1,2,1,1,1,1,1,1,1,1,4,3,1,2,1,2,1,5,1,2,1,1,5,1,1,1,1,1,1,2,2,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,4,1,1,1,1,1,3,1,1,5,1,1,1,1,5,1,4,1,1,1,4,1,3,4,1,4,1,1,1,1,1,1,1,1,1,3,5,1,3,1,1,1,1,4,1,5,3,1,1,1,1,1,5,1,1,1,2,2";
            string? input = FileHelper.Read(demo).ToList().FirstOrDefault();
            var day = new Day6();
            day.Parse(input);
            var res = day.TimePassing(256);
            Assert.IsTrue(res == 394994);
        }
    }
}
