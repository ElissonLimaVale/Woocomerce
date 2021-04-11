
using System;
using System.Collections.Generic;
using WooComerce.Models;
using WooComerce.Repository.Interface;

namespace WooComerce.Repository
{
    public class Cadastro : IBaseRepository<CadastroViewModel>
    {
        private readonly ApplicationContext _entity;
        public Cadastro(ApplicationContext entity)
        {
            _entity = entity;
        }

        public dynamic Atualizar(CadastroViewModel entidade)
        {
            throw new NotImplementedException();
        }

        public dynamic Cadastrar(CadastroViewModel entidade)
        {
            throw new NotImplementedException();
        }

        public dynamic Deletar(CadastroViewModel entidade)
        {
            throw new NotImplementedException();
        }

        public ICollection<CadastroViewModel> SearchFilter(CadastroViewModel ObjectFilter)
        {
            throw new NotImplementedException();
        }

        public ICollection<CadastroViewModel> SearchFull()
        {
            throw new NotImplementedException();
        }

        public CadastroViewModel SearchOne(int id)
        {
            throw new NotImplementedException();
        }
    }
}
