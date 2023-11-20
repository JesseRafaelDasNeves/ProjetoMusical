using ProjetoMusical.Model;

namespace ProjetoMusical.Menus;

internal class MenuExibirDetalhes : Menu {

    public void Executar(Dictionary<string, Banda> bandas){
        ExibirTituloOpcao("Detalhar Banda");
        Console.Write("Digite o nome da banda para pesquisar: ");
        string nomeBanda = Console.ReadLine()!;

        if(bandas.ContainsKey(nomeBanda)) {
            Banda banda = bandas[nomeBanda];
            Console.WriteLine(banda.DescricaoCompleta());
        } else {
            Console.WriteLine($"\nA banda {nomeBanda} não foi encontrada!");
        }
        Console.WriteLine("DIgite uma tecla par voltar ao menu principal.");
        Console.ReadKey();
    }
}