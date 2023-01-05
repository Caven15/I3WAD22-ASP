using Cor_Crud_book.Models;
using System.Collections.Generic;
using System.Linq;

namespace Cor_Crud_book.FakeDb
{
    public static class LivreDB
    {
        public static List<Livre> Livres { get; set; } = new List<Livre>();
        private static int _currentId = 0;

        #region C.R.U.D
        // Create
        public static void Ajouter(Livre l)
        {
            l.Id = ++_currentId;
            Livres.Add(l);
        }

        // Read
        public static Livre GetById(int id)
        {
            return Livres.FirstOrDefault(livre => livre.Id == id);
        }

        public static List<Livre> GetAll()
        {
            return Livres;
        }

        // Update 
        public static void Update(Livre livre)
        {
            Livres.Remove(livre);
            Ajouter(livre);
        }

        // Delete
        public static void Delete(int id)
        {
            Livre Todel = GetById(id);
            Livres.Remove(Todel);
        }
        #endregion

    }
}
