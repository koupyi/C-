using System;

namespace PesoIdealApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite sua altura (em metros, ex: 1,75): ");
            double altura = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite seu sexo (M/F): ");
            char sexo = Convert.ToChar(Console.ReadLine());

            Pessoa pessoa = new Pessoa();
            pessoa.Altura = altura;
            pessoa.Sexo = sexo;

            try
            {
                double pesoIdeal = pessoa.CalcularPesoIdeal();
                Console.WriteLine($"\nSeu peso ideal é: {pesoIdeal:F2} kg");
            }
            catch (Exception ex)
            {
                Console.WriteLine("\nErro: " + ex.Message);
            }

            Console.WriteLine("\nPressione qualquer tecla para sair...");
            Console.ReadKey();
        }
    }
}
