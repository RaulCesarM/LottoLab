using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LotoCharts.Domain.Entities.Models
{
    public class Quina
    {

        public int Id { get; internal set; }
        public int Concurso { get; set; }
        public string Data { get; set; }
        public int Casa_01 { get; set; }
        public int Casa_02 { get; set; }
        public int Casa_03 { get; set; }
        public int Casa_04 { get; set; }
        public int Casa_05 { get; set; }

        public Quina()
        {
            
        }
    }
}