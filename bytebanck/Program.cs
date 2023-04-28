using bytebanck;

ContaCorrente contaDoMatheus = new ContaCorrente();
contaDoMatheus.titular = "Matheus Manoel";
contaDoMatheus.numero_agencia = 1530;
contaDoMatheus.conta = "1010-x";
contaDoMatheus.saldo = 100;


Console.WriteLine("Saldo da conta do Matheus = " + contaDoMatheus.saldo);

ContaCorrente contaDaMaria = new ContaCorrente();
contaDaMaria.titular = "Maria Souza";
contaDaMaria.numero_agencia = 17;
contaDaMaria.conta = "1010-5";
contaDaMaria.saldo = 350;

Console.WriteLine("Saldo da conta do Maria=" + contaDaMaria.saldo);

contaDoMatheus.Transferir(50, contaDaMaria);
Console.WriteLine("Saldo do Matheus ="+ contaDoMatheus.saldo);
Console.WriteLine("Saldo da Maria =" + contaDaMaria.saldo);