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

        /// <summary>
        /// Realiza o Calculo do Juros, Dado um Valor Inicial e Temp. 
        /// </summary>
        /// <param name="valorinicial"></param>
        /// <param name="meses"></param>
        /// <returns></returns>
        private double CalculaJuros(double valorinicial, int meses)
        {
            taxajurosController RecuperaTaxaDeJuros = new taxajurosController();
            var taxaDeJuros = RecuperaTaxaDeJuros.Get() as OkObjectResult;
            
            double valorFinal = Math.Round(valorinicial * Math.Pow(1 + Convert.ToDouble(taxaDeJuros.Value), meses), 2);
            return valorFinal;
        }
    }
}