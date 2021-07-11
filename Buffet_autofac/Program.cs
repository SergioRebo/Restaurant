using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Autofac;
using Buffet_autofac.Implementations;

namespace Buffet_autofac
{
    class Program
    {
        private static IContainer Container { get; set; }
        static void Main(string[] args)
        {
            ConfigureContainer();
            Resolution();
            Console.ReadLine();
            
        }
        public static void ConfigureContainer()
        {
            var builder = new ContainerBuilder();

            builder.RegisterType<Croquetas>().SingleInstance();
            builder.RegisterType<Sushi>().SingleInstance();
            builder.RegisterType<EnsaladillaRusa>().SingleInstance();

            Container = builder.Build();
        }

        public static void Resolution()
        {
            using( var scope = Container.BeginLifetimeScope())
            {               
                var croquetas = scope.Resolve<Croquetas>();
                var sushi = scope.Resolve<Sushi>();
                var ensaladilla = scope.Resolve<EnsaladillaRusa>();

                SetServiceCallerImp serviceCaller = new SetServiceCallerImp(ensaladilla);
                serviceCaller.CallSetService();
            }
        }
    }
}
