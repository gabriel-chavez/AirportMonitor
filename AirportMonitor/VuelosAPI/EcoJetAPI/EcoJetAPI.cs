using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirportMonitor.VuelosAPI.EcoJetAPI
{
    public  class EcoJetAPI
    {
        List<VuelosEcoJet> lVuelosEcoJet;
        public EcoJetAPI()
        {
            lVuelosEcoJet = new List<VuelosEcoJet>();
            lVuelosEcoJet.Add(new VuelosEcoJet { IdVuelo = 100, Hora = DateTime.Now, Compania = "EcoJet", Origen = "Cochabamba", Destino = "La Paz", Tipo = Tipo.Llegada, Puerta = 2, Observacion = "Cerrado" });
            lVuelosEcoJet.Add(new VuelosEcoJet { IdVuelo = 200, Hora = DateTime.Now.AddHours(1).AddMinutes(30), Compania = "EcoJet", Origen = "Cobija", Destino = "La Paz", Tipo = Tipo.Llegada, Puerta = 2, Observacion = "Confirmado" });
            lVuelosEcoJet.Add(new VuelosEcoJet { IdVuelo = 300, Hora = DateTime.Now.AddMinutes(30), Compania = "EcoJet", Origen = "Santa Cruz", Destino = "La Paz", Tipo = Tipo.Llegada, Puerta = 4, Observacion = "Confirmado" });
           
            lVuelosEcoJet.Add(new VuelosEcoJet { IdVuelo = 100, Hora = DateTime.Now, Compania = "EcoJet", Origen = "La Paz", Destino = "Cochabamba", Tipo = Tipo.Llegada, Puerta = 2, Observacion = "Cerrado" });
            lVuelosEcoJet.Add(new VuelosEcoJet { IdVuelo = 200, Hora = DateTime.Now.AddHours(1).AddMinutes(30), Compania = "EcoJet", Origen = "La Paz", Destino = "Santa Cruz", Tipo = Tipo.Llegada, Puerta = 2, Observacion = "Confirmado" });
            lVuelosEcoJet.Add(new VuelosEcoJet { IdVuelo = 300, Hora = DateTime.Now.AddMinutes(30), Compania = "EcoJet", Origen = "La Paz", Destino = "Santa Cruz", Tipo = Tipo.Llegada, Puerta = 4, Observacion = "Confirmado" });
        }

        public List<VuelosEcoJet> VuelosLlegadas()
        {
            return lVuelosEcoJet.Where(s => s.Tipo == Tipo.Llegada).ToList();
        }
        public List<VuelosEcoJet> VuelosSalidas()
        {            
            return lVuelosEcoJet.Where(s => s.Tipo == Tipo.Salida).ToList();
        }
        public VuelosEcoJet ObtenerVuelo(int idVuelo)
        {
            return lVuelosEcoJet.Where(s => s.IdVuelo == idVuelo).FirstOrDefault();
        }

    }
}
