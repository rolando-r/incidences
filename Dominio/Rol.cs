namespace Dominio;
public class Rol : BaseEntityA
{
    public string Nombre { get; set; }
    public ICollection<Persona> Personas { get; set; } = new HashSet<Persona>();
    public ICollection<PersonaRoles> PersonaRoles { get; set; }
}