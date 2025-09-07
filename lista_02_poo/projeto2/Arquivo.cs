using System.Dynamic;

public class Arquivo
{
    //Atributos
    public int Id { get; private set; }
    public string Nome { get; private set; }
    public string Conteudo { get; private set; }
    public int Tamanho
    {
        get { return Conteudo.Length * 8; }
    }

    //Construtor
    public Arquivo(int id, string nome, string conteudo)
    {
        Id = id;
        Nome = nome;
        Conteudo = conteudo;
    }

    //Métodos

    public string Abrir()
    {
        string informacoes = $"Nome: {Nome}\nTamanho: {Tamanho} bits\nConteúdo:\n{Conteudo}";
        Console.WriteLine(informacoes);
        return informacoes;
    }

    public bool Editar(string novoConteudo)
    {
        Conteudo += novoConteudo;
        return true;
    }

    public bool Renomear(string novoNome)
    {
        if (string.IsNullOrWhiteSpace(novoNome))
            return false;

        Nome = novoNome;
        return true;
    }

    public bool Limpar()
    {
        Conteudo = "";
        return true;
    }
    
    public override string ToString() {
        return $"Nome: {Nome}\nTamanho: {Tamanho} bits\nConteúdo: {Conteudo}\n";
    }

}
