using System.ComponentModel.DataAnnotations;

namespace CarServiceEstimator.Models
{
    public class Client
    {
        [Key]
        public Guid IdClient { get; set; }
        [MaxLength]
        public string NumeClient { get; set; } = string.Empty;
        [Phone]
        public string NrTelefon { get; set; } = string.Empty;
        [MaxLength]
        public string Adresa { get; set; } = string.Empty;
        public ICollection<Deviz> Devize { get; set; } = new List<Deviz>();
    }
}
