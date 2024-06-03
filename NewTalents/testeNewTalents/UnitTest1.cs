using NewTalents;

namespace testeNewTalents
{
    public class UnitTest1
    {
        private Calculadora calc;

        public UnitTest1()
        {
            calc = new Calculadora();
        }

        [Theory]
        [InlineData(1, 2, 3)]
        [InlineData(4, 5, 9)]
        public void TesteSomar(int val1, int val2, int resultadoTeste)
        {

            int resultado = calc.somar(val1, val2);

            Assert.Equal(resultadoTeste, resultado);
        }

        [Theory]
        [InlineData(2, 1, 1)]
        [InlineData(5, 2, 3)]
        public void TesteSubtrair(int val1, int val2, int resultadoTeste)
        {

            int resultadoCalculadora = calc.subtrair(val1, val2);

            Assert.Equal(resultadoTeste, resultadoCalculadora);
        }

        [Theory]
        [InlineData(1, 2, 2)]
        [InlineData(4, 5, 20)]
        public void TesteMultiplicar(int val1, int val2, int resultadoTeste)
        {

            double resultadoCalculadora = calc.multiplicar(val1, val2);

            Assert.Equal(resultadoTeste, resultadoCalculadora);
        }

        [Theory]
        [InlineData(6, 2, 3)]
        [InlineData(5, 5, 1)]
        public void TesteDividir(double val1, double val2, double resultadoTeste)
        {

            double resultadoCalculadora = calc.dividir(val1, val2);

            Assert.Equal(resultadoTeste, resultadoCalculadora);
        }

        [Fact]
        public void TestarHistorico()
        {

            int val1 = 1, val2 = 3;
            calc.somar(val1, val2);


            val1 = 2;
            val2 = 3;
            calc.somar(val1, val2);


            val1 = 6;
            val2 = 4;
            calc.subtrair(val1, val2);


            val1 = 6;
            val2 = 3;
            calc.multiplicar(val1, val2);

            val1 = 2;
            val2 = 5;
            calc.dividir(val1, val2);

            var lista = calc.Historico();

            Assert.NotEmpty(calc.Historico());
            Assert.Equal(3, lista.Count);
        }

        [Fact]
        public void TestarDivisaoPorZero()
        {

            Assert.Throws<DivideByZeroException>
                (
                    () => calc.dividir(3, 0)
                );
        }
    }
}