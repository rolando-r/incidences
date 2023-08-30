namespace Dominio.Interfaces;
public interface IUnitOfWork
{
    IPaisRepository Paises { get; }
    IPersonaRepository Personas { get; }
    IRolRepository Roles { get; }
    IUsuarioRepository Usuarios { get; }
    Task<int> SaveAsync();
}