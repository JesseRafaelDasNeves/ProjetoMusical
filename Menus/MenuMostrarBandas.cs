using ProjetoMusical.Model;

namespace ProjetoMusical.Menus;

internal class MenuMostrarBandas : Menu {

    public override void Executar(Dictionary<string, Banda> bandas) {
        base.Executar(bandas);
        Console.Clear();
        ExibirTituloOpcao("Mostrar Bandas Registradas");

        //Removido para usar foreach
        /*for(int i = 0; i < bandas.Count; i++ ) {
            Console.WriteLine($"Banda: {i} - {bandas[i]}");
        }*/

        foreach(string banda in bandas.Keys) {
            Console.WriteLine($"Banda: {banda}");
        }

        if(bandas.Count == 0) {
            Console.WriteLine("Sem Registros");
        }

        Console.WriteLine("_______________________");

        Console.Write("\nDigite uma tecla para voltar ");
        Console.ReadKey();
    }
}