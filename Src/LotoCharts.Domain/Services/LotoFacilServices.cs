
using LotoCharts.Domain.Entities.Models;
using LotoCharts.Domain.Interfaces.IRepository;
using LotoCharts.Domain.Interfaces.IServices;

namespace LotoCharts.Domain.Services
{
    public class LotoFacilServices : ILotoFacilService
    {
        private readonly ILotoFacilRepository _lotoRepository;
        public LotoFacilServices(ILotoFacilRepository lotoRepository)
        {
            _lotoRepository = lotoRepository;
        }

        public void Insert(SorteioDTO entity)
        {
            throw new NotImplementedException();
        }

        public int SalvarSorteio(SorteioDTO sorteio)
        {
            var sort = new Sorteio
            {

                Concurso = sorteio.Concurso,
                Data = sorteio.Data,
                Casa_01 = sorteio.Casa_01,
                Casa_02 = sorteio.Casa_02,
                Casa_03 = sorteio.Casa_03,
                Casa_04 = sorteio.Casa_04,
                Casa_05 = sorteio.Casa_05,
                Casa_06 = sorteio.Casa_06,
                Casa_07 = sorteio.Casa_07,
                Casa_08 = sorteio.Casa_08,
                Casa_09 = sorteio.Casa_09,
                Casa_10 = sorteio.Casa_10,
                Casa_11 = sorteio.Casa_11,
                Casa_12 = sorteio.Casa_12,
                Casa_13 = sorteio.Casa_13,
                Casa_14 = sorteio.Casa_14,
                Casa_15 = sorteio.Casa_15,

            };

            _lotoRepository.SalvarSorteio(sort);

            return sorteio.Casa_01;
        }

        public void Update(SorteioDTO entity, int id)
        {
            throw new NotImplementedException();
        }
    }
}