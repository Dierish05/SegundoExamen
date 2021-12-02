using AppCore.Services;
using Autofac;
using Domain.Interfaces;
using Infraestructura.Interfaces;
using RegistroNotas.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RegistroNotas
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            var builder = new ContainerBuilder();

            builder.RegisterType<NotaListRepository>().As<INotasRepository>();
            builder.RegisterType<NotaServices>().As<NotaRepositoryService>();
            var container = builder.Build();
            Application.Run(new RegistroDatos(container.Resolve<NotaRepositoryService>()));

            //Application.EnableVisualStyles();
            //Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new RegistroDatos());
        }
    }
}
