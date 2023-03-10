using LottoLab.Domain.Data.DTO;

namespace LottoLab.Domain.Data.Models
{
    public class LotoFacil
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
        public LotoFacil()
        {
        }
        public LotoFacil(LotoFacilDTO dto)
        {
            Concurso= dto.Concurso;
            Data =    dto.Data;
            Casa_1 = dto.Casa_1;
            Casa_2 = dto.Casa_2;
            Casa_3 = dto.Casa_3;
            Casa_4 = dto.Casa_4;
            Casa_5 = dto.Casa_5;
            Casa_6 = dto.Casa_6;
            Casa_7 = dto.Casa_7;
            Casa_8 = dto.Casa_8;
            Casa_9 = dto.Casa_9;
            Casa_10 = dto.Casa_10;
            Casa_11 = dto.Casa_11;
            Casa_12 = dto.Casa_12;
            Casa_13 = dto.Casa_13;
            Casa_14 = dto.Casa_14;
            Casa_15 = dto.Casa_15;
        }
       
    }
}