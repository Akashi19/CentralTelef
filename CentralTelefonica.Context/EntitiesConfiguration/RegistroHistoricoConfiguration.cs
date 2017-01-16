
using System.Data.Entity.ModelConfiguration;
using CentralTelefonica.Entities;

namespace CentralTelefonica.Context.EntitiesConfiguration
{
    class RegistroHistoricoConfiguration : EntityTypeConfiguration<RegistroHistorico>
    {
        public RegistroHistoricoConfiguration()
        {
            //Configuro el nombre de la tabla en la base de datos
            ToTable("RegistroHistorico");

            //Configuro la llave primaria de la tabla Registro Historico
            HasKey(a => a.RegistroHistoricoId);

            //Configuro la longitud maxima del campo Fecha de Registro
            Property(a => a.Fecha_reg);
        }
    }
}
