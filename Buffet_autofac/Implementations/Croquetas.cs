using Buffet_autofac.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buffet_autofac.Implementations
{
    public class Croquetas : SetService
    {
        public void GetFood()
        {
            Console.WriteLine("Has cogido unas croquetillas");
        }
    }
}
