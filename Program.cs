//  Screen Sound

//List<string> bandas = new List<string>{"Teste Direto 1", "Teste Direto 2"};
using ScreenSound.Model;

Banda ira = new("Ira");
Banda beatles = new("The Beatles");

Dictionary<string, List<int>> bandas = new Dictionary<string, List<int>>();
carregaBaseInicial();

void exibirLogo() {
    string mensagemBoasVindas = "Boas vindas ao Sreen Sound!";
    //Verbatim Literal
    Console.WriteLine(@"
█▀ █▀▀ █▀█ █▀▀ █▀▀ █▄░█   █▀ █▀█ █░█ █▄░█ █▀▄
▄█ █▄▄ █▀▄ ██▄ ██▄ █░▀█   ▄█ █▄█ █▄█ █░▀█ █▄▀
    ");
    Console.WriteLine(mensagemBoasVindas);
}

void exibirOpcoesMenu() {
    Console.Clear();
    exibirLogo();
    Console.WriteLine("\nDigite 1 para registrar uma banda");
    Console.WriteLine("Digite 2 para mostrar todas as bandas");
    Console.WriteLine("Digite 3 para avaliar uma banda");
    Console.WriteLine("Digite 4 para exibir a média de uma banda");
    Console.WriteLine("Digite -1 para sair");

    Console.Write("\nDigite uma opção ");
    int opcaoEscolhida = int.Parse(Console.ReadLine()!);

    switch (opcaoEscolhida) {
        case 1: 
            registrarBanda();
            break;
        case 2: 
            mostrarBandas();
            break;
        case 3: 
            avaliarBanda();
            break;
        case 4: 
            exibirMediaBanda();
            break;
        case -1: 
            Console.WriteLine("Tchau Tchau :)");
            break;
        default: 
            Console.WriteLine("Opção inválida!");
            break;
    }
}

void registrarBanda() {
    Console.Clear();
    exibirTituloOpcao("Registro de Bandas");
    Console.Write("Digite o nome da banda que voçê deseja registrar: ");
    string nomeBanda = Console.ReadLine()!;
    bandas.Add(nomeBanda,new List<int>());
    //Ponto de exclamação para não permitir valores nulos
    Console.WriteLine($"A banda {nomeBanda} foi registrada com sucesso!");
    Thread.Sleep(2000);
    exibirOpcoesMenu();
}

void mostrarBandas() {
    Console.Clear();
    exibirTituloOpcao("Mostrar Bandas Registradas");

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
    exibirOpcoesMenu();
}

void carregaBaseInicial() {
    bandas.Add("Banda 1", new List<int>{6,5,7,3});
    bandas.Add("Banda 2", new List<int>{6,1,7});
    bandas.Add("Banda 3", new List<int>{1,3});
    bandas.Add("Banda 4", new List<int>{6,7,9,10});
    bandas.Add("Banda 5", new List<int>{1,3});
    bandas.Add("Banda 6", new List<int>{1,3});
    bandas.Add("Banda 7", new List<int>{1,3});
    bandas.Add("Banda 8", new List<int>{1,3});
    bandas.Add("Banda 9", new List<int>{1,3});
    bandas.Add("Banda 10", new List<int>{1,3});
    bandas.Add("Banda 11", new List<int>{1,3});
    bandas.Add("Banda 12", new List<int>{1,3});
    bandas.Add("Banda 13", new List<int>{1,3});
    bandas.Add("Banda 14", new List<int>{1,3});
    bandas.Add("Banda 15", new List<int>{1,3});
    bandas.Add("Banda 16", new List<int>{1,3});
}

void exibirTituloOpcao(String titulo) {
    Console.Clear();
    int qtdLetras     = titulo.Length;
    string asteriscos = string.Empty.PadLeft(qtdLetras, char.Parse("*"));
    Console.WriteLine(asteriscos);
    Console.WriteLine(titulo);
    Console.WriteLine(asteriscos + "\n");
}

void avaliarBanda() {
    exibirTituloOpcao("Avaliar Banda");
    Console.Write("Digite o nome da banda para avaliar: ");
    string nomeBanda = Console.ReadLine()!;

    if(bandas.ContainsKey(nomeBanda)) {
        Console.Write($"Digite uma nota para a banda {nomeBanda}: ");
        int notaBanda = int.Parse(Console.ReadLine()!);
        bandas[nomeBanda].Add(notaBanda);
        Console.WriteLine($"\nA nota {notaBanda} foi registrada com sucesso para a banda {nomeBanda}");
        Thread.Sleep(2000);
    } else {
        Console.WriteLine($"\nA banda {nomeBanda} não foi encontrada!");
        Console.WriteLine("DIgite uma tecla par voltar ao menu principal.");
        Console.ReadKey();
    }
    exibirOpcoesMenu();
}

void exibirMediaBanda() {
    exibirTituloOpcao("Media de Banda");
    Console.WriteLine("Digite o nome da banda que deseja saber a média de nota: ");
    string nomeBanda = Console.ReadLine()!;

    if(bandas.ContainsKey(nomeBanda)) {
        double mediaNotas = bandas[nomeBanda].Average();
        Console.WriteLine($"\nA média de nota da banda {nomeBanda} é {mediaNotas}.");
        Thread.Sleep(2000);
    } else {
        Console.WriteLine($"\nBanda {nomeBanda} não encontrada");
        Console.WriteLine("Digite uma tecla para voltar ao menu principal");
        Console.ReadKey();
    }
    exibirOpcoesMenu();
}

exibirOpcoesMenu();

Banda banda = new("teste");