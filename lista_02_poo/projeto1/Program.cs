class Program {
    static void Main(string[] args){
        // Criação de objetos
        ContaBancaria c1 = new ContaBancaria(1, "Natália");
        ContaBancaria c2 = new ContaBancaria(2, "Marcela");

        // Operações
        Console.WriteLine("Original:");

        Console.WriteLine(c1);
        Console.WriteLine(c2);

        Console.WriteLine("Pós depósito:");
        c1.Depositar(350, 1);
        c2.Depositar(349, 2);

        Console.WriteLine(c1);
        Console.WriteLine(c2);

        Console.WriteLine("Pós saque:");
        c1.Sacar(100, 1);
        c2.Sacar(5, 2);

        Console.WriteLine(c1);
        Console.WriteLine(c2);

        // Console.WriteLine("Pós testes adicionais:");

        // c1.Depositar(-50, 1);
        // c2.Titular = "Mar";
        // c2.Id = 4;

        // Console.WriteLine(c1);
        // Console.WriteLine(c2);

        // Resultado: não rodou :)

    }
}