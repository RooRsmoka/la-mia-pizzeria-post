using Microsoft.AspNetCore.Mvc;
using la_mia_pizzeria_static.Models;

namespace la_mia_pizzeria_static.Controllers
{
    public class PizzaController : Controller
    {
        public static ListaPizze pizze;
        public IActionResult Index()
        {
            pizze = new ListaPizze();
                
            Pizza pizzaOne = new Pizza("Pizza Marinara", "Ingredienti: Pomodoro, Origano, Aglio, Basilico", "img/Marinara.jpg", 4.50);
            Pizza pizzaTwo = new Pizza("Pizza Margherita", "Ingredienti: Pomodoro, Mozzarella,Basilico", "img/Margherita.jpg", 5.00);
            Pizza pizzaThree = new Pizza("Pizza Cotto&Funghi", "Ingredienti: Pomodoro, Mozzarella, Prosc. Cotto, Funghi Porcini", "img/Cotto&Funghi.jpg", 6.00);
            Pizza pizzaFour = new Pizza("Pizza Quattro Formaggi", "Ingredienti: Pomodoro, Mozzarella, Fontina, Gorgonzola, Parmigiano Reggiano", "img/QuattroFormaggi.jpg", 6.50);
            Pizza pizzaFive = new Pizza("Pizza Salame", "Ingredienti: Pomodoro, Mozzarella, Salame Milano", "img/Salame.jpg", 5.50);


            return View();
        }

        public IActionResult ShowPizze()
        {
            return View("ShowPizze");
        }
    }
}
