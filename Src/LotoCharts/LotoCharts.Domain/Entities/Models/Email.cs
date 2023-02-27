namespace LotoCharts.Domain.Entities.Models
{
    public class Email
    {
         public string To { get; set; } = string.Empty;
        public string Subject { get; set; } = string.Empty;
        public IDictionary<string , string> Parameters { get; set; } 
        public EmailType type { get; set; }
    }
}