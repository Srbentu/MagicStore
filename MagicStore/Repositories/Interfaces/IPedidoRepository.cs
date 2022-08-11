using MagicStore.Models;

namespace MagicStore.Repositories.Interfaces;

public interface IPedidoRepository
{
    void CriarPedido(Pedido pedido);
}