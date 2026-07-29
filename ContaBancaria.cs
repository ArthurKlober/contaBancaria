public class ContaBancaria
{
    public int id;
    public float saldo;
    public int senha;
    public string titular;
    
    public void ExibirInformacoesConta()
    {
        Console.WriteLine($"### INFORMAÇÕES DA CONTA ###");
        Console.WriteLine($"Número da conta: {id}");
        Console.WriteLine($"Saldo: R${saldo}");
        Console.WriteLine($"Titular: {titular}");
    }
}
