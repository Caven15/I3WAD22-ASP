using Demo_crud.FakeDB;
using Demo_crud.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Demo_crud.Controllers
{
    public class UtilisateurController : Controller
    {
        [HttpGet] // DEFAULT
        public IActionResult Index()
        {

            return View(UtilisateurDb.GetAll());
        }

        [HttpGet] // DEFAULT
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Utilisateur form)
        {
            if (ModelState.IsValid)
            {
                Utilisateur newUtilisateur = new Utilisateur
                {
                    Nom = form.Nom
                };
                UtilisateurDb.ajouter(newUtilisateur);
                return RedirectToAction("Index");
            }

            return View(form);
        }
    }
}
