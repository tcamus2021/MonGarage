using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MonGarage.Models
{
    public class Voiture
    {
        [Key, Required]
        public int IdVoiture { get; set; }
        [Required]
        public virtual Marque Marque { get; set; }
        [Required]
        public string Model { get; set; }
    }
}