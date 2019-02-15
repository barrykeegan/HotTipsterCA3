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
            Assert.Fail();
        }

        [TestMethod()]
        public void CountTest()
        {
            TipResults Results = new TipResults();
            Assert.AreEqual(0, Results.Count);
        }
    }
}