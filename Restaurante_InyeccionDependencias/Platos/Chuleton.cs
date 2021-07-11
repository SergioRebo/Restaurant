using Restaurante_InyeccionDependencias.Contrato;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurante_InyeccionDependencias.Platos
{
    public class Chuleton : IPlato
    {
        public string Tipo { get; set; }
        public Chuleton(string tipo)
        {
            this.Tipo = tipo;
        }
        public void Cocinar()
        {
            Console.WriteLine("Se cocinó un chuletón de " + Tipo + " que hasta los veganos se lo quieren comer.");
        }
    }
}
