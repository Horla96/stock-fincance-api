using System.ComponentModel.DataAnnotations;

namespace stock_fincance_api.Dtos.Account;

public class LoginDto
{

    [Required]
    public string Username { get; set; }
    [Required]
    public string Password { get; set; }
}
