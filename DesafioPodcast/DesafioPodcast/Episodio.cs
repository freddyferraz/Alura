class Episodio
{
    private List<string> convidados = new List<string>();
    public Episodio(int ordem, string titulo, int duracao)
    {
        Titulo = titulo;
        Ordem = ordem;
        Duracao = duracao;
    }

    public string Titulo {get;}
    public int Ordem {get;}
    public int Duracao {get;}
    public string Reusmo => $"{Ordem}. {Titulo} ({Duracao} min) - {string.Join(",",convidados)}";

    public void AdicionarConvidados(string convidado)
    {
        convidados.Add(convidado);
    }
}