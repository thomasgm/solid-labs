public class WhatsAppNotificacao : INotificacao
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
}