namespace Dominio;
public class Genero : BaseEntityA
{
    public string NombreGenero { get; set; }
    public ICollection<Persona> Personas { get; set; }
}