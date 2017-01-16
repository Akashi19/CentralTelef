
using System.Data.Entity.ModelConfiguration;
using CentralTelefonica.Entities;

namespace CentralTelefonica.Context.EntitiesConfiguration
{
    class RegistroIncidenciaConfiguration : EntityTypeConfiguration<RegistroIncidencia>
    {
        public RegistroIncidenciaConfiguration()
        {
            //Configuro el nombre de la tabla en la base de datos
            ToTable("RegistroIncidencia");

            //Configuro la llave primaria de la tabla Celular
            HasKey(a => a.RegistroIncidenciaId);

            //Configuro la longitud maxima del campo Incidencia Id
            Property(a => a.IncidenciaId);
        }
    }
}
