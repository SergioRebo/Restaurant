using Buffet_autofac.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buffet_autofac.Implementations
{
    public class EnsaladillaRusa : SetService
    {
        public void GetFood()
        {
            Console.WriteLine("Has cogido ensaladilla rusa, que por cierto, no se creó en Russia." +
                " O eso dicen.");
        }
    }
}
