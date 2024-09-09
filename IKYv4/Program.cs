using Business.Abstract;
using Business.Concrete;
using Business.DependencyResolvers;
using DataAccess.Abstract;
using DataAccess.Concrete;
using DataAccess.Concrete.Context;
using IKYv4.Forms;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Windows.Forms;

namespace IKYv4
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            var services = BusinessServices.AddServices();

            services.AddTransient<FormMain>();

            var serviceProvider = services.BuildServiceProvider();

            var context = serviceProvider.GetRequiredService<IKYContext>();
            context.Database.CreateIfNotExists();

            var formMain = serviceProvider.GetRequiredService<FormMain>();
            Application.Run(formMain);
        }
    }
}