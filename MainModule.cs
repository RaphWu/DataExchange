using Autofac;
using Calin.TaskPulse.Views;

namespace Calin.TaskPulse
{
    public class MainModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<MainMenuControl>().AsSelf().PropertiesAutowired();
        }
    }
}
