using System;

namespace CalculadoraTDD.BasicFunctions;

public class Calculadora
{

    private List<string> _historico;

    public Calculadora()
    {
        _historico = new List<string>();
    }

    public double Somar(double num1, double num2)
    {
        double result = num1 + num2;

        _historico.Insert(0, $"Operação: \n {num1} + {num2} = {result}");

        return result;
    }

    public double Subtrair(double num1, double num2)
    {
        double result = num1 - num2;

        _historico.Insert(0, $"Operação: \n {num1} - {num2} = {result}");

        return result;
    }

    public double Multiplicar(double num1, double num2)
    {
        double result = num1 * num2;

        _historico.Insert(0, $"Operação: \n {num1} x {num2} = {result}");

        return result;
    }

    public double Dividir(double num1, double num2)
    {
        if (num2 == 0)
        {
            throw new DivideByZeroException("O denominador da operação deve ser diferente de zero. Divisões por zero não são possíveis");
        }

        double result = num1 / num2;

        _historico.Insert(0, $"Operação: \n {num1} / {num2} = {result}");

        return result;
    }

    public double Potencia(double num, int expoente)
    {
        double result = Math.Pow(num, expoente);

        _historico.Insert(0, $"Operação: \n {num}^{expoente} = {result}");

        return result;
    }

    //TODO
    public double RaizQuadrada(double num)
    {
        if (num < 0)
        {
            throw new NotSupportedException("Não é possível operar com números negativos");
        }

        double result = Math.Sqrt(num);

        _historico.Insert(0, $"Operação: \n  Raiz quadrada de {num} = {result}");

        return result;
    }

    public double AreaQuadrado(double lado)
    {
        if (lado <= 0)
        {
            throw new NotSupportedException("Não é possível operar com números negativos");
        }

        double result = Math.Pow(lado, 2);

        _historico.Insert(0, $"Operação: \n  Area do quadrado de lado {lado} é {result}");

        return result;
    }

    public double AreaTriangulo(double ladoBase, double altura)
    {
        if (ladoBase <= 0 || altura <= 0)
        {
            throw new NotSupportedException("Não é possível operar com números negativos");
        }
        double result = ladoBase * altura / 2;

        _historico.Insert(0, $"Operação: \n  Area do triângulo de base {ladoBase} e altura {altura} é {result}");

        return result;
    }

    public double AreaCirculo(double raio)
    {
        if (raio <= 0)
        {
            throw new NotSupportedException("Não é possível operar com números negativos");
        }

        double result =  3.14 * Math.Pow(raio, 2);

        _historico.Insert(0, $"Operação: \n  Area do circulo de raio {raio} é {result}");

        return result;
    }

    public List<string> RetornarHistorico()
    {
        if (!_historico.Any())
        {
            throw new Exception("Lista está vazia");
        }
       _historico.RemoveRange(3, _historico.Count - 3);
        return _historico;
    }
}
