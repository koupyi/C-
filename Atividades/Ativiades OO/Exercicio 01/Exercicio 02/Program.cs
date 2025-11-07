using System;

namespace Exercicio_Introducao_a_OO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o primeiro nome e idade:");
            string nome1 = Console.ReadLine()!;
            int idade1 = LerIdade();

            Console.WriteLine("Digite o segundo nome e idade:");
            string nome2 = Console.ReadLine()!;
            int idade2 = LerIdade();

            Pessoa p1 = new Pessoa(nome1, idade1);
            Pessoa p2 = new Pessoa(nome2, idade2);

            string maisVelha = ComparadorDeIdade.PessoaMaisVelha(p1, p2);
            Console.WriteLine($"\nPessoa mais velha: {maisVelha}");

            Console.ReadLine();
        }

        private static int LerIdade()
        {
            while (true)
            {
                if (int.TryParse(Console.ReadLine(), out int idade) && idade >= 0)
                    return idade;

                Console.WriteLine("Idade inválida. Digite um número inteiro não negativo:");
            }
        }
    }
}
