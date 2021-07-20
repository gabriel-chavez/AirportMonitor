using AirportMonitor.Facade;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirportMonitor
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Vuelo> vuelosSalida = new List<Vuelo>() ;
            List<Vuelo> vuelosLlegada = new List<Vuelo>();
            FacadeVuelosApi facadeVuelosApi = new FacadeVuelosApi();
            vuelosSalida=facadeVuelosApi.ListarVuelosSalida();
            vuelosLlegada = facadeVuelosApi.ListarVuelosLlegada();


            Console.WriteLine("===========================================================");
            Console.WriteLine("====================S A L I D A S===========================");
            Console.WriteLine("===========================================================");
           
            
            Console.WriteLine(String.Format("|{0,15}|{1,15}|{2,15}|{3,15}|{4,15}|{5,15}|", "Hora", "CIA", "Vuelo", "Destino", "PTA", "Observación"));
            foreach (var item in vuelosSalida)
            {
                Console.WriteLine(String.Format("|{0,15}|{1,15}|{2,15}|{3,15}|{4,15}|{5,15}|", item.Hora.ToString("hh:mm:ss"), item.Compania, item.IdVuelo, item.Destino, item.Puerta, item.Observacion));                
            }
            
            Console.WriteLine("===========================================================");
            Console.WriteLine("====================L L E G A D A S========================");
            Console.WriteLine("===========================================================");
            Console.WriteLine(String.Format("|{0,15}|{1,15}|{2,15}|{3,15}|{4,15}|{5,15}|", "Hora", "CIA", "Vuelo", "Destino", "PTA", "Observación"));
            foreach (var item in vuelosLlegada)
            {
                Console.WriteLine(String.Format("|{0,15}|{1,15}|{2,15}|{3,15}|{4,15}|{5,15}|", item.Hora.ToString("hh:mm:ss"), item.Compania, item.IdVuelo, item.Destino, item.Puerta, item.Observacion));
            }
            Console.ReadLine();

        }
    }
}
