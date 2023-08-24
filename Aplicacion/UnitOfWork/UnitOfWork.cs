using Aplicacion.Repository;
using Dominio.Interfaces;
using Persistencia;
namespace Aplicacion.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork, IDisposable
    {
        private readonly IncidencesContext context;
        private PaisRepository _paises;
        private CiudadRepository _ciudades;
        private DepartamentoRepository _departamentos;
        private GeneroRepository _generos;
        private MatriculaRepository _matriculas;
        private PersonaRepository _personas;
        private SalonRepository _salones;
        private TipoPersonaRepository _tipopersonas;
        private RolRepository _roles;
        public UnitOfWork(IncidencesContext _context)
        {
            context = _context;
        }
        public IPaisRepository Paises
        {
            get
            {
                if (_paises == null)
                {
                    _paises = new PaisRepository(context);
                }
                return _paises;
            }
        }
        
        public ICiudadRepository Ciudades
        {
            get
            {
                if (_ciudades == null)
                {
                    _ciudades = new CiudadRepository(context);
                }
                return _ciudades;
            }
        }
        public IDepartamentoRepository Departamentos
        {
            get
            {
                if (_departamentos == null)
                {
                    _departamentos = new DepartamentoRepository(context);
                }
                return _departamentos;
            }
        }
        public IGeneroRepository Generos
        {
            get
            {
                if (_generos == null)
                {
                    _generos = new GeneroRepository(context);
                }
                return _generos;
            }
        }
        public IMatriculaRepository Matriculas
        {
            get
            {
                if (_matriculas == null)
                {
                    _matriculas = new MatriculaRepository(context);
                }
                return _matriculas;
            }
        }
        public IPersonaRepository Personas
        {
            get
            {
                if (_personas == null)
                {
                    _personas = new PersonaRepository(context);
                }
                return _personas;
            }
        }
        public IRolRepository Roles
        {
            get
            {
                if (_roles == null)
                {
                    _roles = new RolRepository(context);
                }
                return _roles;
            }
        }
        public ITipoPersonaRepository TipoPersonas
        {
            get
            {
                if (_tipopersonas == null)
                {
                    _tipopersonas = new TipoPersonaRepository(context);
                }
                return _tipopersonas;
            }
        }
        public ISalonRepository Salones
        {
            get
            {
                if (_salones == null)
                {
                    _salones = new SalonRepository(context);
                }
                return _salones;
            }
        }
        public async Task<int> SaveAsync()
        {
            return await context.SaveChangesAsync();
        }
        public void Dispose()
        {
            context.Dispose();
        }
    }
}