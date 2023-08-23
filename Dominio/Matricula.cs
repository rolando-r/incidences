namespace Dominio;
public class Matricula : BaseEntityA
{
    public string IdPersonaFk { get; set; }
    public Persona Persona { get; set; }
    public int IdSalonFk { get; set; }
    public Salon Salon { get; set; }
}