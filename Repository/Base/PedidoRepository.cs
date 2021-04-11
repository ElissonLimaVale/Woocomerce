
using WooComerce.Models;
using System;
using System.Collections.Generic;
using WooComerce.Repository.Interface;
using Microsoft.AspNetCore.Http;
using System.Linq;

namespace WooComerce.Repository
{
    public class PedidoRepository : IBaseRepository<PedidoViewModel>, IPedidoRepository
    {
        private readonly ApplicationContext _entity;
        private readonly IHttpContextAccessor _session;
        public PedidoRepository(ApplicationContext entity, IHttpContextAccessor session)
        {
            _entity = entity;
            _session = session;
        }

        public dynamic Atualizar(PedidoViewModel entidade)
        {
            throw new NotImplementedException();
        }

        public dynamic Cadastrar(PedidoViewModel entidade)
        {
            throw new NotImplementedException();
        }

        public dynamic Deletar(PedidoViewModel entidade)
        {
            throw new NotImplementedException();
        }

        public ICollection<PedidoViewModel> SearchFilter(PedidoViewModel ObjectFilter)
        {
            throw new NotImplementedException();
        }

        public ICollection<PedidoViewModel> SearchFull()
        {
            throw new NotImplementedException();
        }

        public PedidoViewModel SearchOne(int id)
        {
            throw new NotImplementedException();
        }

        private int? gePedidoId()
        {
            int? response = _session.HttpContext.Session.GetInt32("PedidoId");
            return response;
        }

        private void setPedidoId(int PedidoId)
        {
            _session.HttpContext.Session.SetInt32("PedidoId", PedidoId);
        }

        public PedidoViewModel GetPedidoAtual()
        {
            var PedidoId = gePedidoId();
            var response = _entity.Pedido.FirstOrDefault(x => x.id == PedidoId);
            if(response == null)
            {
                response = new PedidoViewModel();
                _entity.Pedido.Add(response);
                _entity.SaveChanges();
                setPedidoId(response.id);
            }

            return response;
        }

        public dynamic AddItem(string codigo)
        {
            dynamic response;
            //var registro = _entity.Produto.FirstOrDefault(x => x.Codigo == codigo);
            //if(registro == null)
            //{
            //    response = new { data = false, message = "Produto não encontrado!", pedido = GetPedidoAtual()};
            //}else
            //{
            //    PedidoViewModel pedido = GetPedidoAtual();
            //    var ItemPedido = _entity.ItemPedido.FirstOrDefault(x => x.Produto.Codigo == registro.Codigo && x.PedidoId == pedido.id);
            //    if (ItemPedido == null)
            //    {
            //        var item = new ItemPedidoViewModel();
            //        item.Pedido = pedido;
            //        item.Produto = registro;
            //        item.Quantidade = 1;
            //        item.PrecoUnitario = registro.Preco;
            //        _entity.ItemPedido.Add(item);
            //    }
            //    else
            //    {
            //        ItemPedido.Quantidade += 1;
            //    }
            //    _entity.SaveChanges();
                response = new { data = true, message = "Produto adicionado!", pedido = _entity.Pedido.FirstOrDefault(x => x.id == null) };

            //}

            return response;
        }
    }
}
