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

        private void AddFirstResult(TipResults results)
        {
            results.Add(new TipResult { Course = "Aintree", RaceDate = new DateTime(2017, 05, 12), ResultValue = 11.58m, Won = true });
        }

        [TestMethod()]
        public void AddTest()
        {
            AddFirstResult(Results);
            Assert.AreEqual(1, Results.Count);
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