using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralTelefonica.Entities
{
    public class RegistroHistorico
    {
        private int _RegistroHistoricoId;
        private DateTime _Fecha_reg;
        private int _LlamadaId;

        public RegistroHistorico(int llamdaId)
        {
            _Fecha_reg = DateTime.Now;

            _LlamadaId = llamdaId;
        }

        public DateTime Fecha_reg { get { return _Fecha_reg; } }
        public int LlamadaId { get { return _LlamadaId; } }
        public int RegistroHistoricoId { get { return _RegistroHistoricoId; } }
    }
}
