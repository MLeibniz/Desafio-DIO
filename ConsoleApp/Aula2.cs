using static System.Console;
public static class Aula2
{
    public static void Demo1()
    {
        WriteLine("DEMO 1");
        int a = 5;
        Adicionar20(ref a);
        WriteLine($"O valor de A é: {a}");
    }

    public static void Demo2()
    {
        WriteLine("DEMO 2");
        string[] nomes = new string[]{"José", "Maria", "Jorge", "Cláudia", "Luana", "Mário"};

        WriteLine("Digite o nome a ser substituído");
        string atual = ReadLine();
        WriteLine("Digite o nome substituto");
        string novo = ReadLine();

        SubstituirNome(nomes, LocalizarIndiceNome(nomes, atual), novo);
        
        WriteLine(string.Join(", ", nomes));
    }

    static int LocalizarIndiceNome(string[] nomes, string nomeAtual)
    {
        for(int i = 0; i < nomes.Length; i++)
        {
            if(nomes[i] == nomeAtual)
            {
                return i;
            }
        }
        return -1;
    }

    static void SubstituirNome(string[] nomes, int index, string nomeNovo)
    {
        nomes[index] = nomeNovo;
    }

    private static void Adicionar20(ref int a)
    {
        a += 20;
    }
}