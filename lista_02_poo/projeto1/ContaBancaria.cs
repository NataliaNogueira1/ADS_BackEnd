using System.Dynamic;

public class ContaBancaria
{
    //Atributos
    public int Id { get; private set; }
    public double Saldo { get; private set; }
    public string Titular { get; private set; }

    //Construtor
    public ContaBancaria(int id, string titular)
    {
        Id = id;
        Saldo = 0.0;
        Titular = titular;
    }

    //Métodos
    public bool Depositar(double valor, int id)
    {
        if (Id != id || valor <= 0)
            return false;

        Saldo += valor;
        return true;
    }

    public bool Sacar(double valor, int id)
    {
        if (Id != id || Saldo < valor || valor <= 0)
            return false;

        Saldo -= valor;
        return true;
    }
    
// ToString
    public override string ToString()
    {
        return $"\nId: {Id}\nTitular: {Titular}\nSaldo: {Saldo}\n";
    }

}

