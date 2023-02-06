
using External.Domain.Entities.DTOs;
using External.Domain.Entities.Models;
using External.Domain.Interfaces.IRepository;
using External.Domain.Interfaces.IServices;

namespace External.Domain.Services
{
    public class LotoFacilServices : ILotoFacilService
    {
        private readonly ILotoFacilRepository _lotoRepository;
        public LotoFacilServices(ILotoFacilRepository lotoRepository)
        {
            _lotoRepository = lotoRepository;
        }

        public LotoFacilDTO GetById(int id)
        {
            return new LotoFacilDTO(_lotoRepository.GetById(id));

        }

        public LotoFacilDTO GetFirst()
        {
            return new LotoFacilDTO(_lotoRepository.GetFirst());
        }

        public LotoFacilDTO GetLast()
        {
            return new LotoFacilDTO(_lotoRepository.GetLast());
        }

        public void Insert(LotoFacilDTO raffle)
        {
            var Raffle = new LotoFacil
            {

                Concurso = raffle.Concurso,
                Data = raffle.Data,
                Casa_01 = raffle.Casa_01,
                Casa_02 = raffle.Casa_02,
                Casa_03 = raffle.Casa_03,
                Casa_04 = raffle.Casa_04,
                Casa_05 = raffle.Casa_05,
                Casa_06 = raffle.Casa_06,
                Casa_07 = raffle.Casa_07,
                Casa_08 = raffle.Casa_08,
                Casa_09 = raffle.Casa_09,
                Casa_10 = raffle.Casa_10,
                Casa_11 = raffle.Casa_11,
                Casa_12 = raffle.Casa_12,
                Casa_13 = raffle.Casa_13,
                Casa_14 = raffle.Casa_14,
                Casa_15 = raffle.Casa_15,
            };
            _lotoRepository.Insert(Raffle);
        }
        public void Remove(LotoFacilDTO entity)
        {
            throw new NotImplementedException();
        }



        public void Update(LotoFacilDTO entity)
        {
            throw new NotImplementedException();
        }
    }
}