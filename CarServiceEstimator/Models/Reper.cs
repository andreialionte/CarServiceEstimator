using System.ComponentModel.DataAnnotations;

namespace CarServiceEstimator.Models
{
    public class Reper
    {
        [Key]
        public Guid IdReper { get; set; }
        [MaxLength]
        public string DenumireReper { get; set; } = string.Empty;
        [MaxLength]
        public string UM { get; set; } = string.Empty; // Unitatea de măsură (ex: "buc", "litri")
        public decimal PretUnitar { get; set; }
        [MaxLength]
        public string SpImagine { get; set; } = string.Empty; // URL către imagine

        // Relational property
        public ICollection<DevizContinut> DevizeContinut { get; set; } = new List<DevizContinut>();
    }
}
