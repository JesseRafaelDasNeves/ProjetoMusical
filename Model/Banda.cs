using System.Dynamic;

namespace ProjetoMusical.Model;

internal class Banda : IAvaliavel {

    private readonly List<Album> albums = new();
    public IEnumerable<Album> Albums => albums;
    private List<Avaliacao> notas = new();
    public double Media {
        get {
            if(notas.Count == 0) return 0;
            else return notas.Average(a => a.Nota);
        }
    }

    public Banda(string nome) {
        this.Nome = nome;
    }
    public string Nome { get;}

    public void AdicionaAlbum(Album album) {
        this.albums.Add(album);
    }

    public void AddNota(Avaliacao nota) {
        this.notas.Add(nota);
    }

    public string DescricaoDiscografia() {
        string descricao = $"Discografia da banda {this.Nome}";
        foreach(Album album in this.Albums) {
            descricao += $"\nAlbum: {album.Nome}, (Duração Total: {album.DuracaoTotal}), (Média: {album.Media})";
        }
        return descricao;
    }

    public string DescricaoNotas() {
        string descricao = $"Notas da banda {this.Nome}";
        int i = 1;

        foreach(Avaliacao aval in this.notas) {
            descricao += $"\nNota {i}: {aval.Nota}";
            i++;
        }
        return descricao;
    }

    public string DescricaoCompleta() {
        string descricao = $"===BANDA {this.Nome}===";
        descricao += "\n" + DescricaoDiscografia();
        descricao += "\n";
        descricao += "\n" + DescricaoNotas();
        descricao += "\n--------------------------------";
        return descricao;
    }
}