using System.ComponentModel.DataAnnotations;
namespace AuthServer.Server.Contracts.Auth
{
    public class LoginRequest
    {
        [Required]
        [MaxLength(256)]
        public string UserName { get; set; } = string.Empty;


        [Required]
        [MaxLength(256)]
        public string Password { get; set; } = string.Empty;
    }
}
