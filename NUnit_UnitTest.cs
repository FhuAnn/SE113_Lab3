namespace Lab3NUnit.UnitTests
{
    [TestFixture]
    public class Lab3NUnit
    {
        [Test]
        public void Test_CheckDate()
        {
            Function function = new Function();
            // February cases
            Assert.IsTrue(function.CheckDate(29, 2, 2000)); // Leap year, valid
            Assert.IsFalse(function.CheckDate(30, 2, 2000)); // Invalid date for February
            Assert.IsFalse(function.CheckDate(31, 2, 2000)); // Invalid date for February

            Assert.IsFalse(function.CheckDate(29, 2, 2009)); // Non-leap year, invalid
            Assert.IsFalse(function.CheckDate(30, 2, 2009)); // Invalid date for February
            Assert.IsFalse(function.CheckDate(31, 2, 2009)); // Invalid date for February


            //March cases
            Assert.IsTrue(function.CheckDate(29, 3, 2000)); // Valid
            Assert.IsTrue(function.CheckDate(30, 3, 2000)); // Valid 
            Assert.IsTrue(function.CheckDate(31, 3, 2000)); // Valid 

            Assert.IsFalse(function.CheckDate(29, 3, 2009)); // Valid
            Assert.IsFalse(function.CheckDate(30, 3, 2009)); // Valid
            Assert.IsFalse(function.CheckDate(31, 3, 2009)); // Valid



            // April cases
            Assert.IsTrue(function.CheckDate(29, 4, 2000)); // Valid
            Assert.IsTrue(function.CheckDate(30, 4, 2000)); // Valid
            Assert.IsFalse(function.CheckDate(31, 4, 2000)); // Invalid date for April

            Assert.IsTrue(function.CheckDate(29, 4, 2009)); // Valid
            Assert.IsTrue(function.CheckDate(30, 4, 2009)); // Valid
            Assert.IsFalse(function.CheckDate(31, 4, 2009)); // Invalid date for April

           
        }

        [Test]
        public void Test_DayInMonth()
        {
            Function function = new Function();
            // Valid cases for February
            Assert.That(function.DayInMonth(2, 2000), Is.EqualTo(29)); // Leap year
            Assert.That(function.DayInMonth(2, 1900), Is.EqualTo(28)); // Non-leap year
            Assert.That(function.DayInMonth(2, 2004), Is.EqualTo(29)); // Leap year
            Assert.That(function.DayInMonth(2, 3000), Is.EqualTo(28)); // Non-leap year
            Assert.That(function.DayInMonth(2, 3001), Is.EqualTo(28)); // Non-leap year
            Assert.That(function.DayInMonth(2, 1000), Is.EqualTo(28)); // Leap year
            Assert.That(function.DayInMonth(2, 999), Is.EqualTo(28));  // Non-leap year

            // Valid cases for May
            Assert.That(function.DayInMonth(5, 1900), Is.EqualTo(31));
            Assert.That(function.DayInMonth(5, 2000), Is.EqualTo(31));
            Assert.That(function.DayInMonth(5, 2004), Is.EqualTo(31));
            Assert.That(function.DayInMonth(5, 3000), Is.EqualTo(31));
            Assert.That(function.DayInMonth(5, 3001), Is.EqualTo(31));
            Assert.That(function.DayInMonth(5, 1000), Is.EqualTo(31));
            Assert.That(function.DayInMonth(5, 999), Is.EqualTo(31));

            // Valid cases for September
            Assert.That(function.DayInMonth(9, 1900), Is.EqualTo(30));
            Assert.That(function.DayInMonth(9, 2000), Is.EqualTo(30));
            Assert.That(function.DayInMonth(9, 2004), Is.EqualTo(30));
            Assert.That(function.DayInMonth(9, 3000), Is.EqualTo(30));
            Assert.That(function.DayInMonth(9, 3001), Is.EqualTo(30));
            Assert.That(function.DayInMonth(9, 1000), Is.EqualTo(30));
            Assert.That(function.DayInMonth(9, 999), Is.EqualTo(30));
        }
    }
}
