using Dominio;
using Dominio.Interfaces;
using Persistencia;

namespace Aplicacion.Repository
{
    public class MatriculaRepository : GenericRepositoryB<Matricula>, IMatriculaRepository
    {
        public MatriculaRepository(IncidencesContext context) : base(context)
        {
        }
    }
}