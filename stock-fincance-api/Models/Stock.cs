using System.ComponentModel.DataAnnotations.Schema;

namespace stock_fincance_api.Models;

public class Stock
{
    public string Id { get; set; }
    public string Symbol { get; set; }
    public string CompanyName { get; set; } = string.Empty;
    [Column(TypeName = "decimal(18,2)")]

    public decimal Purchase {  get; set; }
    [[Column(TypeName = "decimal(18,2)")]
    public decimal LastDiv { get; set; }
    public string Industtry { get; set; }
    public long MarketType { get; set; }

    public List<Comment> Comments { get; set; } = new List<Comment>();
}
