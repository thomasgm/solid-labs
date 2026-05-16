public class WhatsAppNotificacao : INotificacao, INotificacaoComAnexo
{
    public void Enviar(string mensagem)
    {
        // lógica para enviar mensagem via WhatsApp
        Console.WriteLine($"Enviando mensagem via WhatsApp: {mensagem}");

        //grava log de arquivo só para whatsapp
        Console.WriteLine("Gravando log de arquivo para WhatsApp...");

        using (StreamWriter sw = new StreamWriter("log_whatsapp.txt", true))
        {
            sw.WriteLine($"{DateTime.Now}: {mensagem}");
        }
    }

    public void EnviarComAnexo(string mensagem, string anexo)
    {
        // lógica para enviar mensagem com anexo via WhatsApp
        Console.WriteLine($"Enviando mensagem via WhatsApp: {mensagem} com anexo: {anexo}");
        //grava log de arquivo só para whatsapp
        Console.WriteLine("Gravando log de arquivo para WhatsApp...");
        using (StreamWriter sw = new StreamWriter("log_whatsapp.txt", true))
        {
            sw.WriteLine($"{DateTime.Now}: {mensagem} com anexo: {anexo}");
        }
    }
}