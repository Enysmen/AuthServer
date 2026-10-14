using System.ComponentModel.DataAnnotations;

namespace AuthServer.Server.Contracts.Auth
{
    public class RegisterResponse
    {
        [Required]
        public Guid UserId { get; set; }

        [Required]
        public string UserName { get; set; } = string.Empty;
    }
}
