Conta c1 = new Conta(1, "Natália");
Conta c2 = new Conta(2, "Marcela");

Console.WriteLine(c1.Depositar(1000, 1));
Console.WriteLine(c2.Depositar(100, 2));
Console.WriteLine(c1.Saldo);
Console.WriteLine(c2.Saldo);