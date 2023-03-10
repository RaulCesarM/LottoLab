

namespace LottoLab.Domain.Data.Models
{
    public class LoteriaJson
    {
        public int Numero { get; set; }
        public string DataApuracao { get; set; }
        public List<int> DezenasSorteadasOrdemSorteio { get; set; }
    }
}