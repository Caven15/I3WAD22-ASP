using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Demo_crud.Models
{
    public class Utilisateur
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Le champs 'Nom' est obligatoire")]
        public string Nom { get; set; }
    }
}
