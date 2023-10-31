﻿//  Screen Sound
void exibirMensagemBoasVindas() {
    string mensagemBoasVindas = "Boas vindas ao Sreen Sound";
    //Verbatim Literal
    Console.WriteLine(@"
    
░██████╗░█████╗░██████╗░███████╗███████╗███╗░░██╗
██╔════╝██╔══██╗██╔══██╗██╔════╝██╔════╝████╗░██║
╚█████╗░██║░░╚═╝██████╔╝█████╗░░█████╗░░██╔██╗██║
░╚═══██╗██║░░██╗██╔══██╗██╔══╝░░██╔══╝░░██║╚████║
██████╔╝╚█████╔╝██║░░██║███████╗███████╗██║░╚███║
╚═════╝░░╚════╝░╚═╝░░╚═╝╚══════╝╚══════╝╚═╝░░╚══╝

░██████╗░█████╗░██╗░░░██╗███╗░░██╗██████╗░
██╔════╝██╔══██╗██║░░░██║████╗░██║██╔══██╗
╚█████╗░██║░░██║██║░░░██║██╔██╗██║██║░░██║
░╚═══██╗██║░░██║██║░░░██║██║╚████║██║░░██║
██████╔╝╚█████╔╝╚██████╔╝██║░╚███║██████╔╝
╚═════╝░░╚════╝░░╚═════╝░╚═╝░░╚══╝╚═════╝░
    ");
    Console.WriteLine(mensagemBoasVindas);
}

void exibirOpcoesMenu() {
    Console.WriteLine("\nDigite 1 para registrar uma banda");
    Console.WriteLine("Digite 2 para mostrar todas as bandas");
    Console.WriteLine("Digite 3 para avaliar uma banda");
    Console.WriteLine("Digite 4 para exibir a média de uma banda");
    Console.WriteLine("Digite -1 para sair");

    Console.Write("\nDigite uma opção ");
    int opcaoEscolhida = int.Parse(Console.ReadLine()!);

    switch (opcaoEscolhida) {
        case 1: Console.WriteLine("Você digitou a opção " + opcaoEscolhida);
            break;
        case 2: Console.WriteLine("Você digitou a opção " + opcaoEscolhida);
            break;
        case 3: Console.WriteLine($"Você digitou a opção {opcaoEscolhida}");
            break;
        case 4: Console.WriteLine("Você digitou a opção {0}", opcaoEscolhida);
            break;
        case -1: Console.WriteLine("Tchau Tchau :)");
            break;
        default: Console.WriteLine("Opção inválida!");
            break;
    }
}

exibirMensagemBoasVindas();
exibirOpcoesMenu();
