
using LightInject;
using Microsoft.Owin;
using Owin;
using System.Reflection;

[assembly: OwinStartupAttribute(typeof(WebDeveloper.Startup))]
namespace WebDeveloper
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            var container = new ServiceContainer();
            //container.Register<IDataAccess<Client>, ClientData>();
            container.RegisterAssembly(Assembly.GetExecutingAssembly());
            container.RegisterAssembly("WebDeveloper.*.dll");
            container.RegisterControllers();
            container.EnableMvc();
        }
    }
}
