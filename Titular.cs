class Titular
{
    public Titular(string nome, string sobrenome, string cpf, string endereco, int idade)
    {
        Nome = nome;
        Sobrenome = sobrenome;
        Cpf = cpf;
        Endereco = endereco;
        Idade = idade;
    }

    public string Nome { get; }
    public string Sobrenome { get; }
    public string Cpf { get;}
    public string Endereco { get;}
    public int Idade { get; }

}