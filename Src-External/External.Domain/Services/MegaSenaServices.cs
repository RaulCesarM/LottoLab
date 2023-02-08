using External.Domain.Entities.DTOs;
using External.Domain.Entities.Models;
using External.Domain.Interfaces.IRepository;
using External.Domain.Interfaces.IServices;
namespace External.Domain.Services
{
    public class MegaSenaServices : IMegaSenaService
    {
        private readonly IMegaSenaRepository _MegaRepository;
        public MegaSenaServices(IMegaSenaRepository MegaRepository)
        {
            _MegaRepository = MegaRepository;
        }
        public MegaSenaDTO GetById(int id)
        {
            return new MegaSenaDTO(_MegaRepository.GetById(id));
        }
        public MegaSenaDTO GetFirst()
        {
            return new MegaSenaDTO(_MegaRepository.GetFirst());
        }
        public MegaSenaDTO GetLast()
        {
            return new MegaSenaDTO(_MegaRepository.GetLast());
        }
        public void Insert(MegaSenaDTO raffle)
        {
            var Raffle = new MegaSena(raffle);
           
            _MegaRepository.Insert(Raffle);
        }
    }
}