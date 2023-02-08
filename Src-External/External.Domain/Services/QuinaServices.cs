using External.Domain.Entities.DTOs;
using External.Domain.Entities.Models;
using External.Domain.Interfaces.IRepository;
using External.Domain.Interfaces.IServices;
namespace External.Domain.Services
{
    public class QuinaServices :IQuinaService
    {
        private readonly IQuinaRepository _QuinaRepository;
        public QuinaServices(IQuinaRepository QuinaRepository)
        {
            _QuinaRepository = QuinaRepository;
        }
        public QuinaDTO GetById(int id)
        {
            return new QuinaDTO(_QuinaRepository.GetById(id));
        }
        public QuinaDTO GetFirst()
        {
            return new QuinaDTO(_QuinaRepository.GetFirst());
        }
        public QuinaDTO GetLast()
        {
            return new QuinaDTO(_QuinaRepository.GetLast());
        }
        public void Insert(QuinaDTO raffle)
        {
            var Raffle = new Quina(raffle);
            _QuinaRepository.Insert(Raffle);
        }
    }
}