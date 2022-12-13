using bytebank.Contas;
using bytebank.Titular;

ContaCorrente contaDoAndre = new ContaCorrente(15, "1009-X");
contaDoAndre.Titular = new Cliente();
contaDoAndre.Titular.Nome = "Andre Silva";
contaDoAndre.SetSaldo(100);
Console.WriteLine("Saldo da conta do André = " + contaDoAndre.GetSaldo());

ContaCorrente contaDaMaria = new ContaCorrente(15, "1012-X");
contaDaMaria.Titular = new Cliente();
contaDaMaria.Titular.Nome = "Maria Ramos";
contaDaMaria.SetSaldo(1000);

Console.WriteLine("Saldo da conta da Maria = " + contaDaMaria.GetSaldo());

contaDoAndre.Transferir(50, contaDaMaria);
Console.WriteLine("Saldo do André = " + contaDoAndre.GetSaldo());
Console.WriteLine("Saldo do Maria = " + contaDaMaria.GetSaldo());

ContaCorrente contaDoPedro = new ContaCorrente(15, "1013-X");
contaDoPedro.Titular = new Cliente();
contaDoPedro.Titular.Nome = "Pedro Domingos";
Console.WriteLine(contaDoPedro.Titular.Nome);
Console.WriteLine(contaDoPedro.GetSaldo());
Console.WriteLine(contaDoPedro.Agencia);
Console.WriteLine(contaDoPedro.Conta);


Cliente cliente = new Cliente();
cliente.Nome = "Rodolfo Luna";
cliente.Cpf = "123456789";
cliente.Profissao = "Manutencista de impressora";

ContaCorrente conta = new ContaCorrente(18, "1010-X");
conta.Titular = cliente;
conta.SetSaldo(100);

Console.WriteLine("Titular = " + conta.Titular.Nome);
Console.WriteLine("CPF = " + conta.Titular.Cpf);
Console.WriteLine("Profissão = " + conta.Titular.Profissao);
Console.WriteLine("Numero da conta = " + conta.Conta);
Console.WriteLine("Numero da agência = " + conta.Agencia);
Console.WriteLine("Saldo = " + conta.GetSaldo());

ContaCorrente conta2 = new ContaCorrente(18, "1011-X");
conta2.Titular = new Cliente();
conta2.Titular.Nome = "Rogério Ramos";
conta2.Titular.Profissao = "Estudante";
conta2.Titular.Cpf = "987654321";
conta2.SetSaldo(300);

Console.WriteLine(conta2.Titular.Nome);

ContaCorrente conta3 = new ContaCorrente(18, "1012- X");
conta3.SetSaldo(300);
conta3.Conta = "1011-H";
Console.WriteLine(conta3.GetSaldo());
Console.WriteLine(conta3.Agencia);
Console.WriteLine(conta3.Conta);

ContaCorrente conta4 = new ContaCorrente(18, "1010-X");
conta4.SetSaldo(500);
conta4.Titular = new Cliente();

Console.WriteLine(conta4.GetSaldo());
Console.WriteLine(conta4.Agencia);

ContaCorrente conta5 = new ContaCorrente(283, "1234-X");
Console.WriteLine(ContaCorrente.TotalDeContasCriadas);

ContaCorrente conta6 = new ContaCorrente(284, "1235-Y");
Console.WriteLine(ContaCorrente.TotalDeContasCriadas);

ContaCorrente conta7 = new ContaCorrente(285, "1236-Z");
Console.WriteLine(ContaCorrente.TotalDeContasCriadas);


Cliente cliente1 = new Cliente();
cliente1.Nome = "Sarah Silva";
cliente1.Profissao = "Professora";
cliente1.Cpf = "11111111-12";

Cliente cliente2 = new Cliente();
cliente2.Nome = "Ester Almeida";
cliente2.Profissao = "Advogada";
cliente2.Cpf = "868524125-32";

Console.WriteLine("Total de clientes: " + Cliente.TotalClientes);

