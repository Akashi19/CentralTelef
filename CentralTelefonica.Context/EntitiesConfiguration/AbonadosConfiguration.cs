
using System.Data.Entity.ModelConfiguration;
using CentralTelefonica.Entities;

namespace CentralTelefonica.Context.EntitiesConfiguration
{
    class AbonadosConfiguration : EntityTypeConfiguration<Abonados>
    {
        public AbonadosConfiguration()
        {
            //Configuro el nombre de la tabla en la base de datos
            ToTable("Abonados");

            //Configuro la llave primaria de la tabla Abonados
            HasKey(a => a.AbonadosId);

            //Configuro la longitud maxima del campo Nombre
            Property(a => a.Telefono).HasMaxLength(50);
        }
    }
}
