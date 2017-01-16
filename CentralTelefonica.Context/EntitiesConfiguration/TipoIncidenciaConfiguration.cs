
using System.Data.Entity.ModelConfiguration;
using CentralTelefonica.Entities;

namespace CentralTelefonica.Context.EntitiesConfiguration
{
    class TipoIncidenciaConfiguration : EntityTypeConfiguration<TipoIncidencia>
    {
        public TipoIncidenciaConfiguration()
        {
            //Configuro el nombre de la tabla en la base de datos
            ToTable("TipoIncidencia");

            //Configuro la llave primaria de la tabla TipoIncidencia
            HasKey(a => a.TipoIncidenciaId);

            //Configuro la longitud maxima del campo Nombre
            Property(a => a.Nombre).HasMaxLength(20);
        }
    }
}
