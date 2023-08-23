namespace Dominio;
public class PersonaRoles
{
    public string UsuarioId { get; set; }
    public Persona Persona { get; set; }
    public int RolId { get; set; }
    public Rol Rol { get; set; }
}