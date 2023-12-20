Episodio episodio1 = new(1, "Técnicas de Facilitação", 45);
episodio1.AdicionarConvidados("Frederico");
episodio1.AdicionarConvidados("Zoro");

Episodio episodio2 = new(3, "Técnicas de Aprendizado", 67);
episodio2.AdicionarConvidados("Frederico");
episodio2.AdicionarConvidados("Luffy");

Episodio episodio3 = new(2, "Técnicas de Culinária", 106);
episodio3.AdicionarConvidados("Frederico");
episodio3.AdicionarConvidados("Sanji");

Podcast podcast = new("Grand Line", "Nami");
podcast.AdicionarEpisodio(episodio1);
podcast.AdicionarEpisodio(episodio2);
podcast.AdicionarEpisodio(episodio3);
podcast.ExibirDetalhes();