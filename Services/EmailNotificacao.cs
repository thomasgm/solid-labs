public class EmailNotificacao : INotificacao
{
    public void Enviar(string mensagem)
    {
        // lógica para enviar email
        Console.WriteLine($"Enviando email: {mensagem}");
    }
}