class Banda {

    public Banda(string nome) {
        this.Nome = nome;
    }
    public List<Album> Albums = new();
    public string Nome { get;}

    public void AdicionaAlbum(Album album) {
        Albums.Add(album);
    }

    public string DescricaoDiscografia() {
        string descricao = $"Discografia da banda {this.Nome}";
        foreach(Album album in this.Albums) {
            descricao += $"Album: {album.Nome} ({album.DuracaoTotal})";
        }
        return descricao;
    }
}