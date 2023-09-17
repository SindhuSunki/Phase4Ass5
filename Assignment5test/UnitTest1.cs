using Assignment5;

namespace Assignmenttest

{
    public class Tests
    {
        Calculator calculator = new Calculator();
        [Test]
        public void EqualTest()
        {

            int num1, num2;
            num1 = 10;
            num2 = 10;
            Assert.AreEqual(num1, num2);
        }
        [Test]
        public void AddTest()
        {
            double num1, num2, result;
            num1 = 10;
            num2 = 5;
            result = 15;
            Assert.AreEqual(result, calculator.Add(num1, num2));
        }
        [Test]
        public void SubTest()
        {
            double num1, num2, result;
            num1 = 10;
            num2 = 5;
            result = 5;
            Assert.AreEqual(result, calculator.sub(num1, num2));
        }
        [Test]
        public void MultiTest()
        {
            double num1, num2, result;
            num1 = 10;
            num2 = 5;
            result = 50;
            Assert.AreEqual(result, calculator.Multi(num1, num2));
        }

        [Test]
        public void DivisionTest()
        {
            double num1, num2, result;
            num1 = 10;
            num2 = 5;
            result = 2;
            Assert.AreEqual(result, calculator.Div(num1, num2));
        }
        [Test]
        public void AvgTest()
        {
            double num1, num2, result;
            num1 = 10;
            num2 = 10;
            result = 10;
            Assert.AreEqual(result, calculator.Avg(num1, num2));
        }
    }
}




