using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirportMonitor.VuelosAPI.AmaszomasAPI
{
    public class VuelosAmasZonas
    {
        public int IdVuelo { get; set; }
        public DateTime Hora { get; set; }
        public string Compania { get; set; }
        public string Origen { get; set; }
        public string Destino { get; set; }
        public Tipo Tipo { get; set; }
        public int Puerta { get; set; }
        public string Observacion { get; set; }
    }
}
