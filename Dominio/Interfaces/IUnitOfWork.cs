namespace Dominio.Interfaces;
public interface IUnitOfWork
{
    ICiudadRepository Ciudades { get; }
    IDepartamentoRepository Departamentos { get; }
    IGeneroRepository Generos { get; }
    IMatriculaRepository Matriculas { get; }
    IPaisRepository Paises { get; }
    IPersonaRepository Personas { get; }
    IRolRepository Roles { get; }
    ISalonRepository Salones { get; }
    ITipoPersonaRepository TipoPersonas { get; }
    IUsuarioRepository Usuarios { get; }
    Task<int> SaveAsync();
}