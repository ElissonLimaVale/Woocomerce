using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ecomerce_Profetional.Models
{
    public class ProdutoViewModel
    {
        public int id { get; set; }
        public string Codigo { get; set; }
        public string Nome { get; set; }
        public float Preco { get; set; }
        public virtual List<ItemPedidoViewModel> ItemPedido { get; set; }
    }
}
