using static System.Console;

public static class Aula1
{
    public static void Demo1()
    {
        WriteLine(" \n DEMO 1 \n ");

        int a = 2;
        a = Adicionar20(a);

        WriteLine($"O valor de a é {a}");
    }

    public static void Demo2()
    {
        WriteLine(" \n DEMO 2 \n ");

        Pessoa p1 = new Pessoa();
        p1.Nome = "Marcos";
        p1.Idade = 29;
        p1.Documento = "687465324657497498732432467987";
        Pessoa p2 = new Pessoa();
        p2.Clonar(p1);

        TrocarNome(p1, "João");

        WriteLine($@"
        O nome de p1 é {p1.Nome}
        O nome de p2 é {p2.Nome}
        ");
    }

    public static void Demo3()
    {
        WriteLine(" \n DEMO 3 \n ");

        string nome = "Nome antigo";
        TrocarNomeString(nome, "Nome novo");

        WriteLine(nome);
    }

    public static void Demo4()
    {
        WriteLine(" \n DEMO 4 \n ");

        int[] numeros = new int[5];

        Preencher(numeros, false);
        WriteLine("Conteúdo alterado para números pares");
        ExibirConteudo(numeros);

        Preencher(numeros, true);
        WriteLine("Conteúdo alterado para números ímpares:");
        ExibirConteudo(numeros);
    }

    public static void Demo5a()
    {
        WriteLine($" \n DEMO 5 \n ");
        int[] numeros = new int[]{19,28,37,46,55,64,73,82,91,0};
        
        WriteLine("Qual numero deve ser buscado na lista?");
        int busca = int.Parse(ReadLine());

        if(EncontrarNumero(numeros, busca))
        {
            WriteLine("Número Encontrado");
        }
        else
        {
            WriteLine("Número não encontrado");
        }
    
    }

    public static void Demo5b()
    {
        List<Pessoa> pessoas = new List<Pessoa>()
        {
            new Pessoa(){Nome = "José"},
            new Pessoa(){Nome = "Maria"},
            new Pessoa(){Nome = "Marcos"},
            new Pessoa(){Nome = "Ricardo"},
            new Pessoa(){Nome = "Luciana"},
            new Pessoa(){Nome = "Edmara"},
            new Pessoa(){Nome = "Jorge"},
            new Pessoa(){Nome = "Carla"},
            new Pessoa(){Nome = "Roberta"},
            new Pessoa(){Nome = "Laura"},
        };

        WriteLine("Qual o nome da pessoa que deseja buscar?");

        if(EncontrarPessoa(pessoas, ReadLine()))
        {
            WriteLine("Pessoa encontrada");
        }
        else
        {
            WriteLine("Pessoa não encontrada");
        }
    }

    private static bool EncontrarPessoa(List<Pessoa> pessoas, string busca)
    {
        foreach(Pessoa p in pessoas)
        {
            if(p.Nome == busca) return true;
        }
        
        return false;
    }

    private static bool EncontrarNumero(int[] numeros, int busca)
    {
        for (int i = 0; i < numeros.Length; i++)
        {
            if(numeros[i] == busca) return true;
        }

        return false;
    }

    static void Preencher(int[] array, bool impar)
    {
        int paridade = impar? 1 : 0;

        for (int i = 0; i < 5; i++)
        {
           array[i] = 2 * i + paridade; 
        }
    }

    static void ExibirConteudo(int[] array)
    {
        WriteLine($"O conteúdo do array é {string.Join(",", array)}");
    }

    static void TrocarNome(Pessoa p, string novoNome)
    {
        p.Nome = novoNome;
    }

    static void TrocarNomeString(string atual, string novo)
    {
        atual = novo;
    }

    static int Adicionar20(int a)
    {
        return (a + 20);
    }
}