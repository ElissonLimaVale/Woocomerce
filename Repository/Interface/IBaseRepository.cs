using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WooComerce.Repository.Utils;

namespace WooComerce.Repository.Interface
{
    public interface IBaseRepository<TEntidade> : ILeitura<TEntidade>, IGravacao<TEntidade>
    {
        
    }
}
