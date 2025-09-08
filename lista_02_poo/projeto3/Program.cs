class Program {
    static void Main(string[] args)
    {
        // Criação de objeto
        Personagem p1 = new Personagem("Herói");
        Personagem p2 = new Personagem("Vilão");

        Console.WriteLine("\nPersonagens:\n");

        Console.WriteLine(p1);
        Console.WriteLine(p2);

        // Operações
        Console.WriteLine("\n\nLuta!!!\n");
        while (p1.Vida > 0 && p2.Vida > 0)
        {
            p1.Atacar(p2);
            if (p2.Vida <= 0)
            {
                Console.WriteLine($"{p2.Nome} foi derrotado! {p1.Nome} vence a luta!");
                break;
            }

            p2.Atacar(p1);
            if (p1.Vida <= 0)
            {
                Console.WriteLine($"{p1.Nome} foi derrotado! {p2.Nome} vence a luta!");
                break;
            }
        }
    }
}