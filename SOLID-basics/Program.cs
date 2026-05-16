Console.WriteLine("Hello, World!");
Pedido pedido = new Pedido("Smartphone", 1500.00m, new WhatsAppNotificacao());
pedido.Confirmar();

Pedido pedidoEmail = new Pedido("PC Gamer", 15000.00m, new EmailNotificacao());
INotificacaoComAnexo notificacaoAnexo = new EmailNotificacao();
notificacaoAnexo.EnviarComAnexo("Pedido de PC Gamer confirmado.", "nota_fiscal.pdf"); // Enviando email: Pedido de PC Gamer confirmado. com anexo: nota_fiscal.pdf após a confirmação do pedido e pagamento
pedidoEmail.Confirmar();


Pedido pedidoSMS = new Pedido("Notebook Gamer", 25000.00m, new SMSNotificacao());
pedidoSMS.Confirmar();
