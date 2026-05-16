using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("[controller]")]
public class PedidoController : ControllerBase
{
    private readonly INotificacao _notificacao;
    public PedidoController(INotificacao notificacao)
    {
        _notificacao = notificacao;
    }
    [HttpPost]
    public IActionResult CriarPedido(PedidoRequest request  )
    {
        // Lógica para criar o pedido (salvar no banco de dados, etc.)
        // ...
        var pedido = new Pedido(request.Produto, request.Valor, _notificacao);
        pedido.Confirmar();
        return Ok(pedido);
    }
}