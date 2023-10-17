using BeeSolverApi.BusinessLogic;
using BeeSolverApi.Model;
using Microsoft.AspNetCore.Mvc;

namespace BeeSolverApi.Controllers
{
    public class BeeSolverController : Controller
    {
        private readonly IMagicCardBusinessLogic _magicCardBusinessLogics = null;
        public BeeSolverController(IMagicCardBusinessLogic magicCardBusinessLogics)
        {
            _magicCardBusinessLogics= magicCardBusinessLogics;
        }

        [HttpGet("cards")]
        public IActionResult GetMagicCards([FromQuery] CardFilter cardFilter)
        {
            var response= _magicCardBusinessLogics.GetMagicCards(cardFilter);
            return Ok(response);
        }
    }
}
