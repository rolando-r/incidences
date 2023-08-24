using Dominio;
using Dominio.Interfaces;
using Persistencia;

namespace Aplicacion.Repository
{
    public class GeneroRepository : GenericRepositoryB<Genero>, IGeneroRepository
    {
        public GeneroRepository(IncidencesContext context) : base(context)
        {
        }
    }
}