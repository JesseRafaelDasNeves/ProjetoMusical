namespace ProjetoMusical.Model;

internal interface IAvaliavel {

    void AddNota(Avaliacao nota);

    double Media {get; }
}