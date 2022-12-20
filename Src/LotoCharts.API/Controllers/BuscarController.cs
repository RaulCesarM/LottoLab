using LotoCharts.Domain.Entities.Models;
using LotoCharts.Domain.Interfaces.IServices;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace LotoCharts.API.Controllers
{
    [ApiController]
    [Route("API/Consumo")]
    public class BuscarController : ControllerBase
    {
        private readonly ILotoFacilService _lotoService;
        public BuscarController(ILotoFacilService lotoService)
        {
            _lotoService = lotoService;
        }

        [HttpPost]
        public async Task<ActionResult<Sorteio>> SalvarConsumo()
        {
            int Concurso = 1;
            HttpClient cliente = new HttpClient();

            string ultimoResultado = await cliente.GetStringAsync("https://servicebus2.caixa.gov.br/portaldeloterias/api/lotofacil");
            dynamic ultimoObj = JsonConvert.DeserializeObject(ultimoResultado);
            int concursoAtual = ultimoObj.numero;

            while (Concurso < concursoAtual)
            {
                string resultado = await cliente.GetStringAsync("https://servicebus2.caixa.gov.br/portaldeloterias/api/lotofacil/" + Concurso);
                dynamic Obj = JsonConvert.DeserializeObject(resultado);
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

                var sorteioDTO = new SorteioDTO(concurso, data, casa_01, casa_02, casa_03, casa_04, casa_05, casa_06, casa_07, casa_08, casa_09, casa_10, casa_11, casa_12, casa_13, casa_14, casa_15);

                _lotoService.SalvarSorteio(sorteioDTO);
                Thread.Sleep(1000);
                Concurso++;

            }

            return Ok(concursoAtual);

        }

    }
}