public class EmailNotificacao : INotificacao, INotificacaoComAnexo
{
    public void Enviar(string mensagem)
    {
        // lógica para enviar email
        Console.WriteLine($"Enviando email: {mensagem}");
    }

    public void EnviarComAnexo(string mensagem, string anexo)
    {
        // lógica para enviar email com anexo
        Console.WriteLine($"Enviando email: {mensagem} com anexo: {anexo}");
    }
}