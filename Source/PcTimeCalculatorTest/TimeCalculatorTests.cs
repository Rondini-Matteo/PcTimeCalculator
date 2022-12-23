using PcTimeCalculator.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PcTimeCalculatorTest
{
    [TestClass]
    public class TimeCalculatorTests
    {
        [TestMethod]
        public void StartToWorkTest()
        {
            TimeCalculator calculator = new();
            DateTime oldWorkTimeStart = calculator.WorkTimeStart;
            DateTime oldWorkTimeEnd = calculator.WorkTimeEnd;
            DateTime oldBreakTimeStart = calculator.BreakTimeStart;
            DateTime oldBreakTimeEnd = calculator.BreakTimeEnd;

            calculator.StartToWork();

            Assert.AreNotEqual(oldWorkTimeStart, calculator.WorkTimeStart);
            Assert.AreNotEqual(oldWorkTimeEnd, calculator.WorkTimeEnd);
            Assert.AreNotEqual(oldBreakTimeStart, calculator.BreakTimeStart);
            Assert.AreNotEqual(oldBreakTimeEnd, calculator.BreakTimeEnd);

            oldWorkTimeStart = calculator.WorkTimeStart;
            oldWorkTimeEnd = oldWorkTimeStart.AddSeconds(calculator.WorkTimeDuration);
            oldBreakTimeStart = oldWorkTimeStart.AddSeconds(calculator.WorkTimeDuration);
            oldBreakTimeEnd = oldBreakTimeStart.AddSeconds(calculator.PauseDuration);

            Assert.AreEqual(oldWorkTimeStart, calculator.WorkTimeStart);
            Assert.AreEqual(oldWorkTimeEnd, calculator.WorkTimeEnd);
            Assert.AreEqual(oldBreakTimeStart, calculator.BreakTimeStart);
            Assert.AreEqual(oldBreakTimeEnd, calculator.BreakTimeEnd);
        }

        [TestMethod]
        public void TakeABreakTest()
        {
            TimeCalculator calculator = new();
            DateTime oldWorkTimeStart = calculator.WorkTimeStart;
            DateTime oldWorkTimeEnd = calculator.WorkTimeEnd;
            DateTime oldBreakTimeStart = calculator.BreakTimeStart;
            DateTime oldBreakTimeEnd = calculator.BreakTimeEnd;

            calculator.TakeABreak();

            Assert.AreNotEqual(oldWorkTimeStart, calculator.WorkTimeStart);
            Assert.AreNotEqual(oldWorkTimeEnd, calculator.WorkTimeEnd);
            Assert.AreNotEqual(oldBreakTimeStart, calculator.BreakTimeStart);
            Assert.AreNotEqual(oldBreakTimeEnd, calculator.BreakTimeEnd);

            oldWorkTimeStart = calculator.WorkTimeStart;
            oldWorkTimeEnd = oldWorkTimeStart.AddSeconds(calculator.WorkTimeDuration);
            oldBreakTimeStart = calculator.BreakTimeStart;
            oldBreakTimeEnd = oldBreakTimeStart.AddSeconds(calculator.PauseDuration);

            Assert.AreEqual(oldWorkTimeStart, calculator.WorkTimeStart);
            Assert.AreEqual(oldWorkTimeEnd, calculator.WorkTimeEnd);
            Assert.AreEqual(oldBreakTimeStart, calculator.BreakTimeStart);
            Assert.AreEqual(oldBreakTimeEnd, calculator.BreakTimeEnd);
        }

        [TestMethod]
        public void IsTimeToTakeABreakTest()
        {
            TimeCalculator calculator = new();
            Assert.IsTrue(calculator.IsTimeToTakeABreak());
            calculator.TakeABreak();
            Assert.IsFalse(calculator.IsTimeToTakeABreak());
        }

        [TestMethod]
        public void IsTimeToGoBackToWorkTest()
        {
            TimeCalculator calculator = new();
            Assert.IsTrue(calculator.IsTimeToGoBackToWork());
            calculator.StartToWork();
            Assert.IsFalse(calculator.IsTimeToGoBackToWork());
        }

    }
}
