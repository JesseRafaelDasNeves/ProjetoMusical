using ProjetoMusical.Model;

namespace ProjetoMusical.Menus;

internal class MenuRegistrarBanda : Menu {

    public override void Executar(Dictionary<string, Banda> bandas) {
        base.Executar(bandas);
        ExibirTituloOpcao("Registro de Bandas");
        Console.Write("Digite o nome da banda que voçê deseja registrar: ");
        string nomeBanda = Console.ReadLine()!;
        Banda newBanda = new(nomeBanda);
        bandas.Add(nomeBanda,newBanda);
        //Ponto de exclamação para não permitir valores nulos
        Console.WriteLine($"A banda {nomeBanda} foi registrada com sucesso!");
        Thread.Sleep(2000);
    }
}