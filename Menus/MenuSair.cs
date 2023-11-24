using ProjetoMusical.Model;

namespace ProjetoMusical.Menus;

internal class MenuSair : Menu {

    public override void Executar(Dictionary<string, Banda> bandas) {
        Console.WriteLine("Tchau Tchau :)");
    }
}