using System;
using System.IO;

public class Pedido
{
    public string Produto { get; set; }
    public decimal Valor { get; set; }

    public void Confirmar()
    {
        // lógica do pedido
        Console.WriteLine($"Pedido confirmado: {Produto} - R${Valor}");

        //enviando email
        Console.WriteLine("Enviando email de confirmação...");

        if (Valor > 100)
        {
            //enviando whatsapp
            Console.WriteLine("Enviando mensagem de confirmação via WhatsApp...");
            
            //grava log de arquivo só para whatsapp
            Console.WriteLine("Gravando log de arquivo para WhatsApp...");
            
            using (StreamWriter sw = new StreamWriter("log_whatsapp.txt", true))
            {
                sw.WriteLine($"{DateTime.Now}: Pedido de {Produto} confirmado via WhatsApp.");
            }
        }
    }
}