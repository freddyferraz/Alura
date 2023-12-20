Banda rbd = new Banda("RBD");


Album nomeAlbum = new Album("Celestial");

Musica musica1 = new Musica(rbd, "Celestial")
{

    Duracao = 213,
    Disponivel = true,
};

Musica musica2 = new Musica(rbd, "Algun Dia")
{
    Duracao = 315,
    Disponivel = true,
};

Musica musica3 = new Musica(rbd, "No Digas Nada")
{
    Duracao = 313,
    Disponivel = true,
};

nomeAlbum.AdicionarMusica(musica1);
nomeAlbum.AdicionarMusica(musica2);
nomeAlbum.AdicionarMusica(musica3);

rbd.AdicionarAlbum(nomeAlbum);

rbd.ExibirDiscografia();
