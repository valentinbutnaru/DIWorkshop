using Autofac;
using DIWorkshop.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIWorkshop.ConsoleProject
{
	class Program
	{
		static void Main(string[] args)
		{
            var container = ContainerConfig.Configure();

            using (var scope = container.BeginLifetimeScope())
            {
                var app = scope.Resolve<IDriverManager>();

               app.GetDriverByCar(10);
            }
		}
	}
}
