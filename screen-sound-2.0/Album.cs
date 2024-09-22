class Album
{
    public Album(string nome)
    {
        NomeAlbum = nome;
        Console.WriteLine($"o Álbum '{NomeAlbum}' foi criado com sucesso.\n");
    }
    public string NomeAlbum { get; }

    List<Musica> musicas = new List<Musica>();

    public int DuracaoTotalAlbum => musicas.Sum(musica => musica.DuracaoMusica);

    public void AdicionarMusica(Musica musica)
    {
        Console.WriteLine($"Música '{musica.NomeMusica}' adicionada ao álbum '{NomeAlbum}' de {musica.NomeArtista}.");
        musicas.Add(musica);
    }

    public void ExibirMusicasDoAlbum()
    {
        Console.WriteLine($"\nExibindo músicas do álbum: {NomeAlbum}");

        foreach (var musica in musicas)
        {
            Console.WriteLine($"- {musica.NomeMusica}");
        }

        Console.WriteLine($"Este álbum tem a duração de {DuracaoTotalAlbum} segundos");
    }

}