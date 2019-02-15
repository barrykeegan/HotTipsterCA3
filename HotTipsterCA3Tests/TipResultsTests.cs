using Microsoft.VisualStudio.TestTools.UnitTesting;
using HotTipsterCA3;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotTipsterCA3.Tests
{
    [TestClass()]
    public class TipResultsTests
    {
        private static TipResults Results = new TipResults();

        private void AddFirstResult()
        {
            Results.Add(new TipResult { Course = "Aintree", RaceDate = new DateTime(2017, 05, 12), ResultValue = 11.58m, Won = true });
        }
        
        private void AddRemainingResults()
        {
            Results.Add(new TipResult {Course = "Punchestown", RaceDate = new DateTime(2016, 12, 22), ResultValue = 122.52m, Won = true });
            Results.Add(new TipResult {Course = "Sandown", RaceDate = new DateTime(2016, 11, 17), ResultValue = 20.00m, Won = false});
            Results.Add(new TipResult {Course = "Ayr", RaceDate = new DateTime(2016, 11, 03), ResultValue = 25.00m, Won = false});
            Results.Add(new TipResult {Course = "Fairyhouse", RaceDate = new DateTime(2016, 12, 02), ResultValue = 65.75m, Won = true});
            Results.Add(new TipResult {Course = "Ayr", RaceDate = new DateTime(2017, 03, 11), ResultValue = 12.05m, Won = true});
            Results.Add(new TipResult {Course = "Doncaster", RaceDate = new DateTime(2017, 12, 02), ResultValue = 10.00m, Won = false});
            Results.Add(new TipResult {Course = "Towcester", RaceDate = new DateTime(2016, 03, 12), ResultValue = 50.00m, Won = false});
            Results.Add(new TipResult {Course = "Goodwood", RaceDate = new DateTime(2017, 10, 07), ResultValue = 525.74m, Won = true});
            Results.Add(new TipResult {Course = "Kelso", RaceDate = new DateTime(2016, 09, 13), ResultValue = 43.21m, Won = true});
            Results.Add(new TipResult {Course = "Punchestown", RaceDate = new DateTime(2017, 07, 05), ResultValue = 35.00m, Won = false});
            Results.Add(new TipResult {Course = "Ascot", RaceDate = new DateTime(2016, 02, 04), ResultValue = 23.65m, Won = true});
            Results.Add(new TipResult {Course = "Kelso", RaceDate = new DateTime(2017, 08, 02),  ResultValue = 30.00m, Won = false});
            Results.Add(new TipResult {Course = "Towcester", RaceDate = new DateTime(2017, 05, 01), ResultValue = 104.33m, Won = true});
            Results.Add(new TipResult {Course = "Ascot",RaceDate = new DateTime(2017, 06, 21), ResultValue = 25.00m, Won = false});
            Results.Add(new TipResult {Course = "Bangor", RaceDate = new DateTime(2016, 12, 22), ResultValue = 30.00m, Won = false});
            Results.Add(new TipResult {Course = "Ayr", RaceDate = new DateTime(2017, 05, 22), ResultValue = 11.50m, Won = true});
            Results.Add(new TipResult {Course = "Ascot", RaceDate = new DateTime(2017, 06, 23), ResultValue = 30.00m, Won = false});
            Results.Add(new TipResult {Course = "Ascot", RaceDate = new DateTime(2017, 06, 23), ResultValue = 374.27m, Won = true});
            Results.Add(new TipResult {Course = "Goodwood", RaceDate = new DateTime(2016, 10, 05), ResultValue = 34.12m, Won = true});
            Results.Add(new TipResult {Course = "Dundalk", RaceDate = new DateTime(2016, 11, 09), ResultValue = 20.00m, Won = false});
            Results.Add(new TipResult {Course = "Haydock", RaceDate = new DateTime(2016, 11, 12), ResultValue = 87.00m, Won = true});
            Results.Add(new TipResult {Course = "Perth", RaceDate = new DateTime(2017, 01, 20), ResultValue = 15.00m, Won = false});
            Results.Add(new TipResult {Course = "York", RaceDate = new DateTime(2017, 11, 11), ResultValue = 101.25m, Won = true});
            Results.Add(new TipResult {Course = "Punchestown", RaceDate = new DateTime(2016, 12, 22), ResultValue = 11.50m, Won = true});
            Results.Add(new TipResult {Course = "Chester", RaceDate = new DateTime(2016, 08, 14), ResultValue = 10.00m, Won = false});
            Results.Add(new TipResult {Course = "Kelso", RaceDate = new DateTime(2016, 09, 18), ResultValue = 10.00m, Won = false});
            Results.Add(new TipResult {Course = "Kilbeggan", RaceDate = new DateTime(2017, 03, 03), ResultValue = 20.00m, Won = false});
            Results.Add(new TipResult {Course = "Fairyhouse", RaceDate = new DateTime(2017, 03, 11), ResultValue = 55.50m, Won = true});
            Results.Add(new TipResult {Course = "Punchestown", RaceDate = new DateTime(2016, 11, 15), ResultValue = 10.00m, Won = false});
            Results.Add(new TipResult {Course = "Towcester", RaceDate = new DateTime(2016, 05, 08), ResultValue = 16.55m, Won = true});
            Results.Add(new TipResult {Course = "Punchestown", RaceDate = new DateTime(2016, 05, 23), ResultValue = 13.71m, Won = true});
            Results.Add(new TipResult {Course = "Cork", RaceDate = new DateTime(2016, 11, 30), ResultValue = 20.00m, Won = false});
            Results.Add(new TipResult {Course = "Punchestown", RaceDate = new DateTime(2016, 04, 25), ResultValue = 13.45m, Won = true});
            Results.Add(new TipResult {Course = "Bangor", RaceDate = new DateTime(2016, 01, 23), ResultValue = 10.00m, Won = false});
            Results.Add(new TipResult {Course = "Sandown", RaceDate = new DateTime(2017, 08, 07), ResultValue = 25.00m, Won = false});
        }

        [TestCleanup()]
        public void ResetResults()
        {
            Results.Clear();
        }

        [TestMethod()]
        public void AddTest()
        {
            AddFirstResult();
            Assert.AreEqual(1, Results.Count);
            AddRemainingResults();
            Assert.AreEqual(36, Results.Count);
        }

        [TestMethod()]
        public void ClearTest()
        {
            Results.Clear();
            Assert.AreEqual(0, Results.Count);
        }

        [TestMethod()]
        public void CountTest()
        {
            Assert.AreEqual(0, Results.Count);
        }
    }
}