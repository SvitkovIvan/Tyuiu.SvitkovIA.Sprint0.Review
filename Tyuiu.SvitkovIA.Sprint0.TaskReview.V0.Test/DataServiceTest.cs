using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.SvitkovIA.Sprint0.TaskReview.V0.Lib;

namespace Tyuiu.SvitkovIA.Sprint0.TaskReview.V0.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckCalc()
        {
            int FirstNum = 3;
            int SecondNum = 5;
            int ThirdNum = 7;

            int res = DataService.Calc(FirstNum, SecondNum, ThirdNum);

            Assert.AreEqual(75, res);
        }
    }
}
