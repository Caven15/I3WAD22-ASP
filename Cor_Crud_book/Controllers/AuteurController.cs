using Cor_Crud_book.FakeDb;
using Cor_Crud_book.Models;
using Microsoft.AspNetCore.Mvc;

namespace Cor_Crud_book.Controllers
{
    public class AuteurController : Controller
    {
        public IActionResult Index()
        {
            return View(AuteurDb.GetAll());
        }

        [HttpGet] // facultatif etant donner qu'il est generer par default
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Auteur form)
        {
            if (ModelState.IsValid)
            {
                Auteur newA = new Auteur
                {
                    Nom = form.Nom,
                    Prenom = form.Prenom,
                    DateNaissance = form.DateNaissance
                };
                AuteurDb.Ajouter(newA);
                return RedirectToAction("index");
            }
            else
            {
                return View(form);
            }
        }

        public IActionResult Detail(int id)
        {
            Auteur select = AuteurDb.GetById(id);
            return View(select);
        }
    }
}
