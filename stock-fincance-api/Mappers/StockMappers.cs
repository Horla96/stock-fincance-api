using stock_fincance_api.Dtos.Stock;
using stock_fincance_api.Models;
using static stock_fincance_api.Dtos.Stock.StockDto;

namespace stock_fincance_api.Mappers
{
    public static class StockMappers
    {
        public static StockDto ToStockDto(this Stock stockModel)
        {
            return new StockDto
            {
                Id = stockModel.Id,
                Symbol = stockModel.Symbol,
                CompanyName = stockModel.CompanyName,
                Purchase = stockModel.Purchase,
                LastDiv = stockModel.LastDiv,
                Industry = stockModel.Industry,
                MarketType = stockModel.MarketType
            };
        }
    }
}
