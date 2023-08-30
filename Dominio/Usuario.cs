namespace Dominio;
public class Usuario : BaseEntityA
{
    public string Username { get; set; }
    public string Email { get; set; }
    public string Password { get; set; }
    public ICollection<Rol> Roles { get; set; } = new HashSet<Rol>();
    public ICollection<UsuariosRoles> UsuariosRoles { get; set; }
}