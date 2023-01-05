using Microsoft.VisualBasic;
using System;

namespace Cor_Crud_book.Models
{
    public class Auteur
    {
        public int Id { get; set; }
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public DateTime DateNaissance { get; set; }
    }
}
