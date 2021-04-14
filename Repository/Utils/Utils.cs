using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WooComerce.Utils
{
    public static class Utils
    {
        public static bool ValidateParams(dynamic parametros)
        {
            bool response = true;
            foreach (var item in parametros)
            {
                if(item == null)
                {
                    response = false;
                }
            }
            return response;
        }

    }
}
