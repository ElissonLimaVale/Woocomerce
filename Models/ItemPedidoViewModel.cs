using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WooComerce.Models
{
    public class ItemPedidoViewModel
    {
        public int id { get; set; }
        public int PedidoId { get; set; }
        public float PrecoUnitario { get; set; }
        public int ProdutoId { get; set; }
        public int Quantidade { get; set; }
        public PedidoViewModel Pedido { get; set; }
        public ProdutoViewModel Produto { get; set; }
    }
}
