using Newtonsoft.Json;

namespace SZ.DescontoReal.Clients.HGFinanceApi.DTOs;

public class TaxaCdiDTO
{
    [JsonProperty("results")]
    public ResultadoDTO Resultado { get; set; }
}

public class ResultadoDTO
{
    [JsonProperty("taxes")]
    public List<TaxasDTO> Taxas { get; set; }
}

public class TaxasDTO
{
    [JsonProperty("date")]
    public string DataConsulta { get; set; }

    [JsonProperty("cdi_daily")]
    public decimal TaxaCdi { get; set; }
}
