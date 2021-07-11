using Buffet_autofac.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buffet_autofac.Implementations
{
    public class SetServiceCallerImp : SetServiceCaller
    {
        private readonly SetService Croquetas;
        private readonly SetService EnsaladillaRusa;

        public SetServiceCallerImp(SetService EnsaladillaRusa)
        {
            this.EnsaladillaRusa = EnsaladillaRusa;
        }
        public void CallSetService()
        {
            EnsaladillaRusa.GetFood();
        }
    }
}
