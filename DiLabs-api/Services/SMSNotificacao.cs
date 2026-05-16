public class SMSNotificacao : INotificacao
{
    public void Enviar(string mensagem)
    {
        // lógica para enviar SMS
        Console.WriteLine($"Enviando SMS: {mensagem}");
    }
}