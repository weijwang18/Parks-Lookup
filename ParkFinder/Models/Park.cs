using System.ComponentModel.DataAnnotations;

namespace ParkFinder.Models
{
    public class Park
    {
        public int ParkId { get; set; }
        [Required]
        [StringLength(30)]
        public string Name { get; set; }
        [Required]
        public string State { get; set; }
    }
}ç