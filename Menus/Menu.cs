using ProjetoMusical.Model;

namespace ProjetoMusical.Menus;

internal abstract class Menu {

    public virtual void Executar(Dictionary<string, Banda> bandas) {
        Console.Clear();
    }

    protected void ExibirTituloOpcao(String titulo) {
        int qtdLetras     = titulo.Length;
        string asteriscos = string.Empty.PadLeft(qtdLetras, char.Parse("*"));
        Console.WriteLine(asteriscos);
        Console.WriteLine(titulo);
        Console.WriteLine(asteriscos + "\n");
    }

}