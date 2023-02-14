using External.Domain.Entities.DTOs;
using External.Domain.Interfaces.IRepository;
using External.Domain.Interfaces.IServices;
using Newtonsoft.Json;
namespace External.Domain.Services
{
    public class FeedLotoFacil : ILotoFacilFeedService
    {
        private readonly ILotoFacilService _lotoService;
        private readonly ILotoFacilRepository _lotoRepository;
        private readonly String URL = "https://servicebus2.caixa.gov.br/portaldeloterias/api/lotofacil";
        static readonly HttpClient Client = new HttpClient
        {
            MaxResponseContentBufferSize = 1_000_000
        };
        public FeedLotoFacil(ILotoFacilRepository lotoRepository, ILotoFacilService lotoService)
        {
            _lotoRepository = lotoRepository;
            _lotoService = lotoService;
        }

        public FeedLotoFacil()
        {
        }

        public async Task CheckLast()
        {
          
                var DB = _lotoRepository.GetLast();
                var Last_db = DB.Concurso;
                Last_db++;
                string LastResult = await Client.GetStringAsync(URL);
                dynamic LastObj = JsonConvert.DeserializeObject(LastResult);

                int Last_C = LastObj.numero;

                while (Last_db < Last_C)
                {
                    string Result = await Client.GetStringAsync(URL + "/" + Last_db);
                    dynamic Obj = JsonConvert.DeserializeObject(Result);
                    int concurso = Obj.numero;
                    string data = Obj.dataApuracao;
                    int casa_01 = Obj.dezenasSorteadasOrdemSorteio[0];
                    int casa_02 = Obj.dezenasSorteadasOrdemSorteio[1];
                    int casa_03 = Obj.dezenasSorteadasOrdemSorteio[2];
                    int casa_04 = Obj.dezenasSorteadasOrdemSorteio[3];
                    int casa_05 = Obj.dezenasSorteadasOrdemSorteio[4];
                    int casa_06 = Obj.dezenasSorteadasOrdemSorteio[5];
                    int casa_07 = Obj.dezenasSorteadasOrdemSorteio[6];
                    int casa_08 = Obj.dezenasSorteadasOrdemSorteio[7];
                    int casa_09 = Obj.dezenasSorteadasOrdemSorteio[8];
                    int casa_10 = Obj.dezenasSorteadasOrdemSorteio[9];
                    int casa_11 = Obj.dezenasSorteadasOrdemSorteio[10];
                    int casa_12 = Obj.dezenasSorteadasOrdemSorteio[11];
                    int casa_13 = Obj.dezenasSorteadasOrdemSorteio[12];
                    int casa_14 = Obj.dezenasSorteadasOrdemSorteio[13];
                    int casa_15 = Obj.dezenasSorteadasOrdemSorteio[14];
                    var raffle = new LotoFacilDTO(concurso, data, casa_01, casa_02, casa_03, casa_04, casa_05, casa_06, casa_07, casa_08, casa_09, casa_10, casa_11, casa_12, casa_13, casa_14, casa_15);
                    _lotoService.Insert(raffle);

                    Last_db++;


                }
                var result = _lotoRepository.GetLast();
            Console.WriteLine(Last_C);
        }

        // }
        // public async Task<int> Update(int Last_db)
        // {
        //     Console.WriteLine(Last_db);
        //     string Result = await Client.GetStringAsync(URL + "/" + Last_db);
        //     dynamic Obj = JsonConvert.DeserializeObject(Result);
        //     int concurso = Obj.numero;
        //     string data = Obj.dataApuracao;
        //     int casa_01 = Obj.dezenasSorteadasOrdemSorteio[0];
        //     int casa_02 = Obj.dezenasSorteadasOrdemSorteio[1];
        //     int casa_03 = Obj.dezenasSorteadasOrdemSorteio[2];
        //     int casa_04 = Obj.dezenasSorteadasOrdemSorteio[3];
        //     int casa_05 = Obj.dezenasSorteadasOrdemSorteio[4];
        //     int casa_06 = Obj.dezenasSorteadasOrdemSorteio[5];
        //     int casa_07 = Obj.dezenasSorteadasOrdemSorteio[6];
        //     int casa_08 = Obj.dezenasSorteadasOrdemSorteio[7];
        //     int casa_09 = Obj.dezenasSorteadasOrdemSorteio[8];
        //     int casa_10 = Obj.dezenasSorteadasOrdemSorteio[9];
        //     int casa_11 = Obj.dezenasSorteadasOrdemSorteio[10];
        //     int casa_12 = Obj.dezenasSorteadasOrdemSorteio[11];
        //     int casa_13 = Obj.dezenasSorteadasOrdemSorteio[12];
        //     int casa_14 = Obj.dezenasSorteadasOrdemSorteio[13];
        //     int casa_15 = Obj.dezenasSorteadasOrdemSorteio[14];
        //     var raffle = new LotoFacilDTO(concurso, data, casa_01, casa_02, casa_03, casa_04, casa_05, casa_06, casa_07, casa_08, casa_09, casa_10, casa_11, casa_12, casa_13, casa_14, casa_15);
        //     _lotoService.Insert(raffle);
        //     return raffle.Concurso;
        // }
    }
}