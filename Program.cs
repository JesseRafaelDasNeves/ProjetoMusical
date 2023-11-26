//  Screen Sound
//List<string> bandas = new List<string>{"Teste Direto 1", "Teste Direto 2"};
using ProjetoMusical.Menus;
using ProjetoMusical.Model;

Dictionary<string, Banda> bandas = new();
Dictionary<int,Menu> opcoesMenu = new();
Comeca();

void Comeca() {
    CriaBaseInicial();
    CriaOpcoesMenu();
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
    Console.WriteLine("Digite 7 para Avaliar o album de uma banda");
    Console.WriteLine("Digite -1 para sair");

    Console.Write("\nDigite uma opção ");
    int opcaoEscolhida = int.Parse(Console.ReadLine()!);

    if(opcoesMenu.ContainsKey(opcaoEscolhida)) {
        Menu opcaoMenuEscolhido = opcoesMenu[opcaoEscolhida];
        opcaoMenuEscolhido.Executar(bandas);
        if(opcaoEscolhida > 0) {
            ExibirOpcoesMenu();
        }
    } else {
        Console.WriteLine("Opção inválida!");
    }
}

void CriaOpcoesMenu() {
    opcoesMenu.Add(1, new MenuRegistrarBanda());
    opcoesMenu.Add(2, new MenuMostrarBandas());
    opcoesMenu.Add(3, new MenuAvaliarBanda());
    opcoesMenu.Add(4, new MenuExibirMediaBanda());
    opcoesMenu.Add(5, new MenuExibirDetalhes());
    opcoesMenu.Add(6, new MenuRegistrarAlbum());
    opcoesMenu.Add(7, new MenuAvaliarAlbum());
    opcoesMenu.Add(-1, new MenuSair());
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