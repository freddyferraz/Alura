class Album
{
    private List<Musica> musicas = new List<Musica>();

    public Album(string nome)
    {
        Nome = nome;
    }

    public string Nome { get; }


    public int DuracaoTotal => musicas.Sum(m => m.Duracao);
    public void AdicionarMusica(Musica musica)
    {
        musicas.Add(musica);
    }

    public void ExibirMusicasAlbum()
    {
        Console.WriteLine($"Lista de Músicas do álbum {Nome}");
        foreach (var musica in musicas)
        {
            Console.WriteLine($"Música: {musica.Nome}");
            
        }
        Console.WriteLine($"Para ouvir este album inteiro você irá precisar de {DuracaoTotal} segundos \n");
    }
}