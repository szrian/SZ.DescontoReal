using SZ.DescontoReal.Clients.HGFinanceApi.Modulos;

namespace SZ.DescontoReal.Site.Configuracao;

public static class InjecaoDeDependencia
{
    public static IServiceCollection ResolverDependencias(this IServiceCollection servicos, IConfiguration configuration)
    {
        servicos.RegistrarHGFinanceServico(configuration);

        return servicos;
    }
}
