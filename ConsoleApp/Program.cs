using static System.Console;

Demo1();
Demo2();

static void Demo1()
{
    int a = 2;
    a = Adicionar20(a);

    WriteLine($"O valor de a é {a}");
}

static void Demo2()
{
    Pessoa p1 = new Pessoa();
    p1.Nome = "Marcos";
    p1.Idade = 29;
    p1.Documento = "687465324657497498732432467987";
    TrocarNome(p1, "João");
    WriteLine($"O novo nome de p1 é {p1.Nome}");
}

static void TrocarNome(Pessoa p, string novoNome)
{
    p.Nome = novoNome;
}

static int Adicionar20(int a)
{
    return (a + 20);
}