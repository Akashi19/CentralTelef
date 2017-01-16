using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralTelefonica.Entities
{
    public class Central
    {
        private int _CentralId;
        List<Telefono> _Telefonos;
        List<LLamada> _Llamadas;

        public Central()
        {
            _Telefonos = new List<Telefono>();
            _Llamadas = new List<LLamada>();
        }

        public void Agregar(String numero)
        {
            if (_Telefonos.Count == 100)
                return;
            
            if (numero[0] == '9')
                _Telefonos.Add(new Celular(numero));
            else
                _Telefonos.Add(new Fijo(numero));           
        }

        public void Eliminar(String numero)
        {
            if (numero[0] == '9')
                _Telefonos.Remove(new Celular(numero));
            else
                _Telefonos.Remove(new Fijo(numero));     
        }

        public void IniciarLlamada(String numero)
        {
            if (_Llamadas.Count == 50)
                return;
            
            var Llamada = new LLamada(numero);

            _Llamadas.Add(Llamada);

            Console.WriteLine("Iniciando LLamada al [{0}]", numero);

        }

        public double FinalizarLlamada(String numero)
        {
            var telefono = _Telefonos.Find(t => t.Numero == numero);

            if (telefono == null)
                return 0;

            var llamada = _Llamadas.Find(ll => ll.Telefono.Numero == numero);

            if (llamada == null)
                return 0;

            var duración = new Reloj().GetTime() - llamada.Reloj.GetTime();
            var costollamada = duración * llamada.Tarifa();

            _Llamadas.Remove(llamada);

            Console.WriteLine("Finalizado llamada al [{0}]", numero);
            Console.WriteLine("Costo de la llamada [s/{0}]", costollamada.ToString());
            Console.WriteLine();

            return costollamada;

        }

        public int CentralId { get { return _CentralId; } }
    }
}
