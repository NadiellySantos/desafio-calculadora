using Calculadora;
using System;
using Xunit;

namespace TesteCaulculadora
{
    public class UnitTest1
    {
        public CalculadoraDIO construirCalculadora()
        {
            string data = "09/05/2024";
            CalculadoraDIO calc = new CalculadoraDIO(data);

            return calc;
        }
        [Theory]
        [InlineData (1, 2, 3)]
        [InlineData(4, 5, 9)]
        public void TesteSomar(int val1, int val2, int res)
        {
            CalculadoraDIO calc = construirCalculadora();

            int resultado = calc.somar(val1,val2);

            Assert.Equal(res,resultado);
        }

        [Theory]
        [InlineData(6, 2, 4)]
        [InlineData(5, 5, 0)]
        public void TesteSubtrair(int val1, int val2, int res)
        {
            CalculadoraDIO calc = construirCalculadora();

            int resultado = calc.subtrair(val1, val2);

            Assert.Equal(res, resultado);
        }

        [Theory]
        [InlineData(2, 2, 4)]
        [InlineData(4, 5, 20)]
        public void TesteMultiplicar(int val1, int val2, int res)
        {
            CalculadoraDIO calc = construirCalculadora();

            int resultado = calc.multiplicar(val1, val2);

            Assert.Equal(res, resultado);
        }

        [Theory]
        [InlineData(6, 2, 3)]
        [InlineData(5, 5, 1)]
        public void TesteDividir(int val1, int val2, int res)
        {
            CalculadoraDIO calc = construirCalculadora();

            int resultado = calc.dividir(val1, val2);

            Assert.Equal(res, resultado);
        }

        [Fact]
        public void TestarDivisaoPorZero()
        {
            CalculadoraDIO calc = construirCalculadora();


            Assert.Throws<DivideByZeroException>(
                () => calc.dividir(3, 0));
        }

        [Fact]
        public void TestarHistorico()
        {
            CalculadoraDIO calc = construirCalculadora();
            calc.somar(2, 3);
            calc.somar(5, 2);
            calc.somar(6, 7);

            var lista = calc.historico();

            Assert.NotEmpty(calc.historico());
            Assert.Equal(3, lista.Count);
        }
    }
}
