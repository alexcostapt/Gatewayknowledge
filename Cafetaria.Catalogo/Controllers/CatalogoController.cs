using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Cafetaria.Catalogo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CatalogoController : ControllerBase
    {
        readonly List<string> catalogo =
        [
            "Latte",
            "Americano",
            "Expresso",
            "Mocha",
            "Chá",
            "Capuccino"
        ];

        [HttpGet]
        public List<string> Get()
        {
            return catalogo;
        }
    }
}
