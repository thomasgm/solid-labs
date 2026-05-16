using System;

public class Pedido
{
    public string Produto { get; set; }
    public decimal Valor { get; set; }
    public INotificacao Notificacao { get; set; }

    public Pedido(string produto, decimal valor, INotificacao notificacao)
    {
        Produto = produto;
        Valor = valor;
        Notificacao = notificacao;
    }

    public void Confirmar()
    {
        // lógica do pedido
        Console.WriteLine($"Pedido confirmado: {Produto} - R${Valor}");

        Notificacao.Enviar($"Pedido de {Produto} confirmado.");

    }
}