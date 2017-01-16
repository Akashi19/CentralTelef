
using System.Data.Entity.ModelConfiguration;
using CentralTelefonica.Entities;

namespace CentralTelefonica.Context.EntitiesConfiguration
{
    class IncidenciaConfiguration : EntityTypeConfiguration<Incidencia>
    {
        public IncidenciaConfiguration()
        {
            //Configuro el nombre de la tabla en la base de datos
            ToTable("Incidencia");

            //Configuro la llave primaria de la tabla Celular
            HasKey(a => a.IncidenciaId);

            //Configuro la longitud maxima del campo Nombre y otros campos
            Property(a => a.Descripccion).HasMaxLength(250);
            Property(a => a.TipoInId);
            Property(a => a.IncidenciaId);
        }
    }
}
