using LotoCharts.Domain.Entities.Models;


namespace LotoCharts.Domain.Entities.DTOs
{
       public class LotoFacilDTO
    {
        
        public int Id { get; internal set; }
        public int Concurso { get; set; }
        public string Data { get; set; }
        public int Casa_1 { get; set; }
        public int Casa_2 { get; set; }
        public int Casa_3 { get; set; }
        public int Casa_4 { get; set; }
        public int Casa_5 { get; set; }
        public int Casa_6 { get; set; }
        public int Casa_7 { get; set; }
        public int Casa_8 { get; set; }
        public int Casa_9 { get; set; }
        public int Casa_10 { get; set; }
        public int Casa_11 { get; set; }
        public int Casa_12 { get; set; }
        public int Casa_13 { get; set; }
        public int Casa_14 { get; set; }
        public int Casa_15 { get; set; }
        public LotoFacilDTO()
        {
        }
        public LotoFacilDTO(LotoFacil entity)
        {
            Concurso = entity.Concurso;
            Data = entity.Data;
            Casa_1 = entity.Casa_1;
            Casa_2 = entity.Casa_2;
            Casa_3 = entity.Casa_3;
            Casa_4 = entity.Casa_4;
            Casa_5 = entity.Casa_5;
            Casa_6 = entity.Casa_6;
            Casa_7 = entity.Casa_7;
            Casa_8 = entity.Casa_8;
            Casa_9 = entity.Casa_9;
            Casa_10 = entity.Casa_10;
            Casa_11 = entity.Casa_11;
            Casa_12 = entity.Casa_12;
            Casa_13 = entity.Casa_13;
            Casa_14 = entity.Casa_14;
            Casa_15 = entity.Casa_15;
        }

        public LotoFacilDTO(int numero, string dataApuracao)
        {
            this.Id = numero;
            this.Concurso = numero;
            this.Data = dataApuracao;
        }
    }

}