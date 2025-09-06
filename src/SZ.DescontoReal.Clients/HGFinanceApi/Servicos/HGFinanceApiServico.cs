using Newtonsoft.Json;
using SZ.DescontoReal.Clients.HGFinanceApi.DTOs;
using SZ.DescontoReal.Clients.HGFinanceApi.Interfaces;

namespace SZ.DescontoReal.Clients.HGFinanceApi.Servicos;

internal class HGFinanceApiServico : IHGFinanceApiServico
{
    private readonly IHttpClientFactory _httpClientFactory;

    public HGFinanceApiServico(IHttpClientFactory httpClientFactory)
    {
        _httpClientFactory = httpClientFactory;
    }

    public async Task<TaxaCdiDTO> ObterTaxaCDI()
    {
        var httpClient = _httpClientFactory.CreateClient("HGFinanceApi");

        var appKey = Environment.GetEnvironmentVariable("ApiSettings__HGFinanceKey");

        var response = await httpClient.GetAsync($"finance?key={appKey}");

        if (!response.IsSuccessStatusCode)
            throw new Exception("Não foi possível obter a taxa do CDI.");

        var taxaCdiDTO = JsonConvert.DeserializeObject<TaxaCdiDTO>(await response.Content.ReadAsStringAsync());

        return taxaCdiDTO;
    }
}
