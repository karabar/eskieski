using Autofac;
using Autofac.Integration.Mvc;
using eskisehirNET.Core.infrastructure;
using eskisehirNET.Core.Repository;
using System.Web.Mvc;

namespace eskisehirNET.Web
{
    public static class Bootstrapper
    {
        public static void RunConfig()
        {
            BuilAutofac();
        }

        private static void BuilAutofac()
        {
            var builder = new ContainerBuilder();

            builder.RegisterControllers(typeof(MvcApplication).Assembly);

            builder.RegisterType<EczaneRepository>().As<IEczaneRepository>();

            builder.RegisterType<EtkinlikKategoriRepository>().As<IEtkinlikKategoriRepository>();

            builder.RegisterType<EtkinlikRepository>().As<IEtkinlikRepository>();

            builder.RegisterType<FilmlerRepository>().As<IFilmlerRepository>();

            builder.RegisterType<HaberKategoriRepository>().As<IHaberKategoriRepository>();

            builder.RegisterType<HaberRepository>().As<IHaberRepository>();

            builder.RegisterType<HaberTipRepository>().As<IHaberTipRepository>();

            builder.RegisterType<MekanKategoriRepository>().As<IMekanKategoriRepository>();

            builder.RegisterType<MekanReklamRepository>().As<IMekanReklamRepository>();

            builder.RegisterType<MekanRepository>().As<IMekanRepository>();

            builder.RegisterType<NobetciEczaneRepository>().As<INobetciEczaneRepository>();

            builder.RegisterType<SeanslarRepository>().As<ISeanslarRepository>();

            builder.RegisterType<VideoRepository>().As<IVideoRepository>();

            builder.RegisterType<YasamKategoriRepository>().As<IYasamKategoriRepository>();

            builder.RegisterType<YasamRepository>().As<IYasamRepository>();


            var container = builder.Build();

            DependencyResolver.SetResolver(new AutofacDependencyResolver(container));
        }
    }
}