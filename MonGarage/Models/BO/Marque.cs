using System.ComponentModel.DataAnnotations;

namespace MonGarage.Models
{
    public class Marque
    {
        [Key, Required]
        public string Sigle { get; set; }
        [Required]
        public string NomComplet { get; set; }
    }
}