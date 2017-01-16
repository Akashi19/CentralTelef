
using System.Data.Entity.ModelConfiguration;
using CentralTelefonica.Entities;

namespace CentralTelefonica.Context.EntitiesConfiguration
{
    class FijoConfiguration : EntityTypeConfiguration<Fijo>
    {
        public FijoConfiguration()
        {
            //Configuro el nombre de la tabla en la base de datos
            ToTable("Fijo");

            //Configuro la llave primaria de la tabla Celular
            HasKey(a => a.FijoId);

            //Configuro la longitud maxima del campo Numero
            Property(a => a.Numero).HasMaxLength(10);
        }
    }
}
