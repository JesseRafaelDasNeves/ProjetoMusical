class Album {

    public Album(string nome) {
        this.Nome = nome;
    }
    private List<Musica> musicas = new();
    public string Nome { get; }

    public int DuracaoTotal => musicas.Sum(m => m.Duracao);

    public void AdicionaMusica(Musica musica) {
        musicas.Add(musica);
    }

    public string DescicaoMusicas() {
        string descricao = $"Lista de musicas do album {this.Nome}\n\n";
        foreach(var musica in musicas) {
            descricao += musica.DescricaoFichaTecnica();
            descricao += "\n\n";
        }
        descricao += $"Duração total {this.DuracaoTotal}";
        return descricao;
    }
}