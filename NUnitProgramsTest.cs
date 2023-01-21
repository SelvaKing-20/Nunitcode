namespace test
{
    [TestFixture]
    public class Tests
    {
        //Positive Test Case - Discount
        [Test]
        // Test Case#1: Sales Amount is between 1000 and 2000
        public void TestDiscount_1000_2000()
        {
            double expected = 1425;
            Assert.AreEqual(expected, Programs.CalculateDiscount(1500));
        }
        [Test]
        // Test Case#2: Sales Amount is between 2000 and 5000
        public void TestDiscount_2000_5000()
        {
            double expected = 2500;
            Assert.AreEqual(expected, Programs.CalculateDiscount(5000));
        }
        [Test]
        // Test Case#3: Sales Amount is between 5000 and 20000
        public void TestDiscount_5000_20000()
        {
            double expected = 9999.5;
            Assert.AreEqual(expected, Programs.CalculateDiscount(19999));
        }
        // Test Case#4: Sales Amount is 0
        [Test]
        public void ZeroAmount()
        {
            try
            {
                Programs.CalculateDiscount(0);
            }
            catch (Exception ex) { }
        }
        [Test]
        // Test Case#5: Sales Amount is below 1000
        public void TestDiscount_less_1000()
        {
            double expected = 999;
            Assert.AreEqual(expected, Programs.CalculateDiscount(999));
        }
        //Negative True Test Case - Discount
        [Test]
        public void Discount_not_equal()
        {
            double expected = 930;
            Assert.AreNotEqual(expected, Programs.CalculateDiscount(1000));
        }
        //Positive Test Case - Word Count
        [Test]
        public void TestCountWords()
        {
            string string1 = "This is string";
            int string1expectedcount = 3;
            string string2 = "This is one long string";
            int string2expectedcount = 5;
            string string3 = null;
            int string3expectedcount = 0;
            Assert.AreEqual(string1expectedcount, Programs.countwords(string1));
            Assert.AreEqual(string2expectedcount, Programs.countwords(string2));
            Assert.AreEqual(string3expectedcount, Programs.countwords(string3));
        }
        [Test]
        public void TestReverseString()
        {
            string string1 = "level";
            string expectedreversestring1 = "level";
            string string2 = "Specific Pacific";
            string expectedreversestring2 = "cificaP cificepS";
            string string3 = null;
            string expectedreversestring3 = null;
            Assert.AreEqual(expectedreversestring1, Programs.ReverseString(string1));
            Assert.AreEqual(expectedreversestring2, Programs.ReverseString(string2));
            Assert.AreEqual(expectedreversestring3, Programs.ReverseString(string3));
        }
    }
}







                 
        //Positive Test Case - Reverse String