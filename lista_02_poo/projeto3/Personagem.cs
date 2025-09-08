using System.Dynamic;

public class Personagem
{
    //Atributos
    public int Id { get; private set; }
    public string Nome { get; private set; }
    public int Vida { get; set; }

    private static readonly Random random = new Random();

    //Construtor
    public Personagem(string nome)
    {
        Nome = nome;
        Vida = 100;
    }

    //Método

    public void Atacar(Personagem adversario)
    {
        int ataque = random.Next(20, 31);
        int defesaAdversario = random.Next(10, 16);

        if (Vida <= 0 || adversario.Vida <= 0)
        {
            return;
        }

        int dano = ataque - defesaAdversario;
        if (dano < 0){
            dano = 0;
        }
        adversario.Vida -= dano;

        Console.WriteLine($"{Nome} atacou {adversario.Nome}!\nAtaque de {Nome}: {ataque}\nDefesa de {adversario.Nome}: {defesaAdversario}\nDano causado: {dano}\nVida restante: {adversario.Vida}\n");
    }
    
    public override string ToString() {
        return $"Nome: {Nome}, Vida: {Vida}";
    }

}
