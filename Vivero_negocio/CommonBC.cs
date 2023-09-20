using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vivero_negocio
{
    internal class CommonBC
    {
        private static Vivero_DALC.El_SaltoEntities _modeloVivero;

        public static Vivero_DALC.El_SaltoEntities ModeloVivero
        {
            get
            {
                if(_modeloVivero == null)
                {
                    _modeloVivero = new Vivero_DALC.El_SaltoEntities();
                }
                return _modeloVivero;
            }
        }

        public CommonBC()
        {

        }
    }
}
