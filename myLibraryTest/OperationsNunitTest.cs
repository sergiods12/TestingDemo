using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myLibrary
{
    [TestFixture]
    public class OperationsNunitTest
    {
        [Test]
        public void Add_ImputNumbers_ReturnNumbers()
        {

            //1. Arrange
            //Operations operations = new Operations();
            //Operations operations = new ();
            var operations = new Operations();
            int number1 = 2;
            int number2 = 5;
            //int expectedResult = 7;

            //2. Act
            int result = operations.Add(number1, number2);

            //3. Assert
            //Assert.That(result, Is.EqualTo(expectedResult));
            //Assert.That(result, Is.Not.EqualTo(expectedResult));

            Assert.That(result, Is.EqualTo(9));
            Assert.That(result, Is.Not.EqualTo(8));
            Assert.That(result, Is.Not.EqualTo(6));


        }

        //Lo siguiente comentado en verde de este apartado es otra opción menos vistosa, mejor la que está sin comentar
        [Test]
        [TestCase(10)]
        //[TestCase(10, ExpectedResult = true)]
        [TestCase(12)]
        //[TestCase(11, ExpectedResult = false)]
        [TestCase (14)]
        //[TestCase(14, ExpectedResult = true)]

        public void IsEven_ImputNumber_ReturnTrue(int number)
        //public bool IsEven_ImputNumber_ReturnTrue(int number)

        {
            //1. Arrange
            Operations operations = new Operations();
            //comentamos esto porque ponemos los ejemplos que salen arriba en el testCase
            //int number = 10;

            var result = operations.IsEven(number);

            Assert.That(result, Is.True);
            //Otra forma menos guapa
            //return result

        }

        [Test]
        [TestCase(2.2, 1.2)]
        [TestCase(2.23, 1.24)]

        public void AddDecimal_ImputDoubleNumbers_ReturnsDoubleNumber(double number1, double number2)
        {
            Operations operations = new();

            double result = operations.AddDecimal(number1, number2);

            Assert.That(result, Is.EqualTo(3.4).Within(0.1));

        }

    }
}
