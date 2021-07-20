using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirportMonitor.VuelosAPI.AmaszomasAPI
{
    public class AmaszomasAPI
    {
        List<VuelosAmasZonas> lVuelosAmasZonas;
        public AmaszomasAPI()
        {
            lVuelosAmasZonas = new List<VuelosAmasZonas>();
            lVuelosAmasZonas.Add(new VuelosAmasZonas { IdVuelo = 1, Hora = DateTime.Now, Compania = "Amaszomas", Origen = "La Paz", Destino = "Santa Cruz", Tipo = Tipo.Salida, Puerta = 2, Observacion = "Cerrado" });
            lVuelosAmasZonas.Add(new VuelosAmasZonas { IdVuelo = 2, Hora = DateTime.Now.AddHours(1).AddMinutes(30), Compania = "Amaszomas", Origen = "La Paz", Destino = "Santa Cruz", Tipo = Tipo.Salida, Puerta = 2, Observacion = "Confirmado" });
            lVuelosAmasZonas.Add(new VuelosAmasZonas { IdVuelo = 3, Hora = DateTime.Now.AddMinutes(30), Compania = "Amaszomas", Origen = "La Paz", Destino = "Santa Cruz", Tipo = Tipo.Llegada, Puerta = 4, Observacion = "Confirmado" });
            lVuelosAmasZonas.Add(new VuelosAmasZonas { IdVuelo = 1, Hora = DateTime.Now, Compania = "Amaszomas", Origen = "Santa Cruz", Destino = "Cochabamba", Tipo = Tipo.Salida, Puerta = 2, Observacion = "Cerrado" });
            lVuelosAmasZonas.Add(new VuelosAmasZonas { IdVuelo = 2, Hora = DateTime.Now.AddHours(1).AddMinutes(30), Compania = "Amaszomas", Origen = "Santa Cruz", Destino = "Cobija", Tipo = Tipo.Salida, Puerta = 2, Observacion = "Confirmado" });
            lVuelosAmasZonas.Add(new VuelosAmasZonas { IdVuelo = 3, Hora = DateTime.Now.AddMinutes(30), Compania = "Amaszomas", Origen = "Santa Cruz", Destino = "Cochabamba", Tipo = Tipo.Llegada, Puerta = 4, Observacion = "Confirmado" });
        }
        public List<VuelosAmasZonas> ObtenerLlegadas()
        {
            return lVuelosAmasZonas.Where(s => s.Tipo == Tipo.Llegada).ToList();
        }
        public List<VuelosAmasZonas> ObtenerSalidas()
        {
            return lVuelosAmasZonas.Where(s => s.Tipo == Tipo.Llegada).ToList();
        }
        public VuelosAmasZonas ObtenerVuelo(int idVuelo)
        {
            return lVuelosAmasZonas.Where(s => s.IdVuelo == idVuelo).FirstOrDefault();
        }
    }
}
