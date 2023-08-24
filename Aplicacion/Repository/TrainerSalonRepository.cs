using Dominio;
using Dominio.Interfaces;
using Persistencia;

namespace Aplicacion.Repository
{
    public class TrainerSalonRepository : GenericRepository<TrainerSalon>, ITrainerSalonRepository
    {
        public TrainerSalonRepository(IncidencesContext context) : base(context)
        {
        }
    }
}