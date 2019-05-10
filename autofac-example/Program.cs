using System;
using Autofac;

namespace autofac_example
{
    public class Program
    {
        public void Go()
        {
            var container = ConfigureAutofac();

            DoThings(container);
        }

        private IContainer ConfigureAutofac()
        {
            var containerBuilder = new ContainerBuilder();
            containerBuilder.RegisterType<RealLogger>().As<ILogThings>();
            return containerBuilder.Build();
        }

        private void DoThings(IContainer container)
        {
            var logger = container.Resolve<ILogThings>();
            logger.Log("hello world");
        }
    }

    public interface ILogThings
    {
        void Log(string message);
    }

    public class RealLogger : ILogThings
    {
        public void Log(string message)
        {
            Console.WriteLine(message);
        }
    }
}
