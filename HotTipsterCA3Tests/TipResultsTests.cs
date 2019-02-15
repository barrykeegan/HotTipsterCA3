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
        
        
        [TestMethod()]
        public void AddTest()
        {
            TipResults Results = new TipResults();
            Results.Add(new TipResult { Course = "Aintree", RaceDate = new DateTime(2017, 05, 12), ResultValue = 11.58m, Won = true });
            Assert.AreEqual(1, Results.Count);
        }

        [TestMethod()]
        public void CountTest()
        {
            TipResults Results = new TipResults();
            Assert.AreEqual(0, Results.Count);
        }
    }
}