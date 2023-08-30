namespace Dominio;
public class Rol : BaseEntityA
{
    public string Nombre { get; set; }
    public ICollection<Persona> Usuarios { get; set; } = new HashSet<Persona>();
    public ICollection<UsuarioRoles> UsuariosRoles { get; set; }
}