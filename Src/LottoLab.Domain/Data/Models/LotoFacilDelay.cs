using LottoLab.Domain.Data.DTO;

namespace LottoLab.Domain.Data.Models
{

    /*

    Classe responsavel pelos numeros mais atrazados em relaçao ao concurso atual

    */
    public class LotoFacilDelay
    {
        public int Id { get; internal set; }
        public int Concurso { get; set; }
        public string Data { get; set; }
        public int N1 { get; set; }
        public int N2 { get; set; }
        public int N3 { get; set; }
        public int N4 { get; set; }
        public int N5 { get; set; }
        public int N6 { get; set; }
        public int N7 { get; set; }
        public int N8 { get; set; }
        public int N9 { get; set; }
        public int N10 { get; set; }
        public int N11 { get; set; }
        public int N12 { get; set; }
        public int N13 { get; set; }
        public int N14 { get; set; }
        public int N15 { get; set; }
        public int N16 { get; set; }
        public int N17 { get; set; }
        public int N18 { get; set; }
        public int N19 { get; set; }
        public int N20 { get; set; }
        public int N21 { get; set; }
        public int N22 { get; set; }
        public int N23 { get; set; }
        public int N24 { get; set; }
        public int N25 { get; set; }
        public LotoFacilDelay()
        {
            
        }
        public LotoFacilDelay(LotoFacilDelayDTO entity)
        {
         Id = entity.Id;
         Concurso = entity.Concurso;
         Data =entity.Data;
         N1 =entity.N1;
         N2 =entity.N2;
         N3 =entity.N3;
         N4 =entity.N4;
         N5 =entity.N5;
         N6 =entity.N6;
         N7 =entity.N7;
         N8 =entity.N8;
         N9 =entity.N9;
         N10 =entity.N10;
         N11 =entity.N11;
         N12 =entity.N12;
         N13 =entity.N13;
         N14 =entity.N14;
         N15 =entity.N15;
         N16 =entity.N16;
         N17 =entity.N17;
         N18 =entity.N18;
         N19 =entity.N19;
         N20 =entity.N20;
         N21 =entity.N21;
         N22 =entity.N22;
         N23 =entity.N23;
         N24 =entity.N24;
         N25 =entity.N25;
            
        }
    }
    
}


/*

using System;

namespace LottoLab.Domain.Data.Models
{
    public class LotoFacilDelay
    {
        public int Id { get; set; }
        public int Concurso { get; set; }
        public string Data { get; set; }
        public int[] Numeros { get; set; }

        public LotoFacilDelay()
        {
            Numeros = new int[25];
        }

        public LotoFacilDelay(int id, int concurso, DateTime data, int[] numeros)
        {
            Id = id;
            Concurso = concurso;
            Data = data;
            Numeros = numeros;
        }
    }
}


*/