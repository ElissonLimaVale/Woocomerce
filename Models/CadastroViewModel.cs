using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WooComerce.Models
{
    public class CadastroViewModel
    {
        public int id { get; set; }
        public string Bairro { get; set; }
        public string CEP { get; set; }
        public string Complemento { get; set; }
        public string Email { get; set; }
        public string Endereco { get; set; }
        public string Municipio { get; set; }
        public string Nome { get; set; }
        public string Telefone { get; set; }
        public string UF { get; set; }
        public PedidoViewModel Pedido { get; set; }
    }
}
