using System;
using Xunit;
using System.Collections.Generic;
using NewProject;

namespace NewProject.Tests
{
    public class CalculadoraTests
    {
        private Calculadora construirClasse()
        {
            string data = DateTime.Now.ToShortDateString();
            Calculadora calc = new Calculadora(data);

            return calc;
        }

        [Theory]
        [InlineData(1, 2, 3)]
        [InlineData(4, 5, 9)]
        public void TestSomar(int num1, int num2, int resultado)
        {
            Calculadora calc = construirClasse();

            int resultadoCalculadora = calc.Somar(num1, num2);

            Assert.Equal(resultado, resultadoCalculadora);
        }

        [Theory]
        [InlineData(3, 2, 6)]
        [InlineData(4, 5, 20)]
        public void TestMultiplicar(int num1, int num2, int resultado)
        {
            Calculadora calc = construirClasse();

            int resultadoCalculadora = calc.Multiplicar(num1, num2);

            Assert.Equal(resultado, resultadoCalculadora);
        }

        [Theory]
        [InlineData(6, 2, 3)]
        [InlineData(10, 5, 2)]
        public void TestDividir(int num1, int num2, int resultado)
        {
            Calculadora calc = construirClasse();

            int resultadoCalculadora = calc.Dividir(num1, num2);

            Assert.Equal(resultado, resultadoCalculadora);
        }

        [Theory]
        [InlineData(6, 2, 4)]
        [InlineData(5, 5, 0)]
        public void TestSubtrair(int num1, int num2, int resultado)
        {
            Calculadora calc = construirClasse();

            int resultadoCalculadora = calc.Subtrair(num1, num2);

            Assert.Equal(resultado, resultadoCalculadora);
        }

        [Fact]
        public void TestarDivisaoPorZero()
        {
            Calculadora calc = construirClasse();

            Assert.Throws<DivideByZeroException>(() => calc.Dividir(3, 0));
        }

        [Fact]
        public void TestarHistorico()
        {
            Calculadora calc = construirClasse();

            calc.Somar(1, 2);
            calc.Somar(2, 8);
            calc.Somar(3, 7);
            calc.Somar(4, 1);
            var lista = calc.Historico();

            Assert.NotEmpty(lista);
            Assert.Equal(3, lista.Count);
        }

        [Theory]
        [InlineData(5, 3, 2)]
        [InlineData(10, 7, 3)]
        public void TestModulo(int num1, int num2, int resultado)
        {
            Calculadora calc = construirClasse();

            int resultadoCalculadora = calc.Modulo(num1, num2);

            Assert.Equal(resultado, resultadoCalculadora);
        }

        [Theory]
        [InlineData(2, 3, 8)]
        [InlineData(5, 2, 25)]
        public void TestPotencia(int baseNum, int expoente, double resultado)
        {
            Calculadora calc = construirClasse();

            double resultadoCalculadora = calc.Potencia(baseNum, expoente);

            Assert.Equal(resultado, resultadoCalculadora);
        }

        [Theory]
        [InlineData(16, 4)]
        [InlineData(25, 5)]
        public void TestRaizQuadrada(double num, double resultado)
        {
            Calculadora calc = construirClasse();

            double resultadoCalculadora = calc.RaizQuadrada(num);

            Assert.Equal(resultado, resultadoCalculadora);
        }

        [Theory]
        [InlineData(Math.PI / 2, 1)]
        [InlineData(0, 0)]
        public void TestSeno(double angulo, double resultado)
        {
            Calculadora calc = construirClasse();

            double resultadoCalculadora = calc.Seno(angulo);

            Assert.Equal(resultado, resultadoCalculadora, 5);
        }

        [Theory]
        [InlineData(0, 1)]
        [InlineData(Math.PI, -1)]
        public void TestCosseno(double angulo, double resultado)
        {
            Calculadora calc = construirClasse();

            double resultadoCalculadora = calc.Cosseno(angulo);

            Assert.Equal(resultado, resultadoCalculadora, 5);
        }

        [Theory]
        [InlineData(0, 0)]
        [InlineData(Math.PI / 4, 1)]
        public void TestTangente(double angulo, double resultado)
        {
            Calculadora calc = construirClasse();

            double resultadoCalculadora = calc.Tangente(angulo);

            Assert.Equal(resultado, resultadoCalculadora, 5);
        }

        [Theory]
        [InlineData(100, 10, 2)]
        [InlineData(32, 2, 5)]
        public void TestLogaritmo(double num, double baseLog, double resultado)
        {
            Calculadora calc = construirClasse();

            double resultadoCalculadora = calc.Logaritmo(num, baseLog);

            Assert.Equal(resultado, resultadoCalculadora, 5);
        }

        [Fact]
        public void TestLogaritmoBase10()
        {
            Calculadora calc = construirClasse();

            double resultadoCalculadora = calc.Logaritmo(100);

            Assert.Equal(2, resultadoCalculadora, 5);
        }
    }
}
