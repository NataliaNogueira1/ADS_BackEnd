Conta c1 = new Conta(1, "Natália");
Conta c2 = new Conta(2, "Marcela");

if (c1.Saldo == 0.0)
    c1.Depositar(100, 1);

c1.Titular = "Natália Nogueira";
Console.WriteLine(c1);

//Versão get e set manual
// if (c1.GetSaldo() == 0.0)
//     c1.Depositar(100, 1);

// c1.SetTitular("Natália Nogueira");
// Console.WriteLine(c1);


//Testes
// Console.WriteLine(c1);
// Console.WriteLine(c2);

// c1.Depositar(1000, 1);
// c2.Depositar(10, 2);

// Console.WriteLine(c1);
// Console.WriteLine(c2);

// c1.Sacar(1, 1);
// c2.Sacar(5, 2);

// Console.WriteLine(c1);
// Console.WriteLine(c2);