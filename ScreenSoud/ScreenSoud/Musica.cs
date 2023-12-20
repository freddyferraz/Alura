class Musica
{
  

    public string Nome {  get; }
    public Banda Artista { get; }

    public Musica(Banda artista, string nome)
    {
        Artista = artista;
        Nome = nome;
    }

    public int Duracao { get; set; }
    public bool Disponivel { get; set; }
    public Genero Genero { get; set; }

    public string DescricaoResumida {
        get
        {
            return $"A música {Nome} pertence a banda {Artista}";
        } 
    }

    public void ExibirFichaTecnica()
    {
        Console.WriteLine($"Nome:{Nome}");
        Console.WriteLine($"Artista: {Artista}");
        Console.WriteLine($"Duração: {Duracao}");
        if ( Disponivel ==  true)
        {
            Console.WriteLine("Disponível no plano");
        }
        else
        {
            Console.WriteLine("Disponível no plano Plus");
        }
    }

    public void ExibirResumo()
    {
        Console.WriteLine($"A música {Nome} pertence ao artista {Artista}");
    }

  
}
