using NewProject;

class Program
{
    static void Main(string[] args)
    {
        String data = DateTime.Now.ToShortDateString();
        Calculadora calc = new Calculadora(data);

        int dividir = calc.Dividir(4, 0);
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