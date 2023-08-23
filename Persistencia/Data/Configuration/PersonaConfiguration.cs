using Dominio;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
namespace Persistencia.Data.Configuration
{
    public class PersonaConfiguration : IEntityTypeConfiguration<Persona>
    {
        public void Configure(EntityTypeBuilder<Persona> builder)
        {
            // Aquí puedes configurar las propiedades de la entidad Marca
            // utilizando el objeto 'builder'.
            builder.ToTable("persona");

            builder.HasKey(e => e.Id);
            builder.Property(e => e.Id)
            .HasMaxLength(20);

            builder.Property(p => p.NombrePersona)
            .IsRequired()
            .HasMaxLength(50);

            builder.HasOne(p => p.Genero)
            .WithMany(p => p.Personas)
            .HasForeignKey(p => p.IdGeneroFk);

            builder.HasOne(p => p.Ciudad)
            .WithMany(p => p.Personas)
            .HasForeignKey(p => p.IdCiudadFk);

            builder.HasOne(p => p.TipoPersona)
            .WithMany(p => p.Personas)
            .HasForeignKey(p => p.IdTipoPerFk);
            
            builder
            .HasMany(p => p.Roles)
            .WithMany(p => p.Personas)
            .UsingEntity<PersonaRoles>(
                j => j
                    .HasOne(pt => pt.Rol)
                    .WithMany(t => t.PersonaRoles)
                    .HasForeignKey(pt => pt.RolId),
                j => j
                    .HasOne(pt => pt.Persona)
                    .WithMany(p => p.PersonaRoles)
                    .HasForeignKey(pt => pt.UsuarioId),
                j =>
                {
                    j.HasKey(t => new { t.UsuarioId, t.RolId });
                });
        }
    }
}