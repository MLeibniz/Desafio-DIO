using static System.Console;

public static class Demo
{
    public static void Demo1()
    {
        int a = 2;
        a = Adicionar20(a);

        WriteLine($"O valor de a é {a}");
    }

    public static void Demo2()
    {
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

    }

    static void TrocarNome(Pessoa p, string novoNome)
    {
        p.Nome = novoNome;
    }

    static int Adicionar20(int a)
    {
        return (a + 20);
    }

}