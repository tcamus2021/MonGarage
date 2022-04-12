using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MonGarage.Models
{
    public class Fiche
    {
        [Key, Required]
        public int IdFiche { get; set; }
        [Required]
        public virtual Client Client { get; set; }
        [Required]
        public virtual Voiture Voiture { get; set; }
        [Required]
        public double Prix { get; set; }
    }
}