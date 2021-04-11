
using WooComerce.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using WooComerce.Repository.Interface;

namespace WooComerce.Repository
{
    public class ProdutoRepository : IBaseRepository<ProdutoViewModel>
    {
        private readonly ApplicationContext _entity;
        public ProdutoRepository(ApplicationContext entity)
        {
            _entity = entity;
        }

        public dynamic Atualizar(ProdutoViewModel entidade)
        {
            throw new NotImplementedException();
        }

        public dynamic Cadastrar(ProdutoViewModel entidade)
        {
            throw new NotImplementedException();
        }

        public dynamic Deletar(ProdutoViewModel entidade)
        {
            throw new NotImplementedException();
        }

        public ICollection<ProdutoViewModel> SearchFilter(ProdutoViewModel ObjectFilter)
        {
            throw new NotImplementedException();
        }

        public ICollection<ProdutoViewModel> SearchFull()
        {
            return _entity.Produto.ToList();
        }

        public ProdutoViewModel SearchOne(int id)
        {
            throw new NotImplementedException();
        }
    }
}
