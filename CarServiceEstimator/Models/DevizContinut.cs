using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CarServiceEstimator.Models
{
    public class DevizContinut
    {
        [Key]
        public Guid IdDevizContinut { get; set; }
        [ForeignKey("Reper")]
        public Guid IdDeviz { get; set; }
        public Deviz? Deviz { get; set; }
        public int Nrc { get; set; }
        public Guid IdReper { get; set; }
        public Reper? Reper { get; set; }
        public decimal PretUnitar { get; set; }
        public int Cantitate { get; set; }

        // Relational properties
    }
}
