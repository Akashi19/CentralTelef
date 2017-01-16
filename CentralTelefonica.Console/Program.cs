using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CentralTelefonica.Entities;
using CentralTelefonica.Context;
using System.Threading;

namespace CentralTelefonica.Console
{
    public class Program
    {
        static void Main(string[] args)
        {
            var central = new Central();

            DataClasses1DataContext celular = new DataClasses1DataContext();

            var numero_cel = from numero in celular.Celulars
                             select new { celular_num= numero.numero};

           
            //Obteniendo Numero de Celulares de la base de datos
            foreach (var fono in numero_cel)
            {
                central.Agregar(fono.ToString());

                central.IniciarLlamada(fono.ToString());
                Thread.Sleep(5000);
                central.FinalizarLlamada(fono.ToString());
            }

            //Obteniendo Numero de Fijo de la base de datos
            var numero_fijo = from fijo in celular.Fijos
                              select new { fijo_numero = fijo.numero };

            
            foreach (var fijo_num in numero_fijo)
            {
                central.Agregar(fijo_num.ToString());

                central.IniciarLlamada(fijo_num.ToString());
                Thread.Sleep(5000);
                central.FinalizarLlamada(fijo_num.ToString());
            }

            //var fono1 = "3647132";
            //var fono2 = "3485078";

            //var fono3 = "999468925";
            //var fono4 = "987542539";
            //var fono5 = "926857423";

            //central.Agregar(fono1);
            //central.Agregar(fono2);
            //central.Agregar(fono3);
            //central.Agregar(fono4);
            //central.Agregar(fono5);

            //central.IniciarLlamada(fono1);
            //Thread.Sleep(5000);
            //central.FinalizarLlamada(fono1);

            //central.IniciarLlamada(fono3);
            //Thread.Sleep(2000);
            //central.FinalizarLlamada(fono3);

            //central.IniciarLlamada(fono4);
            //Thread.Sleep(9000);
            //central.FinalizarLlamada(fono4);

            //central.IniciarLlamada(fono5);
            //Thread.Sleep(4000);
            //central.FinalizarLlamada(fono5);

            //central.IniciarLlamada(fono2);
            //Thread.Sleep(3000);
            //central.FinalizarLlamada(fono2);



        }
    }
}
