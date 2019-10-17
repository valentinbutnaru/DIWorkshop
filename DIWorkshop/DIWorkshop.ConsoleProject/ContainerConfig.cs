using Autofac;
using DIWorkshop.Interfaces;
using DIWorkshop.Managers;
using DIWorkshop.Persistence;

namespace DIWorkshop.ConsoleProject
{
    public static class ContainerConfig
    {
        public static IContainer Configure()
        {
            var builder = new ContainerBuilder();

            builder.RegisterType<DbContext>().SingleInstance();
            builder.RegisterType<DriverManager>().As<IDriverManager>();
            builder.RegisterType<DriverRepository>().As<IDriverRepository>();
            builder.RegisterType<CarRepository>().As<ICarRepository>();

            return builder.Build();
        }
    }
}
