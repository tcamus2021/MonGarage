using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MonGarage.Models
{
    public class Client
    {
        [Key, Required]
        public int IdClient { get; set; }
        [Required]
        public string Nom { get; set; }
        [Required]
        public string Numero { get; set; } 
    }
}