using Aplicacion.Repository;
using Dominio.Interfaces;
using Persistencia;
namespace Aplicacion.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork, IDisposable
    {
        private readonly IncidencesContext context;
        private PaisRepository _paises;
        private RolRepository _roles;
        private PersonaRepository _personas;
        private IUsuarioRepository _usuarios;
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
        public IUsuarioRepository Usuarios
        {
            get
            {
                if (_usuarios == null)
                {
                    _usuarios = new UsuarioRepository(context);
                }
                return _usuarios;
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