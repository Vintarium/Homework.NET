namespace Homework_1
{
   
        [TestClass] 
        public class CalculatorTests
        {
            [TestMethod] 
            public void Add_TwoNumbers_ReturnsCorrectSum()
            {
               
                double a = 10;
                double b = 5;
                double expected = 15;

            
                double actual = Calculator.Add(a, b);

               
                Assert.AreEqual(expected, actual);
            }

            [TestMethod]
            public void Subtract_TwoNumbers_ReturnsCorrectDifference()
            {
               
                double a = 20;
                double b = 5;
                double expected = 15;

             
                double actual = Calculator.Subtract(a, b);

             
                Assert.AreEqual(expected, actual);
            }

            [TestMethod]
            public void Multiply_TwoNumbers_ReturnsCorrectProduct()
            {
             
                double a = 7;
                double b = 3;
                double expected = 21;

              
                double actual = Calculator.Multiply(a, b);

         
                Assert.AreEqual(expected, actual);
            }

            [TestMethod]
            public void Divide_ValidNumbers_ReturnsCorrectQuotient()
            {
             
                double a = 20;
                double b = 4;
                double expected = 5;

                double actual = Calculator.Divide(a, b);

              
                Assert.AreEqual(expected, actual);
            }

            [TestMethod]
            [ExpectedException(typeof(DivideByZeroException))] 
            public void Divide_ByZero_ThrowsDivideByZeroException()
            {
               
                double a = 10;
                double b = 0;

              
                Calculator.Divide(a, b);
            }
        }
    }


