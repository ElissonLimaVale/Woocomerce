using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WooComerce.Models
{
    public class PedidoViewModel
    {
        public int id { get; set; }
        public int CadastroId { get; set; }
        public CadastroViewModel Cadastro { get; set; }
        public virtual List<ItemPedidoViewModel> ItemPedido { get; set; }
    }
}
