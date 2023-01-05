namespace Cor_Crud_book.Models
{
    public class Livre
    {
        public int Id { get; set; }

        public string Titre { get; set; }

        public string ISBN { get; set; }
        
        public int IdAuteur { get; set; }
    }

}
