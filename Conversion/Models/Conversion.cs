using System.ComponentModel.DataAnnotations;

namespace Conversion.Models
{
    public class Conversion
    {
        [Required(ErrorMessage = "Champs requis !")]
        public string? InitialMetric { get; set; }
        [Required(ErrorMessage = "Champs requis !")]
        public int? InitialValue { get; set; }

        public string? FinalMetric { get; set; }

        public int? FinalValue { get; set; }
    }

}
