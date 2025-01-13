using System.ComponentModel.DataAnnotations;

namespace CarServiceEstimator.Models
{
    public class Deviz
    {
        [Key]
        public Guid IdDeviz { get; set; }
        [MaxLength]
        public string DenumireDeviz { get; set; } = string.Empty;
        public DateTime DataDeviz { get; set; }
        public Guid IdClient { get; set; }
        public Client Client { get; set; } = null!;
        [MaxLength]
        public string MarcaModel { get; set; } = string.Empty; // Marca și modelul mașinii
        [MaxLength]
        public string NrInmatriculare { get; set; } = string.Empty;

        public ICollection<DevizContinut> DevizeContinut { get; set; } = new List<DevizContinut>();
    }
}
