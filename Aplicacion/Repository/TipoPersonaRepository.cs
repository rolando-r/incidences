using Dominio;
using Dominio.Interfaces;
using Persistencia;

namespace Aplicacion.Repository
{
    public class TipoPersonaRepository : GenericRepositoryB<TipoPersona>, ITipoPersonaRepository
    {
        public TipoPersonaRepository(IncidencesContext context) : base(context)
        {
        }
    }
}