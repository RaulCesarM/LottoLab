using LotoCharts.Domain.Entities.Models;
using Newtonsoft.Json;
namespace LotoCharts.Domain.Entities.DTOs
{
    public class LotoFacilDTO
    {
        public int Id { get; internal set; }
        [JsonProperty("numero")]
        public int Concurso { get; set; }
        [JsonProperty("dataApuracao")]
        public string Data { get; set; }
        [JsonProperty("dezenasSorteadasOrdemSorteio[0]")]
        public int Casa_01 { get; set; }
        [JsonProperty("dezenasSorteadasOrdemSorteio[1]")]
        public int Casa_02 { get; set; }
        [JsonProperty("dezenasSorteadasOrdemSorteio[2]")]
        public int Casa_03 { get; set; }
        [JsonProperty("dezenasSorteadasOrdemSorteio[3]")]
        public int Casa_04 { get; set; }
        [JsonProperty("dezenasSorteadasOrdemSorteio[4]")]
        public int Casa_05 { get; set; }
        [JsonProperty("dezenasSorteadasOrdemSorteio[5]")]
        public int Casa_06 { get; set; }
        [JsonProperty("dezenasSorteadasOrdemSorteio[6]")]
        public int Casa_07 { get; set; }
        [JsonProperty("dezenasSorteadasOrdemSorteio[7]")]
        public int Casa_08 { get; set; }
        [JsonProperty("dezenasSorteadasOrdemSorteio[8]")]
        public int Casa_09 { get; set; }
        [JsonProperty("dezenasSorteadasOrdemSorteio[9]")]
        public int Casa_10 { get; set; }
        [JsonProperty("dezenasSorteadasOrdemSorteio[10]")]
        public int Casa_11 { get; set; }
        [JsonProperty("dezenasSorteadasOrdemSorteio[11]")]
        public int Casa_12 { get; set; }
        [JsonProperty("dezenasSorteadasOrdemSorteio[12]")]
        public int Casa_13 { get; set; }
        [JsonProperty("dezenasSorteadasOrdemSorteio[13]")]
        public int Casa_14 { get; set; }
        [JsonProperty("dezenasSorteadasOrdemSorteio[14]")]
        public int Casa_15 { get; set; }
        public LotoFacilDTO()
        {
        }
        public LotoFacilDTO(LotoFacil entity)
        {
            Concurso = entity.Concurso;
            Data = entity.Data;
            Casa_01 = entity.Casa_01;
            Casa_02 = entity.Casa_02;
            Casa_03 = entity.Casa_03;
            Casa_04 = entity.Casa_04;
            Casa_05 = entity.Casa_05;
            Casa_06 = entity.Casa_06;
            Casa_07 = entity.Casa_07;
            Casa_08 = entity.Casa_08;
            Casa_09 = entity.Casa_09;
            Casa_10 = entity.Casa_10;
            Casa_11 = entity.Casa_11;
            Casa_12 = entity.Casa_12;
            Casa_13 = entity.Casa_13;
            Casa_14 = entity.Casa_14;
            Casa_15 = entity.Casa_15;
        }
        public LotoFacilDTO(int concurso, string data, int casa_01, int casa_02, int casa_03, int casa_04, int casa_05, int casa_06, int casa_07, int casa_08, int casa_09, int casa_10, int casa_11, int casa_12, int casa_13, int casa_14, int casa_15)
        {
            Concurso = concurso;
            Data = data;
            Casa_01 = casa_01;
            Casa_02 = casa_02;
            Casa_03 = casa_03;
            Casa_04 = casa_04;
            Casa_05 = casa_05;
            Casa_06 = casa_06;
            Casa_07 = casa_07;
            Casa_08 = casa_08;
            Casa_09 = casa_09;
            Casa_10 = casa_10;
            Casa_11 = casa_11;
            Casa_12 = casa_12;
            Casa_13 = casa_13;
            Casa_14 = casa_14;
            Casa_15 = casa_15;
        }
    }
}