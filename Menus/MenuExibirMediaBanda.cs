using ProjetoMusical.Model;

namespace ProjetoMusical.Menus;

internal class MenuExibirMediaBanda : Menu {

    public override void Executar(Dictionary<string, Banda> bandas) {
        base.Executar(bandas);
        ExibirTituloOpcao("Media de Banda");
        Console.WriteLine("Digite o nome da banda que deseja saber a média de nota: ");
        string nomeBanda = Console.ReadLine()!;

        if(bandas.ContainsKey(nomeBanda)) {
            double mediaNotas = bandas[nomeBanda].Media;
            Console.WriteLine($"\nA média de nota da banda {nomeBanda} é {mediaNotas}.");
            Thread.Sleep(2000);
        } else {
            Console.WriteLine($"\nBanda {nomeBanda} não encontrada");
            Console.WriteLine("Digite uma tecla para voltar ao menu principal");
            Console.ReadKey();
        }
    }
}