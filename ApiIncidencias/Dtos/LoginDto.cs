using System.ComponentModel.DataAnnotations;

namespace ApiIncidencias.Dtos;
    public class LoginDto
    {
        [Required]
        public string Username { get; set; }
        [Required]
        public string Password { get; set; }
    }