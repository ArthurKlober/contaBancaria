ContaBancaria conta1 = new ContaBancaria();

Titular titularConta = new Titular();
titularConta.Nome = "Arthur";
titularConta.Sobrenome = "Klober";
titularConta.Idade = 25;

conta1.Id = 356021;
conta1.Agencia = 2634;
conta1.Saldo = 3500;
conta1.Senha = 12345;
conta1.Limite = 5000;
conta1.Titular = titularConta;

conta1.ExibirInformacoesConta();