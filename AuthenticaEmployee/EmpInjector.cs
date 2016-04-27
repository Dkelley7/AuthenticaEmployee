using System.Reflection;
using System.Web.Mvc;
using AuthenticaEmployee.Interfaces;
using SimpleInjector;
using SimpleInjector.Integration.Web;
using SimpleInjector.Integration.Web.Mvc;

namespace AuthenticaEmployee
{
    public static class EmpInjector
    {
        public static void Initialize()
        {
            var container = new Container();
            container.Options.DefaultScopedLifestyle = new WebRequestLifestyle();

            // Register your types, for instance:
            container.Register<IEmployeeContext, EmployeeContext>(Lifestyle.Scoped);
            container.Register<IEmployeeService, EmployeeService>(Lifestyle.Scoped);
            container.RegisterMvcIntegratedFilterProvider();

            // This is an extension method from the integration package.
            container.RegisterMvcControllers(Assembly.GetExecutingAssembly());


            DependencyResolver.SetResolver(new SimpleInjectorDependencyResolver(container));
        }
    }
}