using Dominio;
using Dominio.Interfaces;
using Persistencia;

namespace Aplicacion.Repository
{
    public class SalonRepository : GenericRepositoryB<Salon>, ISalonRepository
    {
        public SalonRepository(IncidencesContext context) : base(context)
        {
        }
    }
}