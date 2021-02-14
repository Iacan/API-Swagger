using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class calculajurosController : ControllerBase
    {
        /// <summary>
        /// Obter todos os usuários.
        /// </summary>
        /// <response code="200">Calculo de juros obtido com sucesso.</response>
        /// <response code="500">Ocorreu um erro ao obter o calculo de juros.</response>
        [HttpGet]
        [ProducesResponseType(typeof(double), 200)]
        [ProducesResponseType(500)]
        public IActionResult Get(double valorinicial, int meses)
        {
            var valor = CalculaJuros(valorinicial, meses);
            return Ok(valor);
        }

        private double CalculaJuros(double valorinicial, int meses)
        {
            double valorFinal = Math.Round(valorinicial * Math.Pow(1 + 0.01,meses), 2);
            return valorFinal;
        }
    }
}