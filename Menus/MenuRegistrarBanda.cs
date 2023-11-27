using OpenAI_API;
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
        //newBanda.Resumo = this.GetResumoFromChatGpt(nomeBanda);        

        //Ponto de exclamação para não permitir valores nulos
        Console.WriteLine($"A banda {nomeBanda} foi registrada com sucesso!");
        Thread.Sleep(4000);
    }

    private string GetResumoFromChatGpt(string nomeBanda) {
        var client = new OpenAIAPI("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");
        var chat   = client.Chat.CreateConversation();
        chat.AppendSystemMessage($"Resuma a banda {nomeBanda} em 1 paragrafo. Adote um estilo informal.");
        return chat.GetResponseFromChatbotAsync().GetAwaiter().GetResult(); 
    }
    
}