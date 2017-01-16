using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralTelefonica.Entities
{
    public class Incidencia
    {
        private int _IncidenciaId;
        //private List<LLamada> _Llamadas;
        private String _Descripccion;
        private int _TipoInId;

        public Incidencia(int tipoInId, String descripccion)
        {
            _Descripccion = descripccion;
            _TipoInId = tipoInId;
        }

        public String Descripccion { get { return _Descripccion; } }
        public int TipoInId { get { return _TipoInId; } }
        public int IncidenciaId { get { return _IncidenciaId; } }


    }
}
