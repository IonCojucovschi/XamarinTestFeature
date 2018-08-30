using System;
using Autofac;
using StartupCore.ViewModels;
using StartupCore.Services.Data;
using StartupCore.Contracts.Services.Data;
using StartupCore.Services.General;
using StartupCore.Contracts.Services.General;
using StartupCore.Repository;
using StartupCore.Contracts.Repository;
namespace StartupCore.Bootstrap
{
    public class AppContainer
    {
        private static IContainer _container;

        //register all dependencies in container using autofac dependency injection 
        public static void RegisterDependencies()
        {
            var builder = new ContainerBuilder();

            //Register ViewModels 
            builder.RegisterType<AboutViewModel>();
            builder.RegisterType<HomeViewModel>();
            builder.RegisterType<MainViewModel>();
            builder.RegisterType<MenuViewModel>();



            //register services data 
            builder.RegisterType<BooksDataService>().As<IBooksDataService>();


            // register all services-general
            builder.RegisterType<AuthenticationService>().As<IAuthenticationService>();
            builder.RegisterType<NavigationService>().As<INavigationService>();
            builder.RegisterType<DialogService>().As<IDialogService>();
            builder.RegisterType<SettingsService>().As<ISettingsService>();
            builder.RegisterType<ConnectionService>().As<IConnectionService>();

            //General 
            builder.RegisterType<GenericRepository>().As<IGenericRepository>();

            _container = builder.Build();
        }

        public static object Resolve(Type typeName)
        {
            return _container.Resolve(typeName);
        }
        public static T Resolve<T>()
        {
            return _container.Resolve<T>();
        }
    }
}
