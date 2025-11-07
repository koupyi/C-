class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Cálculo do Peso Ideal");

        Console.Write("Digite a altura em metros (ex: 1,75): ");
        double altura = double.Parse(Console.ReadLine());

        Console.Write("Digite o sexo (M/F): ");
        char sexo = char.Parse(Console.ReadLine());

        Pessoa pessoa = new Pessoa(altura, sexo);

        try
        {
            double pesoIdeal = pessoa.CalcularPesoIdeal();
            Console.WriteLine($"\nPeso ideal: {pesoIdeal:F2} kg");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Erro: {ex.Message}");
        }

        Console.WriteLine("\nPressione qualquer tecla para sair...");
        Console.ReadKey();
    }
}
