using Calculadora.Model;
using Calculadora.Services;
using NUnit.Framework;

namespace Calculadora.CalculadoraTests
{
    [TestFixture]
    public class SimpleCalculatorTests
    {
        [Test]
        public void AdditionStandardTest()
        {
            SimpleCalculator calculator = new SimpleCalculator();
            Operation operation = new Operation { ValueA = 2, ValueB = 3, Operator = '+' };

            decimal result = calculator.Calculate(operation);

            Assert.That(result, Is.EqualTo(5));
        }

        [Test]
        public void AdditionMaximumIntTest()
        {
            SimpleCalculator calculator = new SimpleCalculator();
            Operation operation = new Operation { ValueA = 2147483647, ValueB = 2, Operator = '+' };

            decimal result = calculator.Calculate(operation);

            Assert.That(result, Is.EqualTo(2147483649));
        }

        [Test]
        public void SubtractionStandardTest()
        {
            SimpleCalculator calculator = new SimpleCalculator();
            Operation operation = new Operation { ValueA = 2, ValueB = 1, Operator = '-' };

            decimal result = calculator.Calculate(operation);

            Assert.That(result, Is.EqualTo(1));
        }

        [Test]
        public void SubtractionWithOneNegativeValueTest()
        {
            SimpleCalculator calculator = new SimpleCalculator();
            Operation operation = new Operation { ValueA = 10, ValueB = -5, Operator = '-' };

            decimal result = calculator.Calculate(operation);

            Assert.That(result, Is.EqualTo(15));
        }

        [Test]
        public void SubtractionWithTwoNegativeValueTest()
        {
            SimpleCalculator calculator = new SimpleCalculator();
            Operation operation = new Operation { ValueA = -10, ValueB = -10, Operator = '-' };

            decimal result = calculator.Calculate(operation);

            Assert.That(result, Is.EqualTo(0));
        }

        [Test]
        public void MultiplicationStandardTest()
        {
            SimpleCalculator calculator = new SimpleCalculator();
            Operation operation = new Operation { ValueA = 10, ValueB = 5, Operator = '*' };

            decimal result = calculator.Calculate(operation);

            Assert.That(result, Is.EqualTo(50));
        }

        [Test]
        public void MultiplicationWithNegativeValuesTest()
        {
            SimpleCalculator calculator = new SimpleCalculator();
            Operation operation = new Operation { ValueA = -2, ValueB = -5, Operator = '*' };

            decimal result = calculator.Calculate(operation);

            Assert.That(result, Is.EqualTo(10));
        }

        [Test]
        public void DivisionStandardTest()
        {
            SimpleCalculator calculator = new SimpleCalculator();
            Operation operation = new Operation { ValueA = 30, ValueB = 5, Operator = '/' };

            decimal result = calculator.Calculate(operation);

            Assert.That(result, Is.EqualTo(6));
        }

        [Test]
        public void DivisionWithNegativeDivisorValueTest()
        {
            SimpleCalculator calculator = new SimpleCalculator();
            Operation operation = new Operation { ValueA = 30, ValueB = -5, Operator = '/' };

            decimal result = calculator.Calculate(operation);

            Assert.That(result, Is.EqualTo(-6));
        }

        [Test]
        public void DivisionWithNegativeDividendValueTest()
        {
            SimpleCalculator calculator = new SimpleCalculator();
            Operation operation = new Operation { ValueA = -40, ValueB = 2, Operator = '/' };

            decimal result = calculator.Calculate(operation);

            Assert.That(result, Is.EqualTo(-20));
        }

        [Test]
        public void DivisionWithZeroDividendTest()
        {
            SimpleCalculator calculator = new SimpleCalculator();
            Operation operation = new Operation { ValueA = 20, ValueB = 0, Operator = '/' };

            Assert.Throws<DivideByZeroException>(() => calculator.Calculate(operation));
        }

    }
}