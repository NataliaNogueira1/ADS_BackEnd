class Program {
    static void Main(string[] args)
    {
        // Criação de objeto
        Arquivo arquivo1 = new Arquivo(1, "arquivo.txt", "");

        Console.WriteLine("\nOriginal:\n");

        Console.WriteLine(arquivo1);

        // Operações
        Console.WriteLine("Abrir:\n");
        arquivo1.Abrir();

        Console.WriteLine("\nEditar:\n");
        arquivo1.Editar("\nTeste de conteúdo 1.");
        Console.WriteLine(arquivo1);
        arquivo1.Editar("\nTeste de conteúdo 2!");
        Console.WriteLine(arquivo1);

        Console.WriteLine("\nRenomear:\n");
        arquivo1.Renomear("file.txt");
        Console.WriteLine(arquivo1);

        Console.WriteLine("Limpar:\n");
        arquivo1.Limpar();
        Console.WriteLine(arquivo1);

    }
}