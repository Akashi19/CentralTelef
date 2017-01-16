
using System.Data.Entity.ModelConfiguration;
using CentralTelefonica.Entities;

namespace CentralTelefonica.Context.EntitiesConfiguration
{
    class CelularConfiguration : EntityTypeConfiguration<Celular>
    {
        public CelularConfiguration()
        {
            //Configuro el nombre de la tabla en la base de datos
            ToTable("Celular");

            //Configuro la llave primaria de la tabla Celular
            HasKey(a => a.CelularId);

            //Configuro la longitud maxima del campo Nombre
            Property(a => a.Numero).HasMaxLength(10);
        }
    }
}
