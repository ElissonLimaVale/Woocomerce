
using WooComerce.Models;
using System;
using System.Collections.Generic;
using WooComerce.Repository.Interface;
using Microsoft.AspNetCore.Http;
using System.Linq;
using Microsoft.EntityFrameworkCore;

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
            dynamic response = new { data = true, message = "Atualizado com sucesso!" };
            try
            {
                _entity.Entry(entidade).State = EntityState.Modified;
                _entity.SaveChanges();
            }
            catch (Exception ex)
            {
                response = new { data = false, message = ex.Message };
            }
            return response;
        }

        public dynamic Cadastrar(PedidoViewModel entidade)
        {
            dynamic response = new { data = true, message = "Cadastrado com sucesso!" };
            try
            {
                _entity.Pedido.Add(entidade);
                _entity.SaveChanges();
            }
            catch (Exception ex)
            {
                response = new { data = false, message = ex.Message };
            }
            return response;
        }

        public dynamic Deletar(PedidoViewModel entidade)
        {
            dynamic response = new { data = true, message = "Deletado com sucesso!" };
            try
            {
                _entity.Pedido.Remove(entidade);
                _entity.SaveChanges();
            }
            catch (Exception ex)
            {
                response = new { data = false, message = ex.Message };
            }
            return response;
        }

        public ICollection<PedidoViewModel> SearchFilter(PedidoViewModel ObjectFilter)
        {
            var response = _entity.Pedido.Where(
                x => x.CadastroId == ObjectFilter.CadastroId &&
                x.id == ObjectFilter.id 
            ).ToList();
            if (response == null) {
                response = new List<PedidoViewModel>();
            }
            return response;
        }

        public ICollection<PedidoViewModel> SearchFull()
        {
            return _entity.Pedido.ToList();
        }

        public PedidoViewModel SearchOne(int id)
        {
            return _entity.Pedido.FirstOrDefault(x => x.id == id);
        }


        public PedidoViewModel GetPedidoAtual()
        {
            var PedidoId = gePedidoId();
            var response = _entity.Pedido
                .Include(x => x.ItemPedido)
                .ThenInclude(x => x.Produto)
                .Where(x => x.id == PedidoId)
                .SingleOrDefault();

            if(response == null)
            {
                response = new PedidoViewModel();
                _entity.Pedido.Add(response);
                _entity.SaveChanges();
                setPedidoId(response.id);
            }
            return response;
        }

        private void setPedidoId(int id)
        {
            _session.HttpContext.Session.SetInt32("PedidoId", id);
        }

        private int? gePedidoId()
        {
            return _session.HttpContext.Session.GetInt32("PedidoId");
        }

        public dynamic AddItem(string codigo)
        {
            dynamic response;
            var registro = _entity.Produto.FirstOrDefault(x => x.Codigo == codigo);
            if (registro == null)
            {
                response = new { data = false, message = "Produto não encontrado!", pedido = GetPedidoAtual() };
            }
            else
            {
                PedidoViewModel pedido = GetPedidoAtual();

                var item = new ItemPedidoViewModel();
                item.PedidoId = gePedidoId();
                item.Pedido = pedido;
                item.Produto = registro;
                item.Quantidade = 1;
                item.PrecoUnitario = registro.Preco;
                pedido.ItemPedido.Add(item);
                _entity.Entry(pedido).State = EntityState.Modified;
                _entity.SaveChanges();
                response = new { data = true, message = "Produto adicionado!", pedido = pedido };
            }
            return response;
        }
    }
}
