using Microsoft.AspNetCore.Mvc;
using WooComerce.Models;
using WooComerce.Repository;
using WooComerce.Repository.Interface;

namespace WooComerce.Controllers
{
    public class PedidosController : Controller
    {
        private readonly IBaseRepository<PedidoViewModel> _pedido;
        private readonly IPedidoRepository _aditionalPedido;
        private readonly IBaseRepository<ProdutoViewModel> _produto;
        private readonly IBaseRepository<ItemPedidoViewModel> _item;
        private readonly IBaseRepository<CadastroViewModel> _cadastro;
        
        public PedidosController(
                IBaseRepository<PedidoViewModel> pedido,
                IPedidoRepository aditionalPedido,
                IBaseRepository<ProdutoViewModel> produto,
                IBaseRepository<ItemPedidoViewModel> item,
                IBaseRepository<CadastroViewModel> cadastro
            )
        {
            _pedido = pedido;
            _aditionalPedido = aditionalPedido;
            _produto = produto;
            _item = item;
            _cadastro = cadastro;
        }
        public IActionResult Cadastro()
        {
            return View();
        }
        [HttpGet]
        public IActionResult Carrinho(string codigo)
        {
            var response = new PedidoViewModel();
            if (!string.IsNullOrEmpty(codigo))
            {
                dynamic result = _aditionalPedido.AddItem(codigo);
                if (result.GetType().GetProperty("data").GetValue(result, null))
                {
                    response = result.GetType().GetProperty("pedido").GetValue(result, null)  as PedidoViewModel;
                }
            }else
            {
                response = _aditionalPedido.GetPedidoAtual();
            }
            return View(response);
        }
        public IActionResult Carrossel()
        {
            var Produtos = _produto.SearchFull();
            return View(Produtos);
        }
        public IActionResult Resumo()
        {
            return View();
        }

    }
}
