using System.Dynamic;

public class Conta
{
    //Atributos
    public int Numero { get; private set; }
    public double Saldo { get; private set; }
    public string Titular { get; set; }

    //Construtor
    public Conta(int numero, string titular)
    {
        Numero = numero;
        Saldo = 0.0;
        Titular = titular;
    }

    //Métodos
    public bool Depositar(double valor, int numero)
    {
        if (Numero != numero || valor <= 0)
            return false;

        Saldo += valor;
        return true;
    }

    public bool Sacar(double valor, int numero)
    {
        if (Numero != numero || Saldo < valor || valor <= 0)
            return false;

        Saldo -= valor;
        return true;
    }

    //Getters and setters
    /*
    public int GetNumero()
    {
        return Numero;
    }

    public string GetTitular()
    {
        return Titular;
    }

    public void SetTitular(string titular)
    {
        Titular = titular;
    }

    public double GetSaldo()
    {
        return Saldo;
    }

*/
    
// ToString
    public override string ToString()
    {
        return $"\nNumero: {Numero}\nTitular: {Titular}\nSaldo: {Saldo}\n";
    }

}

