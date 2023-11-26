namespace ProjetoMusical.Model;

internal class Album : IAvaliavel {

    public Album(string nome) {
        this.Nome = nome;
        Album.qteObjetosAlbum++;
    }
    private List<Musica> musicas = new();
    private List<Avaliacao> notas = new();
    public string Nome { get; }

    public int DuracaoTotal => musicas.Sum(m => m.Duracao);

    public double Media {
        get {
            if(notas.Count == 0) return 0;
            else return notas.Average(a => a.Nota);
        }
    }

    public static int qteObjetosAlbum = 0;

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

    public void AddNota(Avaliacao nota) {
        this.notas.Add(nota);
    }
}