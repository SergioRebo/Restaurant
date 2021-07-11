using Restaurante_InyeccionDependencias.Contrato;
using Restaurante_InyeccionDependencias.Platos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurante_InyeccionDependencias
{
    class Program
    {
        static void Main(string[] args)
        {
            IPlato plato = new Canelones("carne");
            plato.Cocinar();
        }
    }
}
