using Cor_Crud_book.Models;
using System.Collections.Generic;
using System.Linq;

namespace Cor_Crud_book.FakeDb
{
    public static class AuteurDb
    {
        public static List<Auteur> auteurs { get; set; } = new List<Auteur>();

        private static int _currentId = 1; 

        // CRUD

        // Create 
        public static void Ajouter(Auteur a)
        {
            a.Id = _currentId++;
            auteurs.Add(a);
        }

        // Read

        // getById
        public static Auteur GetById(int id)
        {
            Auteur AuteurFind = auteurs.FirstOrDefault(a => a.Id == id);
            return AuteurFind;
        }

        //GetByName
        public static Auteur GetByName(string name)
        {
            Auteur AuteurFind = auteurs.FirstOrDefault(item => item.Prenom == name);
            return AuteurFind;
        }

        // getAll
        public static List<Auteur> GetAll()
        {
            return auteurs;
        }


        // Delete
        public static void Delete(int id)
        {
            Auteur toDel = GetById(id);
            auteurs.Remove(toDel);
        }

        // Update
        public static void Update(Auteur a)
        {
            Delete(a.Id);
            Ajouter(a);
        }
    }
}
