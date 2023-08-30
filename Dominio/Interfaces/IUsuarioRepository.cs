namespace Dominio.Interfaces;
public interface IUsuarioRepository : IGenericRepositoryB<Usuario>
{
    Task<Usuario> GetByUsernameAsync(string username);
}