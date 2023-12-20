class Banda
{
    public string Nome { get;}
    private List<Album> albums = new List<Album>();

    public Banda(string nome)
    {
        Nome = nome;
    }
    public void AdicionarAlbum(Album album)
    {
        albums.Add(album);
    }

    public void ExibirDiscografia()
    {
        Console.WriteLine($"Discografia da Banda {Nome}");
        foreach(Album album in albums)
        {
            Console.WriteLine($"Album: {album.Nome}");

            album.ExibirMusicasAlbum();
        }
    }
}