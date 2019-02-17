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
    public class TipResultTests
    {
        [TestMethod()]
        public void EqualsTest()
        {
            TipResult t1 = null;
            TipResult t2 = null;
            try
            {
                t1.Equals(t2);
                Assert.Fail("Exception should have been thrown by this point.");
            }
            catch (NullReferenceException e)
            {
                StringAssert.Contains(e.Message, "Object reference not set to an instance of an object");
            }
            catch (Exception)
            {
                Assert.Fail("Unexpected Exception!");
            }
            t1 = new TipResult { Course = "Aintree", RaceDate = new DateTime(2017, 05, 12), ResultValue = 11.58m, Won = true };
            Assert.AreEqual(false, t1.Equals(t2));
            t2 = new TipResult { Course = "Aintree", RaceDate = new DateTime(2017, 05, 12), ResultValue = 11.58m, Won = true };
            Assert.AreEqual(true, t1.Equals(t2));
            t2.Course = "Phoenix Park";
            Assert.AreEqual(false, t1.Equals(t2));
            t2.Course = "Aintree";
            Assert.AreEqual(true, t1.Equals(t2));
            t2.RaceDate = t2.RaceDate.AddDays(-1);
            Assert.AreEqual(false, t1.Equals(t2));
            t2.RaceDate = t2.RaceDate.AddDays(1);
            Assert.AreEqual(true, t1.Equals(t2));
            t2.ResultValue = t2.ResultValue + 1.0m;
            Assert.AreEqual(false, t1.Equals(t2));
            t2.ResultValue = t2.ResultValue - 1.0m;
            Assert.AreEqual(true, t1.Equals(t2));
            t2.Won = !t2.Won;
            Assert.AreEqual(false, t1.Equals(t2));
            t2.Won = !t2.Won;
            Assert.AreEqual(true, t1.Equals(t2));
        }

        [TestMethod()]
        public void EqualsEqualsTest()
        {
            TipResult t1 = null;
            TipResult t2 = null;
            Assert.AreEqual(true, t1==t2);
            t1 = new TipResult { Course = "Aintree", RaceDate = new DateTime(2017, 05, 12), ResultValue = 11.58m, Won = true };
            Assert.AreEqual(false, t1 == t2);
            t2 = new TipResult { Course = "Aintree", RaceDate = new DateTime(2017, 05, 12), ResultValue = 11.58m, Won = true };
            Assert.AreEqual(true, t1 == t2);
            t2.Course = "Phoenix Park";
            Assert.AreEqual(false, t1 == t2);
            t2.Course = "Aintree";
            Assert.AreEqual(true, t1 == t2);
            t2.RaceDate = t2.RaceDate.AddDays(-1);
            Assert.AreEqual(false, t1 == t2);
            t2.RaceDate = t2.RaceDate.AddDays(1);
            Assert.AreEqual(true, t1 == t2);
            t2.ResultValue = t2.ResultValue + 1.0m;
            Assert.AreEqual(false, t1 == t2);
            t2.ResultValue = t2.ResultValue - 1.0m;
            Assert.AreEqual(true, t1 == t2);
            t2.Won = !t2.Won;
            Assert.AreEqual(false, t1 == t2);
            t2.Won = !t2.Won;
            Assert.AreEqual(true, t1 == t2);
        }

        [TestMethod()]
        public void IsValidResult()
        {
            TipResult t;
            t = new TipResult();
            //Properties of TipResult will initialise to invalid values
            Assert.AreEqual(false, t.IsValidResult());
            t.Course = "Leopardstown";
            //RaceDate and ResultValue should still hold invalid values
            Assert.AreEqual(false, t.IsValidResult());
            t.RaceDate = new DateTime(2019, 02, 16);
            //ResultValue should still hold invalid values
            Assert.AreEqual(false, t.IsValidResult());
            t.ResultValue = 10.0m;
            //All Properties should now be valid
            Assert.AreEqual(true, t.IsValidResult());
            t.RaceDate = DateTime.Now.AddDays(1);
            //date in the future, should make IsValid return false
            Assert.AreEqual(false, t.IsValidResult());

            //New Valid entry for further testing
            t = new TipResult { Course = "Aintree", RaceDate = new DateTime(2017, 05, 12), ResultValue = 11.58m, Won = true };
            Assert.AreEqual(true, t.IsValidResult());
            t.Course = null;
            Assert.AreEqual(false, t.IsValidResult());
            t.Course = "";
            Assert.AreEqual(false, t.IsValidResult());
            t.Course = "Aintree";
            Assert.AreEqual(true, t.IsValidResult());
            t.RaceDate = t.RaceDate.AddYears(-2);
            Assert.AreEqual(false, t.IsValidResult());
            t.RaceDate = t.RaceDate.AddYears(2);
            Assert.AreEqual(true, t.IsValidResult());
            t.ResultValue = 9.99m;
            Assert.AreEqual(false, t.IsValidResult());
            t.ResultValue = 10m;
            Assert.AreEqual(true, t.IsValidResult());
        }

        [TestMethod()]
        public void NotEqualsTest()
        {
            /*TipResult t1 = new TipResult { Course = "Aintree", RaceDate = new DateTime(2017, 05, 12), ResultValue = 11.58m, Won = true };
            TipResult t2 = new TipResult { Course = "Aintree", RaceDate = new DateTime(2017, 05, 12), ResultValue = 11.58m, Won = true };
            Assert.AreEqual(false, t1 != t2);
            t2.Course = "Phoenix Park";
            Assert.AreEqual(true, t1 != t2);*/

            TipResult t1 = null;
            TipResult t2 = null;
            Assert.AreEqual(false, t1 != t2);
            t1 = new TipResult { Course = "Aintree", RaceDate = new DateTime(2017, 05, 12), ResultValue = 11.58m, Won = true };
            Assert.AreEqual(true, t1 != t2);
            t2 = new TipResult { Course = "Aintree", RaceDate = new DateTime(2017, 05, 12), ResultValue = 11.58m, Won = true };
            Assert.AreEqual(false, t1 != t2);
            t2.Course = "Phoenix Park";
            Assert.AreEqual(true, t1 != t2);
            t2.Course = "Aintree";
            Assert.AreEqual(false, t1 != t2);
            t2.RaceDate = t2.RaceDate.AddDays(-1);
            Assert.AreEqual(true, t1 != t2);
            t2.RaceDate = t2.RaceDate.AddDays(1);
            Assert.AreEqual(false, t1 != t2);
            t2.ResultValue = t2.ResultValue + 1.0m;
            Assert.AreEqual(true, t1 != t2);
            t2.ResultValue = t2.ResultValue - 1.0m;
            Assert.AreEqual(false, t1 != t2);
            t2.Won = !t2.Won;
            Assert.AreEqual(true, t1 != t2);
            t2.Won = !t2.Won;
            Assert.AreEqual(false, t1 != t2);
        }

        [TestMethod()]
        public void ToStringTest()
        {
            string course = "Leopardstown";
            DateTime raceDate = new DateTime(2019, 2, 15);
            decimal value = 101.11m;
            bool won = true;
            TipResult t = new TipResult { Course = course, RaceDate = raceDate, ResultValue = value, Won = won };

            Assert.AreEqual($"{nameof(t.Course)}: {course}{Environment.NewLine}" +
                   $"{nameof(t.RaceDate)}: {raceDate}{Environment.NewLine}" +
                   $"{nameof(t.ResultValue)}: {value}{Environment.NewLine}" +
                   $"{nameof(t.Won)}: {won}{Environment.NewLine}", t.ToString());
        }        
    }

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

            //Adding null object should throw exception
            try
            {
                Results.Add(null);
                //Execution should not make it to next line as exception should be thrown
                //If it does, test should fail
                Assert.Fail("No exception was thrown");
            }
            catch (ArgumentNullException e)
            {
                //Catches appropriate exception and test passes
                StringAssert.Contains(e.Message, "Attempted to add null item to list");
            }
            catch (Exception)
            {
                //Catch base exception in case exception other than expected is thrown
                //test fails in that case
                Assert.Fail("Unexpected exception was thrown");
            }
            //Results.Count Shouldn't change after an attempt to add resulting in exception
            Assert.AreEqual(36, Results.Count);

            //Adding default constructed TipResult should throw exception
            TipResult t = new TipResult();
            try
            {
                Results.Add(t);
            }
            catch (ArgumentException e)
            {
                StringAssert.Contains(e.Message, "One or more properties have invalid data assigned");
            }
            catch (Exception)
            {
                //Catch base exception in case exception other than expected is thrown
                //test fails in that case
                Assert.Fail("Unexpected exception was thrown");
            }
            Assert.AreEqual(36, Results.Count);

            //t with null string should throw exception
            t = new TipResult { Course = null, RaceDate = DateTime.Now, ResultValue = 10.0m, Won = false };
            try
            {
                Results.Add(t);
            }
            catch (ArgumentException e)
            {
                StringAssert.Contains(e.Message, "One or more properties have invalid data assigned");
            }
            catch (Exception)
            {
                //Catch base exception in case exception other than expected is thrown
                //test fails in that case
                Assert.Fail("Unexpected exception was thrown");
            }
            Assert.AreEqual(36, Results.Count);

            //t with empty string should throw exception
            t = new TipResult { Course = "", RaceDate = DateTime.Now, ResultValue = 10.0m, Won = false };
            try
            {
                Results.Add(t);
            }
            catch (ArgumentException e)
            {
                StringAssert.Contains(e.Message, "One or more properties have invalid data assigned");
            }
            catch (Exception)
            {
                //Catch base exception in case exception other than expected is thrown
                //test fails in that case
                Assert.Fail("Unexpected exception was thrown");
            }
            Assert.AreEqual(36, Results.Count);

            //RaceDate less than 2016 should throw exception
            t = new TipResult { Course = "Aintree", RaceDate = new DateTime(2015, 12, 31), ResultValue = 10.0m, Won = false };
            try
            {
                Results.Add(t);
            }
            catch (ArgumentException e)
            {
                StringAssert.Contains(e.Message, "One or more properties have invalid data assigned");
            }
            catch (Exception)
            {
                //Catch base exception in case exception other than expected is thrown
                //test fails in that case
                Assert.Fail("Unexpected exception was thrown");
            }
            Assert.AreEqual(36, Results.Count);

            //RaceDate in the future should throw exception
            t = new TipResult { Course = "Aintree", RaceDate = DateTime.Now.AddDays(1), ResultValue = 10.0m, Won = false };
            try
            {
                Results.Add(t);
            }
            catch (ArgumentException e)
            {
                StringAssert.Contains(e.Message, "One or more properties have invalid data assigned");
            }
            catch (Exception)
            {
                //Catch base exception in case exception other than expected is thrown
                //test fails in that case
                Assert.Fail("Unexpected exception was thrown");
            }
            Assert.AreEqual(36, Results.Count);

            //Result Value less than 10 should throw exception
            t = new TipResult { Course = "Aintree", RaceDate = DateTime.Now, ResultValue = 9.99m, Won = false };
            try
            {
                Results.Add(t);
            }
            catch (ArgumentException e)
            {
                StringAssert.Contains(e.Message, "One or more properties have invalid data assigned");
            }
            catch (Exception)
            {
                //Catch base exception in case exception other than expected is thrown
                //test fails in that case
                Assert.Fail("Unexpected exception was thrown");
            }
            Assert.AreEqual(36, Results.Count);
        }

        [TestMethod()]
        public void ClearTest()
        {
            Assert.AreEqual(0, Results.Count);
            AddFirstResult();
            Assert.AreEqual(1, Results.Count);
            Results.Clear();
            Assert.AreEqual(0, Results.Count);
            AddRemainingResults();
            Assert.AreEqual(35, Results.Count);
            Results.Clear();
            Assert.AreEqual(0, Results.Count);

        }

        [TestMethod()]
        public void ContainsTest()
        {
            TipResult t = new TipResult { Course = "Aintree", RaceDate = new DateTime(2017, 05, 12), ResultValue = 11.58m, Won = true };
            Assert.AreEqual(false, Results.Contains(t));
            AddFirstResult();            
            Assert.AreEqual(true, Results.Contains(t));
            AddRemainingResults();
            //Assign a TipResult object to t with data equal to a randomly selected TipResult
            //from the AddRemainingResults method, then test that Contains works on that
            t = new TipResult { Course = "Ascot", RaceDate = new DateTime(2017, 06, 23), ResultValue = 374.27m, Won = true };
            Assert.AreEqual(true, Results.Contains(t));
            //Change t.Course to "Phoenix Park", a course that is no longer used, to ensure Contains returns false
            t.Course = "Phoenix Park";
            Assert.AreEqual(false, Results.Contains(t));
        }

        [TestMethod()]
        public void CountTest()
        {
            Assert.AreEqual(0, Results.Count);
            AddFirstResult();
            Assert.AreEqual(1, Results.Count);
            AddRemainingResults();
            Assert.AreEqual(36, Results.Count);
            Results.Clear();
            Assert.AreEqual(0, Results.Count);
        }

        
    }
}