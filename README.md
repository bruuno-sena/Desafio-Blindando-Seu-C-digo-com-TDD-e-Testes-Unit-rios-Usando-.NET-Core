# Desafio Blindando Seu Código com TDD e Testes Unitários Usando .NET Core

Este projeto é uma implementação de uma calculadora científica em C#. A calculadora suporta operações básicas (soma, subtração, multiplicação e divisão), bem como operações científicas (potência, raiz quadrada, seno, cosseno, tangente e logaritmo). Além disso, há uma funcionalidade de histórico que mantém registro das três operações mais recentes.

## Estrutura do Projeto

- **NewProject**: Diretório principal contendo a classe `Calculadora`.
- **NewProject.Tests**: Diretório contendo os testes unitários usando xUnit.

## Funcionalidades

### Operações Básicas

- **Somar**: `Somar(int num1, int num2)`
- **Subtrair**: `Subtrair(int num1, int num2)`
- **Multiplicar**: `Multiplicar(int num1, int num2)`
- **Dividir**: `Dividir(int num1, int num2)` (lança exceção para divisão por zero)
- **Modulo**: `Modulo(int num1, int num2)`

### Operações Científicas

- **Potência**: `Potencia(int baseNum, int expoente)`
- **Raiz Quadrada**: `RaizQuadrada(double num)`
- **Seno**: `Seno(double angulo)`
- **Cosseno**: `Cosseno(double angulo)`
- **Tangente**: `Tangente(double angulo)`
- **Logaritmo**: `Logaritmo(double num, double baseLog = 10)`

### Histórico

- **Historico**: `Historico()` (demonstra as três últimas operações)

## Exemplo de Uso

```csharp
using System;
using NewProject;

using NewProject;

class Program
{
    static void Main(string[] args)
    {
        String data = DateTime.Now.ToShortDateString();
        Calculadora calc = new Calculadora(data);

        int dividir = calc.Dividir(4, 5);
        Console.WriteLine($"Divisão: {dividir}");

        int subtrair = calc.Subtrair(4, 5);
        Console.WriteLine($"Subtrair: {subtrair}");

        int soma = calc.Somar(4, 5);
        Console.WriteLine($"Soma: {soma}");

        int multiplicacao = calc.Multiplicar(3, 2);
        Console.WriteLine($"Multiplicação: {multiplicacao}");

        double raizQuadrada = calc.RaizQuadrada(16);
        Console.WriteLine($"Raiz Quadrada: {raizQuadrada}");

        var historico = calc.Historico();
        Console.WriteLine("Histórico:");
        historico.ForEach(Console.WriteLine);
    }
}
