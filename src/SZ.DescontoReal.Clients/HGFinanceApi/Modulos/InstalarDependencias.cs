using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using SZ.DescontoReal.Clients.HGFinanceApi.Configuracao;
using SZ.DescontoReal.Clients.HGFinanceApi.Interfaces;
using SZ.DescontoReal.Clients.HGFinanceApi.Servicos;

namespace SZ.DescontoReal.Clients.HGFinanceApi.Modulos;

public static class InstalarDependencias
{
    public static IServiceCollection RegistrarHGFinanceServico(this IServiceCollection servicos, IConfiguration configuration)
    {
        var hgFinanceApiConfig = new HGFinanceApiConfig();
        configuration.Bind("HGFinanceApiConfig", hgFinanceApiConfig);

        servicos.AddSingleton(hgFinanceApiConfig);
        servicos.AddScoped<IHGFinanceApiServico, HGFinanceApiServico>();

        servicos.AddHttpClient("HGFinanceApi", httpClient =>
        {
            httpClient.BaseAddress = new Uri(hgFinanceApiConfig.Uri);
        });

        return servicos;
    }
}
