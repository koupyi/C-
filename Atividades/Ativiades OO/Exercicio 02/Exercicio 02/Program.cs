using System;

namespace Exercicio02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o primeiro nome:");
            string nome1 = Console.ReadLine();
            Console.WriteLine("Digite o salário:");
            double salario1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite o segundo nome:");
            string nome2 = Console.ReadLine();
            Console.WriteLine("Digite o salário:");
            double salario2 = double.Parse(Console.ReadLine());

            Pessoa pessoa1 = new Pessoa(nome1, salario1);
            Pessoa pessoa2 = new Pessoa(nome2, salario2);

            double media = CalculadoraSalario.CalcularMedia(pessoa1, pessoa2);

            Console.WriteLine($"Salário médio = {media:F2}");
            Console.ReadLine();
        }
    }
}
