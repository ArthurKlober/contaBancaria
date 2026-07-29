class ContaBancaria
{
    public int Id { get; set; }
    public Titular Titular { get; set; }
    public float Saldo { get; set; }
    public int Senha { get; set; }
    public int Agencia { get; set; }
    public int Limite { get; set; }


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
    }
}
