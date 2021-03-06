using CnG.Domain.Model.Mappings.Contexts;
using CnG.Foundations.Ioc;
using CnG.Foundations.Persistence;
using CnG.Services.Contracts;
using UnityConfiguration;

namespace CnG.Web.Services.Configurations
{
    public class WcfUnityRegistry : UnityRegistry
    {
        public WcfUnityRegistry()
        {
            Scan(scan =>
                {
                    scan.AssemblyContaining<IUserService>();
                    scan.AssemblyContaining<WcfExecutionContext>();
                    scan.AssemblyContaining<IUnitOfWork>();
                    scan.AssemblyContaining<ContextFactory>();
                    scan.ForRegistries();
                    scan.With<AllInterfacesConvetion>();
                    //    .TypesImplementing<IHaveManyImplementations>();
                    //scan.With<SetAllPropertiesConvention>().OfType<ILogger>();
                    //scan.ExcludeType<FooService>();
                });
        }
    }
}