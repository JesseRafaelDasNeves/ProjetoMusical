using ProjetoMusical.Model;

namespace ProjetoMusical.Menus;

internal class MenuRegistrarAlbum : Menu {

    public void Executar(Dictionary<string, Banda> bandas) {
        ExibirTituloOpcao("Registrar Album");
        Console.Write("Digite o nome da banda cuja album queira criar: ");
        string nomeBanda = Console.ReadLine()!;

        if(bandas.ContainsKey(nomeBanda)) {
            Console.Write($"Digite o nome do album para a banda {nomeBanda}: ");
            string nomeAlbum = Console.ReadLine()!;
            bandas[nomeBanda].AdicionaAlbum(new(nomeAlbum));
            Console.WriteLine($"\nO album {nomeAlbum} foi registrada com sucesso para a banda {nomeBanda}");
            Console.WriteLine($"Qtde Obj Album: {Album.qteObjetosAlbum}");
            Thread.Sleep(2000);
        } else {
            Console.WriteLine($"\nA banda {nomeBanda} não foi encontrada!");
            Console.WriteLine("DIgite uma tecla par voltar ao menu principal.");
            Console.ReadKey();
        }
    }
}