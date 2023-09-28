using CalculadoraTDD.BasicFunctions;
using System;

namespace CalculadoraTestes
{
    public class CalculadoraTestes
    {
        private Calculadora _calc = new Calculadora();

        [Fact]
        public void DeveSomarCincoECincoERetornarDez()
        {
            //Arrange
            double num1 = 5;
            double num2 = 5;
            //Act
            double result = _calc.Somar(num1, num2);
            //Assert
            Assert.Equal(10, result);
        }

        [Theory]
        [InlineData(2, 8, 10)]
        [InlineData(3, 7, 10)]
        [InlineData(9, 1, 10)]
        public void DeveSomarDiferentesNumerosESempreRetornarDez(double num1, double num2, double resultadoEsperado)
        {
            //Act
            var resultadoTeste = _calc.Somar(num1, num2);
            //Assert
            Assert.Equal(resultadoEsperado, resultadoTeste);
        }

        [Fact]
        public void DeveSubtrair20De100ERetornar80()
        {
            //Arrange
            double num1 = 100;
            double num2 = 20;
            //Act
            double result = _calc.Subtrair(num1, num2);
            //Assert
            Assert.Equal(80, result);

        }

        [Theory]
        [InlineData(100, 80, 20)]
        [InlineData(80, 60, 20)]
        [InlineData(120, 100, 20)]
        public void DeveSubtrairDiferentesNumerosESempreRetornar20(double num1, double num2, double resultadoEsperado)
        {
            //Arrange
            double resultadoTeste = _calc.Subtrair(num1, num2);
            //Assert
            Assert.Equal(resultadoEsperado, resultadoTeste);
        }

        [Fact]
        public void DeveMultiplicar6Por6ERetornar36()
        {
            //Arrange
            double num1 = 6;
            double num2 = 6;
            //Act
            double result = _calc.Multiplicar(num1, num2);
            //Assert
            Assert.Equal(36, result);
        }

        [Theory]
        [InlineData(12, 10, 120)]
        [InlineData(40, 3, 120)]
        [InlineData(60, 2, 120)]
        public void DeveMultiplicarDiferentesNumerosESempreRetornar123(double num1, double num2, double resultadoEsperado)
        {
            //Act
            double resultadoTeste = _calc.Multiplicar(num1, num2);
            //Assert
            Assert.Equal(resultadoEsperado, resultadoTeste);
        }

        [Fact]
        public void DeveDividir100Por2ERetornar50()
        {
            //Arrange
            double num1 = 100.0;
            double num2 = 2.0;
            //Act
            double result = _calc.Dividir(num1, num2);
            //Assert
            Assert.Equal(50, result);
        }

        [Fact]
        public void DeveDividir20Por0ERetornarUmaExcecaoDivideByZero()
        {
            //Arrange
            double num1 = 20;
            double num2 = 0;
            //Assert
            Assert.Throws<DivideByZeroException>(() => _calc.Dividir(num1, num2));
        }

        [Theory]
        [InlineData(25, 5, 5)]
        [InlineData(35, 7, 5)]
        [InlineData(50, 10, 5)]
        public void DeveDividirDiferentesNumerosEsempreRetorar5(double num1, double num2, double resultadoEsperado)
        {
            //Act
            double resultadoTeste = _calc.Dividir(num1, num2);
            //Assert
            Assert.Equal(resultadoEsperado, resultadoTeste);
        }

        [Fact]
        public void DeveRealizarAPotencia16Elevado2ERetornar256()
        {
            //Arrange
            double num = 16;
            int expoente = 2;
            //Act
            double result = _calc.Potencia(num, expoente);
            //Assert
            Assert.Equal(256, result);
        }

        [Fact]
        public void DeveCalcularARaizQuadradaDe256ERetornar16()
        {
            //Arrange
            double num = 256;
            //Act
            double resul = _calc.RaizQuadrada(num);
            //assert
            Assert.Equal(16, resul);
        }

        [Fact]
        public void DeveCalcularAreaDeQuadradoDeLado4ERetornar16()
        {   
            //arrange
            double lado = 4;
            //act
            double result = _calc.AreaQuadrado(lado);
            //assert
            Assert.Equal(16, result);
        }

        [Fact]
        public void DeveCalcularAreaDeTrianguloDeBase4Altura2ERetornar4()
        {
            //arrange
            double baselado = 4;
            double altura = 2;
            //act
            double result = _calc.AreaTriangulo(baselado, altura);
            //assert
            Assert.Equal(4, result);
        }

        [Fact]
        public void DeveCalcularAreaDoCirculoDeRaio6ERetornar11304()
        {
            //arrange
            double raio = 6;
            //act
            double result = _calc.AreaCirculo(raio);
            //assert
            Assert.Equal(113.04, result);
        }

        [Fact]
        public void DeveCalcularAreaDeQuadradoDeladoZeroERetornarExcecao()
        {
            //arrange
            double lado = 0;
            //assert
            Assert.Throws<NotSupportedException>(() => _calc.AreaQuadrado(lado));
        }

        [Fact]
        public void DeveCalcularAreaDeTrianguloDeladoZeroERetornarExcecao()
        {
            //arrange
            double lado = 0;
            double altura = 10;
            //assert
            Assert.Throws<NotSupportedException>(() => _calc.AreaTriangulo(lado, altura));
        }

        [Fact]
        public void DeveCalcularAreaDoCirculoDeRaioNegativoERetornarExcecao()
        {
            //arrange
            double raio = -3;
            //assert
            Assert.Throws<NotSupportedException>(() => _calc.AreaCirculo(raio));
        }

        [Fact]
        public void DeveProcurarelementosNaListaERetornar3Itens()
        {
            //Arrange 
            _calc.Somar(5, 5);
            _calc.Somar(6, 6);
            _calc.Somar(7, 8);
            _calc.Somar(1, 5);
            _calc.Somar(-5, 10);

            var result = _calc.RetornarHistorico();
            //Assert
            Assert.Equal(3, result.Count);
            
        }
    }
}