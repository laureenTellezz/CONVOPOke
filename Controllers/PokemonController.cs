using Microsoft.AspNetCore.Mvc;

using Microsoft.AspNetCore.Cors;
using DTO;
using AppLogic;

namespace CONVOPOke.Controllers
{
    [EnableCors("Demo_Policy")]
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class PokemonController : Controller
    {

        [HttpGet]
        public ActionResult<Pokemon> GetPokemon(string pokemonName)
        {

            PokemonManager manager = new PokemonManager();
            Pokemon pokemon = manager.GetPokemons(pokemonName);
            if (pokemon == null)
            {
                return NotFound();
            }
            return pokemon;

        }

        [HttpPost]
        public string CreatePokemon(Pokemon pokemon)
        {
            PokemonManager manager = new PokemonManager();
            return manager.CreatePokemon(pokemon);
        }

        [HttpGet]
        public List<Pokemon> GetPokemoonBd()
        {
            PokemonManager pm = new PokemonManager();
            return pm.GetAllPokemon();
        }

    }
}
