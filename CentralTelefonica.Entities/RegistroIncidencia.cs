using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralTelefonica.Entities
{
    public class RegistroIncidencia
    {
        private int _RegistroIncidenciaId;
        private int _IncidenciaId;

       
        public int IncidenciaId { get { return _IncidenciaId; } }
        public int RegistroIncidenciaId { get { return _RegistroIncidenciaId; } }
    }
}
