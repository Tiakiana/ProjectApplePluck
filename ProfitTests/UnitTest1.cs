using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ProfitTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            ProfitCalc pc = new ProfitCalc;
            pc.income = 200;
            pc.expenses = 100;

            double profit = pc.CalcProfit(pc.income, pc.expenses);

            Assert.AreEqual(profit, 100);
        }
    }
}
