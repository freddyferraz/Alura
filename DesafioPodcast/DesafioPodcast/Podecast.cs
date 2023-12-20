class Podcast
{
    private List<Episodio> episodioList = new();    
    public Podcast(string nome, string host)
    {
        Nome = nome;
        Host = host;
    }

    public string Nome {get;}
    public string Host {get;}
    public int TotalEpisodios => episodioList.Count;

    public void AdicionarEpisodio(Episodio episodio)
    {
        episodioList.Add(episodio);
    }

    public void ExibirDetalhes()
    {
        Console.WriteLine($"Podcast: {Nome}. Apresentado por {Host}\n");
        foreach(Episodio episodio in episodioList.OrderBy(e => e.Ordem))
        {
            Console.WriteLine(episodio.Reusmo);
        }
        Console.WriteLine($"Este Podcast possui {TotalEpisodios} episodios");
    }
}