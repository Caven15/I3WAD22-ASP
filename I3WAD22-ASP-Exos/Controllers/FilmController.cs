using I3WAD22_ASP_Exos.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace I3WAD22_ASP_Exos.Controllers
{
    public class FilmController : Controller
    {
        public IActionResult Index()
        {
            FilmIndexViewModel model = new FilmIndexViewModel();
            model.Films = new List<Film>()
            {
                new Film("drop","./assets/PostersFilms/drop.jpg"),
                new Film("dungeons and dragons honor among thieves ver3","./assets/PostersFilms/dungeons_and_dragons_honor_among_thieves_ver3.jpg"),
                new Film("eighty for brady","./assets/PostersFilms/eighty_for_brady.jpg"),
                new Film("infinity pool","./assets/PostersFilms/infinity_pool.jpg"),
                new Film("la brigade ver2","./assets/PostersFilms/la_brigade_ver2.jpg"),
                new Film("night at the museum kahmunrah rises again ver2","./assets/PostersFilms/night_at_the_museum_kahmunrah_rises_again_ver2.jpg"),
                new Film("snow day","./assets/PostersFilms/snow_day.jpg"),
                new Film("this place rules","./assets/PostersFilms/this_place_rules.jpg")
            };
            return View(model);
        }
    }
}
