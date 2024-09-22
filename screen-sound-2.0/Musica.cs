class Musica
{
    public Musica(Banda artista, string nome, int duracao)
    {
        NomeMusica = nome;
        NomeArtista = artista.NomeBanda;
        DuracaoMusica = duracao;
    }

    public string NomeMusica { get; }

    public string NomeArtista { get; }
    public int DuracaoMusica { get; }
    public bool Disponivel { get; set; }
    public string DescricaoResumida => $"A música {NomeMusica} pertence a {NomeArtista}.";

    public void ExibirFicaTecnica()
    {
        Console.WriteLine($"Descrição: {DescricaoResumida}");
        Console.WriteLine($"Duração: {DuracaoMusica}.");

        if (Disponivel)
        {
            Console.WriteLine($"Disponível no plano.\n");
        }
        else
        {
            Console.WriteLine($"Música indisponível, adquira o plano Screen+.\n");
        }

    }
}
