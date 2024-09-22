Banda vietna = new Banda("Vietnã");

Album album1 = new Album("Até Aqui...");
Album album2 = new Album("A Cena Tá Preta");

Musica musica1 = new Musica(vietna, "Vivendo se aprende", 279)
{
    Disponivel = true,
};

Musica musica2 = new Musica(vietna, "Não Fode", 290)
{
    Disponivel = false,
};



Musica musica3 = new Musica(vietna, "Capítulo da Guerra", 312)
{
    Disponivel = true,
};

Musica musica4 = new Musica(vietna, "Sobre Viver", 249)
{
    Disponivel = true,
};

vietna.AdicionarAlbum(album1);
vietna.AdicionarAlbum(album2);

album1.AdicionarMusica(musica1);
album1.AdicionarMusica(musica2);

album2.AdicionarMusica(musica3);
album2.AdicionarMusica(musica4);

album1.ExibirMusicasDoAlbum();
album2.ExibirMusicasDoAlbum();


vietna.ExibirDiscografia();
