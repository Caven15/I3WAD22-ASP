using Demo_crud.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Demo_crud.FakeDB
{
    public class UtilisateurDb
    {
        public static List<Utilisateur> utilisateurs { get; set; } = new List<Utilisateur>();

        private static int _currentId = 0;

        // Create
        public static void ajouter(Utilisateur user)
        {
            user.Id = ++_currentId;
            utilisateurs.Add(user);
        }

        // GetOne => read
        public static Utilisateur GetById(int id)
        {
            return utilisateurs.FirstOrDefault(item => item.Id == id);
        }

        // GetAll
        public static List<Utilisateur> GetAll()
        {
            return utilisateurs;
        }

        // Update 

        // Delete

    }
}
