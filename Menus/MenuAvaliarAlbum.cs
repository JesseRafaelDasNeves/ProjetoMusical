using ProjetoMusical.Model;

namespace ProjetoMusical.Menus;

internal class MenuAvaliarAlbum : Menu {

    public override void Executar(Dictionary<string, Banda> bandas)
    {
        base.Executar(bandas);
        ExibirTituloOpcao("Avaliar Album");
        Console.Write("Digite o nome da banda para avaliar o Album: ");
        string nomeBanda = Console.ReadLine()!;

        if(bandas.ContainsKey(nomeBanda)) {
            Console.Write("Agora digite o nome do album: ");
            string nomeAlbum = Console.ReadLine()!;

            if(bandas[nomeBanda].Albums.Any(a => a.Nome.Equals(nomeAlbum))) {
                Album album = bandas[nomeBanda].Albums.First(a => a.Nome.Equals(nomeAlbum));

                Console.Write($"Digite uma nota para o album {nomeAlbum} da banda {nomeBanda}: ");
                Avaliacao avaliacao = Avaliacao.Parse(Console.ReadLine()!);
                album.AddNota(avaliacao);
                Console.WriteLine($"\nA nota {avaliacao.Nota} foi registrada com sucesso para o album {nomeAlbum}");
                Thread.Sleep(2000);
            } else {
                Console.WriteLine($"\nA album {nomeAlbum} não foi encontrado!");
                Console.WriteLine("DIgite uma tecla par voltar ao menu principal.");
                Console.ReadKey();
            }

        } else {
            Console.WriteLine($"\nA banda {nomeBanda} não foi encontrada!");
            Console.WriteLine("DIgite uma tecla par voltar ao menu principal.");
            Console.ReadKey();
        }
    }
}