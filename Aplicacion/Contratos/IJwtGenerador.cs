using Dominio;

namespace Aplicacion.Contratos;
public class IJwtGenerador
{
    string CrearToken(Usuario usuario);
}