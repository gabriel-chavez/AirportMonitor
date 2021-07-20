using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirportMonitor.VuelosAPI.BoaApi
{
    public  class BoaAPI
    {
        List<VuelosBoa> lVuelosBoa;
        public BoaAPI()
        {
            lVuelosBoa = new List<VuelosBoa>();
            lVuelosBoa.Add(new VuelosBoa { IdVuelo = 10, Hora = DateTime.Now, Compania = "Boa", Origen = "Cochabamba", Destino = "La Paz", Tipo = Tipo.Llegada, Puerta = 2, Observacion = "Cerrado" });
            lVuelosBoa.Add(new VuelosBoa { IdVuelo = 20, Hora = DateTime.Now.AddHours(1).AddMinutes(30), Compania = "Boa", Origen = "Santa Cruz", Destino = "La Paz", Tipo = Tipo.Llegada, Puerta = 2, Observacion = "Confirmado" });
            lVuelosBoa.Add(new VuelosBoa { IdVuelo = 30, Hora = DateTime.Now.AddMinutes(30), Compania = "Boa", Origen = "Cobija", Destino = "La Paz", Tipo = Tipo.Llegada, Puerta = 4, Observacion = "Confirmado" });
            lVuelosBoa.Add(new VuelosBoa { IdVuelo = 10, Hora = DateTime.Now, Compania = "Boa", Origen = "La Paz", Destino = "Cochabamba", Tipo = Tipo.Salida, Puerta = 2, Observacion = "Cerrado" });
            lVuelosBoa.Add(new VuelosBoa { IdVuelo = 20, Hora = DateTime.Now.AddHours(1).AddMinutes(30), Compania = "Boa", Origen = "La Paz", Destino = "Santa Cruz", Tipo = Tipo.Salida, Puerta = 2, Observacion = "Confirmado" });
            lVuelosBoa.Add(new VuelosBoa { IdVuelo = 30, Hora = DateTime.Now.AddMinutes(30), Compania = "Boa", Origen = "La Paz", Destino = "Santa Cruz", Tipo = Tipo.Salida, Puerta = 4, Observacion = "Confirmado" });
        }
        public List<VuelosBoa> ListarLlegadas()
        {
            return lVuelosBoa.Where(s => s.Tipo == Tipo.Llegada).ToList();           
        }
        public List<VuelosBoa> ListarSalidas()
        {
            return lVuelosBoa.Where(s => s.Tipo == Tipo.Salida).ToList();
        }
        public VuelosBoa ObtenerVuelo(int idVuelo)
        {
            return lVuelosBoa.Where(s => s.IdVuelo == idVuelo).FirstOrDefault();
        }
    }
}
