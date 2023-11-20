namespace ProjetoMusical.Model;

internal class Avaliacao {

    public Avaliacao(int nota) {
        if(nota < 0) {
            nota = 0;
        } else if (nota > 10) {
            nota = 10;
        }
        this.Nota = nota;
    }

    public int Nota { get; }

    public static Avaliacao Parse(String texto) {
        return new Avaliacao(int.Parse(texto));
    }
}