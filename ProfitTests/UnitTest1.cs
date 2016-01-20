using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Domain;

namespace ProfitTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            ProfitCalculator pc = new ProfitCalculator();
            pc.income = 200;
            pc.expenses = 100;

            double profit = pc.CalcProfit(pc.income, pc.expenses);

            Assert.AreEqual(profit, 100);
        }
        [TestMethod]
        public void TestMethod1()
        {
            ProfitCalculator pc = new ProfitCalculator();
            pc.income = 200;
            pc.expenses = -100;

            double profit = pc.CalcProfit(pc.income, pc.expenses);

            Assert.AreEqual(profit, 300);
        }
        [TestMethod]
        public void TestMethod1()
        {
            ProfitCalculator pc = new ProfitCalculator();
            pc.income = 200.6543;
            pc.expenses = 100.234;

            double profit = pc.CalcProfit(pc.income, pc.expenses);

            Assert.AreEqual(profit, 100.42);
        }
        public void TestMethod1()
        {
            ProfitCalculator pc = new ProfitCalculator();
            pc.income;
            pc.expenses;

            double profit = pc.CalcProfit(pc.income, pc.expenses);

            Assert.AreEqual(profit, 0);
        }
    }
}
