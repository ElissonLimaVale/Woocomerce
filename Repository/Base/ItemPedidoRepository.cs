
using WooComerce.Models;
using System;
using System.Collections.Generic;
using WooComerce.Repository.Interface;

namespace WooComerce.Repository
{
    public class ItemPedidoRepository : IBaseRepository<ItemPedidoViewModel>
    {
        private readonly ApplicationContext _entity;
        public ItemPedidoRepository(ApplicationContext entity)
        {
            _entity = entity;
        }

        public dynamic Atualizar(ItemPedidoViewModel entidade)
        {
            throw new NotImplementedException();
        }

        public dynamic Cadastrar(ItemPedidoViewModel entidade)
        {
            throw new NotImplementedException();
        }

        public dynamic Deletar(ItemPedidoViewModel entidade)
        {
            throw new NotImplementedException();
        }

        public ICollection<ItemPedidoViewModel> SearchFilter(ItemPedidoViewModel ObjectFilter)
        {
            throw new NotImplementedException();
        }

        public ICollection<ItemPedidoViewModel> SearchFull()
        {
            throw new NotImplementedException();
        }

        public ItemPedidoViewModel SearchOne(int id)
        {
            throw new NotImplementedException();
        }
    }
}
