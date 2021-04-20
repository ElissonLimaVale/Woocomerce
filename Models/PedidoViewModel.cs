using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WooComerce.Models
{
    public class PedidoViewModel
    {
        public PedidoViewModel()
        {
            this.Cadastro = new CadastroViewModel();
            this.ItemPedido = new List<ItemPedidoViewModel>();
        }
        public int id { get; set; }
        public int CadastroId { get; set; }
        public CadastroViewModel Cadastro { get; set; }
        public List<ItemPedidoViewModel> ItemPedido { get; set; }


    }
}
