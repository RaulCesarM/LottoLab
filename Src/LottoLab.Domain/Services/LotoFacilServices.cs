
using LottoLab.Domain.Data.DTO;
using LottoLab.Domain.Data.Models;
using LottoLab.Domain.Interfaces.Common;

namespace LottoLab.Domain.Services
{
    public class LotoFacilServices : ILotoFacilService
    {
        private readonly ILotoFacilRepository _Repository;
        public LotoFacilServices(ILotoFacilRepository Repository)
        {
            _Repository = Repository;
        }
        public LotoFacilDTO GetById(int id)
        {
            return new LotoFacilDTO(_Repository.GetById(id));
        }
        public int GetFirst()
        {
            return _Repository.GetFirst();
        }
        public int GetLast()
        {
            return _Repository.GetLast();
        }
        public void Insert(LotoFacilDTO entity)
        {
            var lotoFacil = new LotoFacil(entity);
            _Repository.Insert(lotoFacil);
        }
    }
}