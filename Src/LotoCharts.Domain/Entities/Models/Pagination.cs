using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LotoCharts.Domain.Entities.Models
{
    public class Pagination
    {
        public Pagination(int take, int skip)
        {
            Take = take;
            Skip = skip;
        }

        public int Take { get; set; }
        public int Skip { get; set; }
    }
}