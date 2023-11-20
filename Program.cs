//  Screen Sound
//List<string> bandas = new List<string>{"Teste Direto 1", "Teste Direto 2"};
using ProjetoMusical.Menus;
using ProjetoMusical.Model;

Dictionary<string, Banda> bandas = new();
Comeca();

void Comeca() {
    CriaBaseInicial();
    ExibirOpcoesMenu();
}

void ExibirLogo() {
    string mensagemBoasVindas = "Boas vindas ao Sreen Sound!";
    //Verbatim Literal
    Console.WriteLine(@"
█▀ █▀▀ █▀█ █▀▀ █▀▀ █▄░█   █▀ █▀█ █░█ █▄░█ █▀▄
▄█ █▄▄ █▀▄ ██▄ ██▄ █░▀█   ▄█ █▄█ █▄█ █░▀█ █▄▀
    ");
    Console.WriteLine(mensagemBoasVindas);
}

void ExibirOpcoesMenu() {
    Console.Clear();
    ExibirLogo();
    Console.WriteLine("\nDigite 1 para registrar uma banda");
    Console.WriteLine("Digite 2 para mostrar todas as bandas");
    Console.WriteLine("Digite 3 para avaliar uma banda");
    Console.WriteLine("Digite 4 para exibir a média de uma banda");
    Console.WriteLine("Digite 5 para exibir detalhas de uma banda");
    Console.WriteLine("Digite 6 para registrar o album de uma banda");
    Console.WriteLine("Digite -1 para sair");

    Console.Write("\nDigite uma opção ");
    int opcaoEscolhida = int.Parse(Console.ReadLine()!);

    switch (opcaoEscolhida) {
        case 1: 
            MenuRegistrarBanda menuRegBanda = new();
            menuRegBanda.Executar(bandas);
            ExibirOpcoesMenu();
            break;
        case 2: 
            MenuMostrarBandas menuBandas = new();
            menuBandas.Executar(bandas);
            ExibirOpcoesMenu();
            break;
        case 3: 
            MenuAvaliarBanda menuAvaliar = new();
            menuAvaliar.Executar(bandas);
            ExibirOpcoesMenu();
            break;
        case 4: 
            MenuExibirMediaBanda menuExibirMedia = new();
            menuExibirMedia.Executar(bandas);
            ExibirOpcoesMenu();
            break;
        case 5: 
            MenuExibirDetalhes menuDetalhes = new();
            menuDetalhes.Executar(bandas);
            ExibirOpcoesMenu();
            break;
        case 6: 
            MenuRegistrarAlbum menuRegAlbum = new();
            menuRegAlbum.Executar(bandas);
            ExibirOpcoesMenu();
            break;
        case -1: 
            Console.WriteLine("Tchau Tchau :)");
            break;
        default: 
            Console.WriteLine("Opção inválida!");
            ExibirOpcoesMenu();
            break;
    }
}

void CriaBaseInicial() {
    Banda ira = new("Ira");
    ira.AddNota(new Avaliacao(11));
    ira.AddNota(new Avaliacao(8));
    ira.AddNota(new Avaliacao(6));
    ira.AdicionaAlbum(new Album("7"));
    bandas.Add(ira.Nome, ira);

    Banda beatles = new("The Beatles");

    bandas.Add(beatles.Nome, beatles);
}