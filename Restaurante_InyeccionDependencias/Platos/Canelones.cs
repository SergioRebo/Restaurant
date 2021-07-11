using Restaurante_InyeccionDependencias.Contrato;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurante_InyeccionDependencias.Platos
{
    public class Canelones : IPlato
    {
        public string Tipo { get; set; }
        public Canelones(string tipo)
        {
            this.Tipo = tipo;
        }
        public void Cocinar()
        {
            Console.WriteLine("Se hicieron unos canelones de " + Tipo + " como los de la abuela.");
        }
    }
}
