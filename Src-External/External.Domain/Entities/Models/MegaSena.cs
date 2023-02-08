using External.Domain.Entities.DTOs;
using Newtonsoft.Json;
namespace External.Domain.Entities.Models
{
    public class MegaSena
    {
        public int Id { get; internal set; }
        
        public int Concurso { get; set; }
        
        public string Data { get; set; }
        
        public int Casa_01 { get; set; }
        
        public int Casa_02 { get; set; }
        
        public int Casa_03 { get; set; }
        
        public int Casa_04 { get; set; }
        
        public int Casa_05 { get; set; }
        
        public int Casa_06 { get; set; }
        public MegaSena()
        {
        }
        public MegaSena(MegaSenaDTO entity)
        {
            Concurso = entity.Concurso;
            Data = entity.Data;
            Casa_01 = entity.Casa_01;
            Casa_02 = entity.Casa_02;
            Casa_03 = entity.Casa_03;
            Casa_04 = entity.Casa_04;
            Casa_05 = entity.Casa_05;
            Casa_06 = entity.Casa_06;
        }
        public MegaSena(int concurso, string data, int casa_01, int casa_02, int casa_03, int casa_04, int casa_05, int casa_06)
        {
            Concurso = concurso;
            Data = data;
            Casa_01 = casa_01;
            Casa_02 = casa_02;
            Casa_03 = casa_03;
            Casa_04 = casa_04;
            Casa_05 = casa_05;
            Casa_06 = casa_06;
        }
    }
}