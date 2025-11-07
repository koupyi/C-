using System;

class Pessoa
{
    public double Altura { get; set; }
    public char Sexo { get; set; }
    public Pessoa(double altura, char sexo)
    {
        Altura = altura;
        Sexo = Char.ToUpper(sexo);
    }

    public double CalcularPesoIdeal()
    {
        if (Sexo == 'M')
        {
            return (72.7 * Altura) - 58;
        }
        else if (Sexo == 'F')
        {
            return (62.1 * Altura) - 44.7;
        }
        else
        {
            throw new Exception("Sexo inválido! Use M para masculino ou F para feminino.");
        }
    }
}