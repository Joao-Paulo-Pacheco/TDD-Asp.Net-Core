using System.Collections.Generic;
using TesteUnitario.Calculators;
using TesteUnitario.Tests.Fixtures;
using Xunit;

namespace TesteUnitario.Tests.Calculators
{
    public class CalculatorTest
    {
        #region FACT NORMAL

        [Fact]
        public void CalculatorSumResultTwo()
        {
            //Arrange
            var calculator = new Calculator();

            //Act
            int result = calculator.Sum(1, 1);

            //Assert
            Assert.Equal(2, result);
        }
        #endregion

        #region THEORY INLINEDATA
        // Facilita teste de métodos que podem receber vários parametros de entradas. 
        // Dessa maneira, não precisa criar um método para cada caso de teste
        // Cada InlineData é um teste, o ultimo parametro é o resultado esperado

        [Theory]
        [InlineData(1, 1, 2)]
        [InlineData(21, 2, 23)]
        public void CalculatorSumResultIsValid(int a, int b, int resultExpected)
        {
            //Arrange
            var calculator = new Calculator();

            //Act
            int result = calculator.Sum(a, b);

            //Assert
            Assert.Equal(result, resultExpected);
        }
        #endregion

        #region THEORY CLASSDATA
        // Facilita teste de métodos que podem receber vários parametros de entradas. 
        // Dessa maneira, não precisa criar um método para cada caso de teste
        // Parecido com o InlineData (exemplo apresentado acima), porém, se tiver vários testes possíveis,
        // o ClassData deixa o código mais limpo, pois cria um objeto separado para tal

        [Theory]
        [ClassData(typeof(ValuesFixture))]
        public void CalculatorSumResultIsValidWithClassData(int a, int b, int resultExpected)
        {
            //Arrange
            var calculator = new Calculator();

            //Act
            int result = calculator.Sum(a, b);

            //Assert
            Assert.Equal(result, resultExpected);
        }
        #endregion

        #region THEORY MEMBERDATA
        // Facilita teste de métodos que podem receber vários parametros de entradas. 
        // Dessa maneira, não precisa criar um método para cada caso de teste
        // Parecido com o ClassData (exemplo apresentado acima), porém, não precisa criar um objeto separado.

        [Theory]
        [MemberData(nameof(GetNumber))]
        public void CalculatorSumResultIsValidWithMemberData(int a, int b, int resultExpected)
        {
            //Arrange
            var calculator = new Calculator();

            //Act
            int result = calculator.Sum(a, b);

            //Assert
            Assert.Equal(result, resultExpected);
        }

        public static IEnumerable<object[]> GetNumber()
        {
            yield return new object[] { 1, 2, 3 };
            yield return new object[] { 2, 3, 5 };
        }
        #endregion
    }
}
