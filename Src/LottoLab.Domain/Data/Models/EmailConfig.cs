
namespace LottoLab.Domain.Data.Models
{
    public class EmailConfig
    {
        public string Name { get; set; }
        public string From { get; set; }
        public string Secret { get; set; }
        public EmailConfig( ){}
        public EmailConfig(string Name,string From, string Secret)
        {
            this.Name = Name;
            this.From = From;
            this.Secret = Secret;
        }
        
    }
}