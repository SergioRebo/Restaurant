using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Restaurante_InyeccionDependencias.Contrato;

namespace Restaurante_InyeccionDependencias.Platos
{
    public class Macarrones : IPlato
    {
        public string Tipo { get; set; }
        public Macarrones(string tipo)
        {
            this.Tipo = tipo;
        }
        public void Cocinar()
        {
            Console.WriteLine("Se hicieron unos macarrones " + Tipo);
        }
    }
}
