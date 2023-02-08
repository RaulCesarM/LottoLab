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
            var Raffle = new LotoFacil(raffle);
           
            _lotoRepository.Insert(Raffle);
        }
    }
}