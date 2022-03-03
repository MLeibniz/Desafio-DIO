using static System.Console;

public static class Aula3
{
    public static void Demo1()
    {
        WriteLine(" \n DEMO 1 \n");
        Humano h1 = new Humano
        {
            Nome = "Marcos",
            Idade = 156,
            Endereco = new Endereco()
            {
                Numero = 10,
                Logradouro = "Acaranjuba",
                CEP = "07561-123987",
                Cidade = "Sim"
            }
        };
    }
}