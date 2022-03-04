public class Pessoa
{
    public int Idade {get; set;}
    public string Nome {get; set;}
    public string Documento {get; set;}

    public void Clonar(Pessoa referencia)
    {
        this.Nome = referencia.Nome;
        this.Documento = referencia.Documento;
        this.Idade = referencia.Idade;
    }
}