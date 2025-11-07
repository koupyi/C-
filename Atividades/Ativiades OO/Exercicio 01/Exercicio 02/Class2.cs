namespace Exercicio_Introducao_a_OO
{
    public static class ComparadorDeIdade
    {
        public static string PessoaMaisVelha(Pessoa p1, Pessoa p2)
        {
            if (p1.Idade > p2.Idade)
                return p1.Nome;

            if (p2.Idade > p1.Idade)
                return p2.Nome;

            return "Ambos possuem a mesma idade";
        }
    }
}
