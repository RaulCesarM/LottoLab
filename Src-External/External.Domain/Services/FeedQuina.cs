using External.Domain.Entities.DTOs;
using External.Domain.Interfaces.IRepository;
using External.Domain.Interfaces.IServices;
using Newtonsoft.Json;

namespace External.Domain.Services
{
    public class FeedQuina : IQuinaFeedService
    {
        private readonly IQuinaService _QuinaSevice;
        private readonly IQuinaRepository _QuinaRepository;

        private readonly String URL = "https://servicebus2.caixa.gov.br/portaldeloterias/api/Quina";
        static readonly HttpClient Client = new HttpClient
        {
            MaxResponseContentBufferSize = 1_000_000
        };
        public FeedQuina(IQuinaService QuinaSevice,IQuinaRepository QuinaRepository )
        {
            _QuinaSevice = QuinaSevice;
            _QuinaRepository = QuinaRepository;

        }
        public async Task<int> CheckLast()
        {
            if (_QuinaRepository.GetLast() == null)
            {

                Update(1).Wait(1000);
                return 1;
            }
            else
            {
                var DB = _QuinaRepository.GetLast();
                var Last_db = DB.Concurso;
                Last_db++;
                string LastResult = await Client.GetStringAsync(URL);
                dynamic LastObj = JsonConvert.DeserializeObject(LastResult);

                int Last_C = LastObj.numero;

                while (Last_db < Last_C)
                {
                    Update(Last_db).Wait(1000);
                    Last_db++;

                }
                var result = _QuinaRepository.GetLast();
                return result.Concurso;
            }

        }

        public async Task<int> Update(int Last_db)
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
            
            var raffle = new QuinaDTO(concurso, data, casa_01, casa_02, casa_03, casa_04, casa_05);
            _QuinaSevice.Insert(raffle);
            return raffle.Concurso;
        }
    }
}