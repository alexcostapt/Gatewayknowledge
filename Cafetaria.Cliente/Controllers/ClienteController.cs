﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Cafetaria.Cliente.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClienteController : ControllerBase
    {
        private readonly List<string> clientes =
        [
            "Evan None",
            "Alinea Maria",
            "Thaison Filho",
            "Fernando Velheiro",
            "Talio Ferdinando",
            "Mickey Developer"
        ];

        [HttpGet]
        public IEnumerable<string> Get()
        {
            return clientes;
        }

        [HttpGet("{id:int}", Name = "Get")]
        public ActionResult Get(int id)
        {
            if (id <= clientes.Count - 1 && id >= 0)
                return Ok(clientes[id]);
            else
                return BadRequest($"{id} inválido");
        }
    }
}
