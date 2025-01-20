using Microsoft.Extensions.DependencyInjection;


namespace ERPWebAPI.Core.Utilities.IoC
{
    public interface ICoreModule
    {
        void Load(IServiceCollection serviceCollection);
    }
}
