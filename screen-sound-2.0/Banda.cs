class Banda
{
    public Banda(string nome)
    {
        NomeBanda = nome;
        Console.WriteLine($"A banda '{NomeBanda}' foi criada com sucesso.\n");
    }

    public string NomeBanda { get; }

    List<Album> albums = new List<Album>();

    public void AdicionarAlbum(Album album)
    {
        albums.Add(album);
    }

    public void ExibirDiscografia()
    {
        Console.WriteLine($"\nDiscografia de {NomeBanda}:");
        foreach (var album in albums)
        {
            Console.WriteLine($"- {album.NomeAlbum} | Duração: {album.DuracaoTotalAlbum}");
        }
        Console.WriteLine("");
    }

}


