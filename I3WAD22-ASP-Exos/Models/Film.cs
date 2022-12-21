using Microsoft.AspNetCore.Identity;

namespace I3WAD22_ASP_Exos.Models
{
    public class Film
    {
        private string _Titre { get; set; }
        private string _Link_img { get; set; }

        public string Titre
        {
            get { return _Titre; }
            set { _Titre = value; }
        }

        public string Link_img
        {
            get { return _Link_img; }
            set { _Link_img = value; }
        }

        /// <summary>
        /// Méthode me permetant de créer un nouvel objet de type film
        /// </summary>
        /// <param name="titre">Titre du film</param>
        /// <param name="link_img">chemain de l'image du film</param>
        public Film(string titre, string link_img)
        {
            Titre = titre;
            Link_img = link_img;
        }
    }
}