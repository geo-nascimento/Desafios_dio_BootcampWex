using CalculadoraTDD.BasicFunctions;

Calculadora _calc = new Calculadora();

Menu();

void Menu()
{
    Console.WriteLine("Calculadora:");
    Console.WriteLine("Escolha a operação: ");
    Console.WriteLine("1. Adição\n2. Subtração\n3. Divisão\n4. Multiplicação\n5. Área do quadrado\n6. Área do triangulo\n7. Área do circulo\n8. Mostrar histórico\n9. Sair");
    Console.Write("Opção: ");
    try
    {
        int option = int.Parse(Console.ReadLine()!);
        Console.Clear();
        Operations(option);
    } 
    catch(ArgumentException) 
    {
        Console.WriteLine("forneça uma opção válida");
        Console.ReadKey();
        Console.Clear();
        Menu();
    }
    catch (FormatException)
    {
        Console.WriteLine("forneça uma opção válida");
        Console.ReadKey();
        Console.Clear();
        Menu();
    }
}

void Operations(int option)
{
    try
    {
        switch (option)
        {
            case 1:
                Console.WriteLine("Adição");
                Console.Write("Parcela 1: ");
                double parcela1 = double.Parse(Console.ReadLine()!);
                Console.Write("Parcela 2: ");
                double parcela2 = double.Parse(Console.ReadLine()!);
                Console.WriteLine($"Total: {parcela1} + {parcela2} = {_calc.Somar(parcela1, parcela2)}");
                Console.ReadKey();
                Console.Clear();
                Menu();
                break;
            case 2:
                Console.WriteLine("Subtração");
                Console.Write("Minuendo: ");
                double minuendo = double.Parse(Console.ReadLine()!);
                Console.Write("Subtraendo: ");
                double subtraendo = double.Parse(Console.ReadLine()!);
                Console.WriteLine($"Total: {minuendo} - {subtraendo} = {_calc.Subtrair(minuendo, subtraendo)}");
                Console.ReadKey();
                Console.Clear();
                Menu();
                break;
            case 3:
                Console.WriteLine("Divisão");
                Console.Write("Parcela 1: ");
                double dividendo = double.Parse(Console.ReadLine()!);
                Console.Write("Parcela 2: ");
                double divisor = double.Parse(Console.ReadLine()!);
                Console.WriteLine($"Total: {dividendo} / {divisor} = {_calc.Dividir(dividendo, divisor)}");
                Console.ReadKey();
                Console.Clear();
                Menu();
                break;
            case 4:
                Console.WriteLine("Multiplicação");
                Console.Write("fator 1: ");
                double fator1 = double.Parse(Console.ReadLine()!);
                Console.Write("fator 2: ");
                double fator2 = double.Parse(Console.ReadLine()!);
                Console.WriteLine($"Total: {fator1} x {fator2} = {_calc.Multiplicar(fator1, fator2)}");
                Console.ReadKey();
                Console.Clear();
                Menu();
                break;
            case 5:
                Console.WriteLine("Área do quadrado");
                Console.Write("Lado: ");
                double lado = double.Parse(Console.ReadLine()!);
                Console.WriteLine($"Área = {_calc.AreaQuadrado(lado)}");
                Console.ReadKey();
                Console.Clear();
                Menu();
                break;
            case 6:
                Console.WriteLine("Área do triângulo");
                Console.Write("Base: ");
                double ladoBase = double.Parse(Console.ReadLine()!);
                Console.Write("Altura: ");
                double altura = double.Parse(Console.ReadLine()!);
                Console.WriteLine($"Área = {_calc.AreaTriangulo(ladoBase, altura)}");
                Console.ReadKey();
                Console.Clear();
                Menu();
                break;
            case 7:
                Console.WriteLine("Área do circulo");
                Console.Write("raio: ");
                double raio = double.Parse(Console.ReadLine()!);
                Console.WriteLine($"Área = {_calc.AreaCirculo(raio)}");
                Console.ReadKey();
                Console.Clear();
                Menu();
                break;
            case 8:
                Console.WriteLine("Histórico de operações:");
                var historico = _calc.RetornarHistorico();
                foreach(var item in historico)
                {
                    Console.WriteLine(item.ToString());
                }
                Console.ReadKey();
                Console.Clear();
                Menu();
                break;
            case 9:
                Environment.Exit(0);
                break; 
        }
    }
    catch (Exception e)
    {
        Console.WriteLine("Não foi possível completar a operação: " + e.Message);
        Console.ReadKey();
        Console.Clear();
        Menu();
    }
}