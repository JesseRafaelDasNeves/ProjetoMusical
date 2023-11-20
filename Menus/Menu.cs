namespace ProjetoMusical.Menus;

internal abstract class Menu {

    protected void ExibirTituloOpcao(String titulo) {
        Console.Clear();
        int qtdLetras     = titulo.Length;
        string asteriscos = string.Empty.PadLeft(qtdLetras, char.Parse("*"));
        Console.WriteLine(asteriscos);
        Console.WriteLine(titulo);
        Console.WriteLine(asteriscos + "\n");
    }

}