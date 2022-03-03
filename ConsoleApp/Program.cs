Demo1();

static void Demo1()
{
    int a = 2;
    a = Adicionar20(a);

    Console.WriteLine($"O valor de a é {a}");
}

static int Adicionar20(int a)
{
    return (a + 20);
}