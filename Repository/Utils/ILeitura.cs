using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WooComerce.Repository.Utils
{
    public interface ILeitura<TEntidade>
    {
        ICollection<TEntidade> SearchFull();
        ICollection<TEntidade> SearchFilter(TEntidade ObjectFilter);
        TEntidade SearchOne(int id);
    }
}
