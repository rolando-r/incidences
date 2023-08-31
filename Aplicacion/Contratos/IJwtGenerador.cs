using Dominio;

namespace Aplicacion.Contratos;
public interface IJwtGenerador
{
    string CrearToken(Usuario usuario);
}