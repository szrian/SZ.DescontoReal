using SZ.DescontoReal.Clients.HGFinanceApi.DTOs;

namespace SZ.DescontoReal.Clients.HGFinanceApi.Interfaces;

public interface IHGFinanceApiServico
{
    Task<TaxaCdiDTO> ObterTaxaCDI();
}
