using ProjetoMusical.Model;

namespace ProjetoMusical.Menus;

internal class MenuAvaliarBanda : Menu {

    public override void Executar(Dictionary<string, Banda> bandas) {
        base.Executar(bandas);
        ExibirTituloOpcao("Avaliar Banda");
        Console.Write("Digite o nome da banda para avaliar: ");
        string nomeBanda = Console.ReadLine()!;

        if(bandas.ContainsKey(nomeBanda)) {
            Console.Write($"Digite uma nota para a banda {nomeBanda}: ");
            Avaliacao avaliacao = Avaliacao.Parse(Console.ReadLine()!);
            bandas[nomeBanda].AddNota(avaliacao);
            Console.WriteLine($"\nA nota {avaliacao.Nota} foi registrada com sucesso para a banda {nomeBanda}");
            Thread.Sleep(2000);
        } else {
            Console.WriteLine($"\nA banda {nomeBanda} não foi encontrada!");
            Console.WriteLine("DIgite uma tecla par voltar ao menu principal.");
            Console.ReadKey();
        }
    }
}