using LottoLab.Domain.Data.Enums;

namespace LottoLab.Domain.Data.Models
{
    public class EmailTo
    {
         public string Destination { get; set; } = string.Empty;
        public string Name { get; set; } = string.Empty;
        public string Subject { get; set; } = string.Empty;
        public string Message { get; set; }
        public EmailType Type { get; set; }
        public IDictionary<string, string> Parameters { get; set; }
        public EmailTo(){}
        public EmailTo(string Name, string Destination, string Subject, IDictionary<string, string> Parameters, EmailType type, string Message)
        {
            this.Name = Name;
            this.Destination = Destination;
            this.Subject = Subject;
            this.Parameters = Parameters;
            this.Type = type;
            this.Message = Message;
        }

    }
}