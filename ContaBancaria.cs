class ContaBancaria
{
    public ContaBancaria(int id, Titular titular, float saldo, int agencia, int limite)
    {
        Id = id;
        Titular = titular;
        Saldo = saldo;
        Agencia = agencia;
        Limite = limite;
    }

    public int Id { get; }
    public Titular Titular { get;  }
    public float Saldo { get;  }
    public int Senha { get; set; }
    public int Agencia { get; }
    public int Limite { get; }


    public void ExibirInformacoesConta()
    {
        Console.WriteLine($"### INFORMAÇÕES DA CONTA ###");
        Console.WriteLine($"Número da conta: {Id}");
        Console.WriteLine($"Agência: {Agencia}");
        Console.WriteLine($"Saldo: R${Saldo}");
        Console.WriteLine($"Limite disponível: R${Limite}");
        Console.WriteLine($"### INFORMAÇÕES DO TITULAR ###");
        Console.WriteLine($"Nome: {Titular.Nome}");
        Console.WriteLine($"Sobrenome: {Titular.Sobrenome}");
        Console.WriteLine($"Idade: {Titular.Idade}");
        Console.WriteLine($"Endereço: {Titular.Endereco}");
        Console.WriteLine($"CPF: {Titular.Cpf}");
    }
}
