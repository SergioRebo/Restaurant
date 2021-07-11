using Restaurante_InyeccionDependencias.Contrato;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurante_InyeccionDependencias
{
    public class Cocinero
    {
        IPlato plato;
        public Cocinero(IPlato _plato)
        {
            this.plato = _plato;
        }

        public void Cocinar()
        {

        }
    }
}
