using AirportMonitor.VuelosAPI.AmaszomasAPI;
using AirportMonitor.VuelosAPI.BoaApi;
using AirportMonitor.VuelosAPI.EcoJetAPI;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirportMonitor.Facade
{
    public class FacadeVuelosApi
    {
        BoaAPI boaAPI;
        AmaszomasAPI amaszomasAPI;
        EcoJetAPI ecoJetAPI;
        public FacadeVuelosApi()
        {
            boaAPI = new BoaAPI();
            amaszomasAPI = new AmaszomasAPI();
            ecoJetAPI = new EcoJetAPI();
        }
        public List<Vuelo> ListarVuelosLlegada()
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<VuelosBoa, Vuelo>();
                cfg.CreateMap<VuelosAmasZonas, Vuelo>();
                cfg.CreateMap<VuelosEcoJet, Vuelo>();
            });
            var mapper = new Mapper(config);
            List<Vuelo> vuelosBoa = mapper.Map<List<VuelosBoa>, List<Vuelo>>(boaAPI.ListarLlegadas());
            List<Vuelo> vuelosAmaszonas = mapper.Map<List<VuelosAmasZonas>, List<Vuelo>>(amaszomasAPI.ObtenerLlegadas());
            List<Vuelo> vuelosEcoJet = mapper.Map<List<VuelosEcoJet>, List<Vuelo>>(ecoJetAPI.VuelosLlegadas());

            List<Vuelo> ListarVuelosLlegada = new List<Vuelo>();
            ListarVuelosLlegada.AddRange(vuelosBoa);
            ListarVuelosLlegada.AddRange(vuelosAmaszonas);
            ListarVuelosLlegada.AddRange(vuelosEcoJet);

            return ListarVuelosLlegada.OrderBy(o => o.Hora).ToList();
        }
        public List<Vuelo> ListarVuelosSalida()
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<VuelosBoa, Vuelo>();
                cfg.CreateMap<VuelosAmasZonas, Vuelo>();
                cfg.CreateMap<VuelosEcoJet, Vuelo>();
            });
            var mapper = new Mapper(config);
            List<Vuelo> vuelosBoa = mapper.Map<List<VuelosBoa>, List<Vuelo>>(boaAPI.ListarSalidas());
            List<Vuelo> vuelosAmaszonas = mapper.Map<List<VuelosAmasZonas>, List<Vuelo>>(amaszomasAPI.ObtenerSalidas());
            List<Vuelo> vuelosEcoJet = mapper.Map<List<VuelosEcoJet>, List<Vuelo>>(ecoJetAPI.VuelosSalidas());

            List<Vuelo> ListarVuelosLlegada = new List<Vuelo>();
            ListarVuelosLlegada.AddRange(vuelosBoa);
            ListarVuelosLlegada.AddRange(vuelosAmaszonas);
            ListarVuelosLlegada.AddRange(vuelosEcoJet);

            return ListarVuelosLlegada.OrderBy(o => o.Hora).ToList();
        }
        public Vuelo ObtenerVuelo(int idVuelo)
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<VuelosBoa, Vuelo>();
                cfg.CreateMap<VuelosAmasZonas, Vuelo>();
                cfg.CreateMap<VuelosEcoJet, Vuelo>();
            });
            var mapper = new Mapper(config);
            if (boaAPI.ObtenerVuelo(idVuelo) != null)
                return mapper.Map<VuelosBoa, Vuelo>(boaAPI.ObtenerVuelo(idVuelo));
            if (amaszomasAPI.ObtenerVuelo(idVuelo) != null)
                return mapper.Map<VuelosAmasZonas, Vuelo>(amaszomasAPI.ObtenerVuelo(idVuelo));
            if (ecoJetAPI.ObtenerVuelo(idVuelo) != null)
                return mapper.Map<VuelosEcoJet, Vuelo>(ecoJetAPI.ObtenerVuelo(idVuelo));

            return null;
        }
    }
}
