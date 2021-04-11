using WooComerce.Models;
using WooComerce.Repository.Utils;

namespace WooComerce.Repository
{
    public interface IPedidoRepository
    {
        PedidoViewModel GetPedidoAtual();
        dynamic AddItem(string codigo);
    }
}