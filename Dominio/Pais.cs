namespace Dominio;
public class Pais : BaseEntity
{
    public string NombrePais { get; set; }
    public ICollection<Departamento> Departamentos { get; set; }
}