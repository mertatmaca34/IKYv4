using Business.Abstract;
using Business.Concrete;
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

            var services = AddServices();
            var serviceProvider = services.BuildServiceProvider();

            var context = serviceProvider.GetRequiredService<IKYContext>();
            context.Database.CreateIfNotExists();

            var formMain = serviceProvider.GetRequiredService<FormMain>();
            Application.Run(formMain);
        }

        private static IServiceCollection AddServices()
        {
            var services = new ServiceCollection();

            services.AddSingleton<IPersonelDal, PersonelDal>();
            services.AddSingleton<IPersonelManager, PersonelManager>();

            services.AddSingleton<IKullaniciDal, KullaniciDal>();
            services.AddSingleton<IKullaniciManager, KullaniciManager>();

            services.AddSingleton<IMudurlukDal, MudurlukDal>();
            services.AddSingleton<IMudurlukManager, MudurlukManager>();

            services.AddSingleton<ISeflikDal, SeflikDal>();
            services.AddSingleton<ISeflikManager, SeflikManager>();

            services.AddSingleton<ITesisDal, TesisDal>();
            services.AddSingleton<ITesisManager, TesisManager>();

            services.AddSingleton<IIzinDal, IzinDal>();
            services.AddSingleton<IIzinManager, IzinManager>();

            services.AddSingleton<IUnvanDal, UnvanDal>();
            services.AddSingleton<IUnvanManager, UnvanManager>();

            services.AddSingleton<INufusDal, NufusDal>();
            services.AddSingleton<INufusManager, NufusManager>();

            services.AddSingleton<ISertifikaDal, SertifikaDal>();
            services.AddSingleton<ISertifikaManager, SertifikaManager>();

            services.AddSingleton<INakilDal, NakilDal>();
            services.AddSingleton<INakilManager, NakilManager>();

            services.AddSingleton<IIletisimDal, IletisimDal>();
            services.AddSingleton<IIletisimManager, IletisimManager>();

            services.AddSingleton<ITahsilDal, TahsilDal>();
            services.AddSingleton<ITahsilManager, TahsilManager>();

            services.AddSingleton<IUnvanGrubuDal, UnvanGrubuDal>();
            services.AddSingleton<IUnvanGrubuManager, UnvanGrubuManager>();

            services.AddSingleton<IPuantajDal, PuantajDal>();
            services.AddSingleton<IPuantajManager, PuantajManager>();

            services.AddSingleton<ICalismaSaatleriDal, CalismaSaatleriDal>();
            services.AddSingleton<ICalismaSaatleriManager, CalismaSaatleriManager>();

            services.AddSingleton<ICocukDal, CocukDal>();
            services.AddSingleton<ICocukManager, CocukManager>();

            services.AddScoped<IKYContext>();
            services.AddTransient<FormMain>();

            return services;
        }
    }
}