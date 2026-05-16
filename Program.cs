Console.WriteLine("Hello, World!");
Pedido pedido = new Pedido("Smartphone", 1500.00m, new WhatsAppNotificacao());
pedido.Confirmar();

Pedido pedidoEmail = new Pedido("PC Gamer", 15000.00m, new EmailNotificacao());
pedidoEmail.Confirmar();