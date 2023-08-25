namespace ApiIncidencias.Dtos;

public class PaisxDepDto
{
    public string Id { get; set; }
    public string NombrePais { get; set; }
    public List<DepartamentoDto> departamentos { get; set; }
}