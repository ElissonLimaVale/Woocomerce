using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WooComerce.Repository.Utils
{
    public interface IGravacao<TEntidade>
    {

        dynamic Cadastrar(TEntidade entidade);
        dynamic Atualizar(TEntidade entidade);
        dynamic Deletar(TEntidade entidade);
    }
}
