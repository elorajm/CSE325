using Microsoft.AspNetCore.Mvc;

namespace PizzaAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PizzasController : ControllerBase
    {
        public record Pizza(int Id, string Name, bool IsGlutenFree);

        public static List<Pizza> Pizzas = new List<Pizza>
        {
            new Pizza(1, "Classic Italian", false),
            new Pizza(2, "Veggie", true),
            new Pizza(3, "Pepperoni", false),
            new Pizza(4, "Hawaiian", false) // extra pizza
        };

        [HttpGet]
        public IEnumerable<Pizza> Get() => Pizzas;
    }
}
