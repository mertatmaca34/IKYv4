using Business.Abstract;
using Business.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete.Context;
using DataAccess.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;

namespace Business.DependencyResolvers
{
    public static class BusinessServices
    {
        public static IServiceCollection AddServices()
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

            services.AddSingleton<IKadroDurumlariDal, KadroDurumlariDal>();
            services.AddSingleton<IKadroDurumlariManager, KadroDurumlariManager>();

            services.AddScoped<IKYContext>();

            return services;
        }
    }
}
