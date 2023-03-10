using LottoLab.Domain.Data.DTO;
using LottoLab.Domain.Data.Models;
using LottoLab.Domain.Interfaces.Common;
using Newtonsoft.Json;

namespace LottoLab.Lib.Worker.Services
{
    public class SupplyLotoFacil : ISupplyLotoFacil
    {
        private readonly ILotoFacilService _Service;
        private readonly string _url;
        static readonly HttpClient Client = new HttpClient { MaxResponseContentBufferSize = 1_000_000 };
        public SupplyLotoFacil()
        {
        }
        public SupplyLotoFacil(ILotoFacilService service, IConfiguration configuration)
        {
            _Service = service;
            _url = configuration.GetSection("LotofacilApi")["Url"];
        }
        public async Task<int> CheckLast()
        {
            var lastWeb = await Client.GetStringAsync(_url);
            dynamic lastRaffleWebObj = JsonConvert.DeserializeObject(lastWeb);
            int lastRaffleWEB = lastRaffleWebObj.numero;
            int lastRaffleDB = _Service.GetLast();
            if (lastRaffleDB < lastRaffleWEB)
            {
                lastRaffleDB++;
                await Feed(lastRaffleDB);
            }
            else
            {
                Console.WriteLine("Banco atualizado");
            }
            return lastRaffleDB;
        }
        public async Task Feed(int lastDB)
        {
            var result = await Client.GetStringAsync($"{_url}/{lastDB}");
            var obj = JsonConvert.DeserializeObject<LoteriaJson>(result);
            var raffle = new LotoFacilDTO(obj.Numero, obj.DataApuracao);
            for (var i = 0; i < 15; i++)
            {
                var J = i + 1;
                var casa = obj.DezenasSorteadasOrdemSorteio[i];
                raffle.GetType().GetProperty("Casa_" + J).SetValue(raffle, casa);
            }
            _Service.Insert(raffle);
        }
    }
}