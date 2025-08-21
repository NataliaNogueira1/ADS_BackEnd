public class Conta
{
    //Atributos
    public int Numero;
    public double Saldo;
    public string Titular;

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
        if (Numero != numero)
            return false;

        Saldo += valor;
        return true;
    }

    public bool Sacar(double valor, int numero)
    {
        if (Numero != numero || Saldo < valor)
            return false;

        Saldo -= valor;
        return true;
    }
}