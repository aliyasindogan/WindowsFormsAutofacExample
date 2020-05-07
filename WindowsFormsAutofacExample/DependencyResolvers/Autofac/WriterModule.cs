using Autofac;
using WindowsFormsAutofacExample.Abstract;
using WindowsFormsAutofacExample.Concrete;

namespace WindowsFormsAutofacExample.DependencyResolvers.Autofac
{
    internal class WriterModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<MessageBoxMessage>().As<IOutput>();
            builder.RegisterType<TodayWriter>().As<IDateWriter>();
        }
    }
}