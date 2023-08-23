namespace Dominio;
public class TipoPersona : BaseEntityA
{
    public string DescripcionTipoPersona { get; set; } 
    public ICollection<Persona> Personas { get; set; }  
}